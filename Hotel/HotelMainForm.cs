using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using System.Drawing;
using Hotel.Database;
using System.Linq;
using System.IO;
using System;
using NLog;

namespace Hotel
{
    public partial class HotelMainForm : Form
    {
        #region ����
        int guestId = -1;
        ComboBox guestStatusComboBox = null!;
        Logger logger = LogManager.GetCurrentClassLogger();
        #endregion

        #region �������
        private void HotelMainFormLoad(object sender, EventArgs e)
        {
            using (var database = new HotelDatabaseContext())
            {
                logger.Info("�������� ����������� � ���� ������ ��� �������� �����");
                var statuses = database.Statuses.Select(status => status.StatusName).ToList();
                logger.Debug($"��������� � ���� ������. ��������� {statuses.Count} ������� �� ���������");
                guestStatusesTableLayoutPanel.RowStyles.Clear();
                guestStatusesTableLayoutPanel.RowCount = statuses.Count + 2;
                guestStatusesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));

                for (int i = 0; i < statuses.Count; i++)
                {
                    var statusNameRadioButton = new RadioButton();
                    statusNameRadioButton.Text = statuses[i];
                    statusNameRadioButton.Dock = DockStyle.Fill;
                    statusNameRadioButton.Margin = new Padding(10, 0, 0, 0);
                    statusNameRadioButton.Cursor = Cursors.Hand;
                    statusNameRadioButton.CheckedChanged += StatusRadioButtonCheckedChange;
                    logger.Debug($"������� ������ � ��������� {statuses[i]}");
                    guestStatusesTableLayoutPanel.Controls.Add(statusNameRadioButton);
                    guestStatusesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                }

                logger.Debug($"� ����� ���� ������� {guestStatusesTableLayoutPanel.Controls.Count - 1} ������ �� ���������");
                guestStatusesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85 - (10 * statuses.Count)));
            }
        }

        private void StatusRadioButtonCheckedChange(object sender, EventArgs e)
        {
            using (var database = new HotelDatabaseContext())
            {
                logger.Info("�������� ����������� � ���� ������ ��� ������ �������");
                var statusNameRadioButton = sender as RadioButton;

                if ((statusNameRadioButton != null) && (statusNameRadioButton.Checked == true))
                {
                    ClassOfMethodsForUnitTests.DeletesContentOfTableLayoutPanel(guestListTableLayoutPanel);

                    var guests = database.HotelGuests.Where(guests => guests.GuestStatusNavigation.StatusName
                                                                            == statusNameRadioButton.Text).ToList();
                    logger.Debug($"��������� � ���� ������. ��������� {guests.Count} ������� � ������� �����������");
                    guestListTableLayoutPanel.RowStyles.Clear();
                    guestListTableLayoutPanel.RowCount = guests.Count + 2;
                    guestListTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));

                    for (int i = 0; i < guests.Count; i++)
                    {
                        var guestFullNameLabel = new Label();
                        guestFullNameLabel.Dock = DockStyle.Fill;
                        guestFullNameLabel.Name = $"{guests[i].GuestId}";
                        guestFullNameLabel.Text = $"{guests[i].GuestSurname} {guests[i].GuestName} {guests[i].GuestPatronymic}";
                        guestFullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                        guestFullNameLabel.DoubleClick += GuestFullNameLabelDoubleClick;
                        guestFullNameLabel.Cursor = Cursors.Hand;
                        logger.Debug($"��������� ������ ��� ���������� � �������� {guests[i].GuestId}");
                        guestListTableLayoutPanel.Controls.Add(guestFullNameLabel);
                        guestListTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                    }

                    logger.Debug($"� ����� ���� ������� {guestListTableLayoutPanel.Controls.Count - 1} " +
                                            $"������� ����������� �� �������� {statusNameRadioButton.Text}");
                    guestListTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85 - (10 * guests.Count)));
                }
                else
                {
                    logger.Error("�� ���������� ������ �� ��������");
                }
            }
        }

        private void GuestFullNameLabelDoubleClick(object sender, EventArgs e)
        {
            using (var database = new HotelDatabaseContext())
            {
                logger.Info("�������� ����������� � ���� ������ ��� ������� ������� �� ��� ����������");
                var guestFullName = sender as Label;
                guestInformationTableLayoutPanel.Controls.Clear();

                if (guestFullName != null)
                {
                    var guestInfo = database.HotelGuests.Include(guest => guest.GuestStatusNavigation)
                                .Where(guest => guest.GuestId == int.Parse(guestFullName.Name)).FirstOrDefault();

                    if (guestInfo != null)
                    {
                        logger.Debug($"��������� � ���� ������. ��������� ������ � ���������� � �������� {guestInfo.GuestId}");
                        guestId = guestInfo.GuestId;

                        var guestPhotoPictureBox = new PictureBox();
                        MemoryStream guestPhoto = new MemoryStream(guestInfo.GuestPhoto);
                        guestPhotoPictureBox.Image = Image.FromStream(guestPhoto);
                        guestPhotoPictureBox.Dock = DockStyle.Fill;
                        guestPhotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        guestInformationTableLayoutPanel.Controls.Add(guestPhotoPictureBox);

                        var statusTableLayoutPanel = new TableLayoutPanel();
                        statusTableLayoutPanel.Dock = DockStyle.Fill;
                        statusTableLayoutPanel.RowCount = 1;
                        statusTableLayoutPanel.ColumnCount = 2;
                        statusTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
                        statusTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
                        guestInformationTableLayoutPanel.Controls.Add(statusTableLayoutPanel);

                        var guestStatusTitleLabel = new Label();
                        guestStatusTitleLabel.Text = "������";
                        guestStatusTitleLabel.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
                        guestStatusTitleLabel.Dock = DockStyle.Fill;
                        guestStatusTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                        statusTableLayoutPanel.Controls.Add(guestStatusTitleLabel, 0, 0);

                        var guestStatusComboBox = new ComboBox();
                        guestStatusComboBox.Items.AddRange(database.Statuses.Select(status => status.StatusName).ToArray());
                        guestStatusComboBox.SelectedItem = guestInfo.GuestStatusNavigation.StatusName;
                        guestStatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                        guestStatusComboBox.TabStop = false;
                        guestStatusComboBox.Margin = new Padding(0, 12, 30, 0);
                        guestStatusComboBox.Dock = DockStyle.Fill;
                        statusTableLayoutPanel.Controls.Add(guestStatusComboBox, 1, 0);
                        this.guestStatusComboBox = guestStatusComboBox;

                        var guestFullNameLabel = new Label();
                        guestFullNameLabel.Text = $"{guestInfo.GuestSurname} {guestInfo.GuestName} {guestInfo.GuestPatronymic}";
                        guestFullNameLabel.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
                        guestFullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                        guestFullNameLabel.Dock = DockStyle.Fill;
                        guestInformationTableLayoutPanel.Controls.Add(guestFullNameLabel);

                        var guestCheckInDateGroupBox = new GroupBox();
                        guestCheckInDateGroupBox.Text = "���� ������";
                        guestCheckInDateGroupBox.Dock = DockStyle.Fill;
                        guestCheckInDateGroupBox.Margin = new Padding(30, 5, 30, 5);
                        guestInformationTableLayoutPanel.Controls.Add(guestCheckInDateGroupBox);

                        var guestCheckInDateLabel = new Label();
                        guestCheckInDateLabel.Text = guestInfo.GuestCheckInDate;
                        guestCheckInDateLabel.Dock = DockStyle.Fill;
                        guestCheckInDateLabel.TextAlign = ContentAlignment.MiddleCenter;
                        guestCheckInDateLabel.Margin = new Padding(20);
                        guestCheckInDateGroupBox.Controls.Add(guestCheckInDateLabel);

                        var guestCheckOutDateGroupBox = new GroupBox();
                        guestCheckOutDateGroupBox.Text = "���� ������";
                        guestCheckOutDateGroupBox.Dock = DockStyle.Fill;
                        guestCheckOutDateGroupBox.Margin = new Padding(30, 5, 30, 5);
                        guestInformationTableLayoutPanel.Controls.Add(guestCheckOutDateGroupBox);

                        var guestCheckOutDateLabel = new Label();
                        guestCheckOutDateLabel.Text = guestInfo.GuestCheckOutDate;
                        guestCheckOutDateLabel.Dock = DockStyle.Fill;
                        guestCheckOutDateLabel.TextAlign = ContentAlignment.MiddleCenter;
                        guestCheckOutDateLabel.Margin = new Padding(20);
                        guestCheckOutDateGroupBox.Controls.Add(guestCheckOutDateLabel);

                        var guestInfoButtonsTableLayoutPanel = new TableLayoutPanel();
                        guestInfoButtonsTableLayoutPanel.Dock = DockStyle.Fill;
                        guestInfoButtonsTableLayoutPanel.RowCount = 1;
                        guestInfoButtonsTableLayoutPanel.ColumnCount = 2;
                        guestInfoButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                        guestInfoButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                        guestInformationTableLayoutPanel.Controls.Add(guestInfoButtonsTableLayoutPanel);

                        var saveButton = new Button();
                        saveButton.Text = "���������";
                        saveButton.Dock = DockStyle.Fill;
                        saveButton.TextAlign = ContentAlignment.MiddleCenter;
                        saveButton.FlatStyle = FlatStyle.Standard;
                        saveButton.Margin = new Padding(5, 12, 5, 18);
                        saveButton.BackColor = Color.DeepSkyBlue;
                        saveButton.Cursor = Cursors.Hand;
                        saveButton.Click += SaveButtonClick;
                        guestInfoButtonsTableLayoutPanel.Controls.Add(saveButton, 0, 0);

                        var viewGuestCardButton = new Button();
                        viewGuestCardButton.Text = "�������� ��������";
                        viewGuestCardButton.Dock = DockStyle.Fill;
                        viewGuestCardButton.TextAlign = ContentAlignment.MiddleCenter;
                        viewGuestCardButton.FlatStyle = FlatStyle.Standard;
                        viewGuestCardButton.Margin = new Padding(5, 12, 5, 18);
                        viewGuestCardButton.BackColor = Color.DeepSkyBlue;
                        viewGuestCardButton.Cursor = Cursors.Hand;
                        viewGuestCardButton.Click += ViewGuestCardButtonClick;
                        guestInfoButtonsTableLayoutPanel.Controls.Add(viewGuestCardButton, 1, 0);

                        logger.Info($"� ����� ���� ��������� ������ � ���������� � �������� {guestInfo.GuestId}");
                    }
                    else
                    {
                        logger.Error($"��������� � �������� {guestFullName.Name} �� ���������");
                    }
                }
                else
                {
                    logger.Error("������ � ��� ���������� �� ����������");
                }
            }
        }

        private void ClockTimerTick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            using (var database = new HotelDatabaseContext())
            {
                logger.Info("�������� ����������� � ���� ������ ��� ������� �� ������ ���������");
                var guestInfo = database.HotelGuests.Include(guest => guest.GuestStatusNavigation)
                                                .Where(guest => guest.GuestId == guestId).FirstOrDefault();

                if (guestInfo != null)
                {
                    logger.Debug($"��������� � ���� ������. ��������� ������ � ���������� � �������� {guestInfo.GuestId}");

                    if (guestInfo.GuestStatus != guestStatusComboBox.SelectedIndex + 1)
                    {
                        logger.Info($"������ ���������� � �������� {guestInfo.GuestId} ��������� " +
                                    $"� {guestInfo.GuestStatusNavigation.StatusName} �� {guestStatusComboBox.SelectedText}");
                        var status = database.Statuses.Where(statuses => statuses.StatusId == guestStatusComboBox.SelectedIndex + 1).First();
                        logger.Debug($"��������� � ���� ������. ��������� ������ � ������� � �������� {guestStatusComboBox.SelectedIndex + 1}");

                        guestInfo.GuestStatus = guestStatusComboBox.SelectedIndex + 1;
                        guestInfo.GuestStatusNavigation = status;
                        database.SaveChanges();
                        logger.Debug($"������ � ������� ���������� � �������� {guestInfo.GuestId} ������� ��������");

                        guestListTableLayoutPanel.Controls.Find($"{guestId}", true).First().Dispose();
                    }
                    else
                    {
                        logger.Debug($"������ ���������� � �������� {guestId} �� ���������. ���������� ���������");
                    }
                }
            }
        }

        private void ViewGuestCardButtonClick(object sender, EventArgs e)
        {
            logger.Info("������������ ����� �� ������ \"�������� ��������\". ����������� �������� ����������");
            var guestCardInformationForm = new GuestCardInformationForm(guestId);
            guestCardInformationForm.Show();
        }

        private void SearchPictureBoxClick(object sender, EventArgs e)
        {
            logger.Info("������������ ����� �� ������ ������");

            ClassOfMethodsForUnitTests.DeletesContentOfTableLayoutPanel(guestListTableLayoutPanel);

            for (int i = 1; i < guestStatusesTableLayoutPanel.Controls.Count; i++)
            {
                var statusNameRadioButton = guestStatusesTableLayoutPanel.Controls[i] as RadioButton;

                if (statusNameRadioButton != null)
                {
                    statusNameRadioButton.Checked = false;
                }
            }

            if (searchLineTextBox.Text.Length != 0)
            {
                using (var database = new HotelDatabaseContext())
                {
                    logger.Info("�������� ����������� � ���� ������ ��� ������� �� ������ ������");
                    var guests = database.HotelGuests.ToList();
                    logger.Debug($"��������� � ���� ������. ��������� {guests.Count} ������� � �����������");
                    guestListTableLayoutPanel.RowStyles.Clear();
                    guestListTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
                    var quantitySatisfyingConditions = 0;

                    for (int i = 0; i < guests.Count; i++)
                    {
                        var guestFullName = $"{guests[i].GuestSurname} {guests[i].GuestName} {guests[i].GuestPatronymic}";

                        if (guestFullName.Contains(searchLineTextBox.Text))
                        {
                            var guestFullNameLabel = new Label();
                            guestFullNameLabel.Dock = DockStyle.Fill;
                            guestFullNameLabel.Name = $"{guests[i].GuestId}";
                            guestFullNameLabel.Text = $"{guests[i].GuestSurname} {guests[i].GuestName} {guests[i].GuestPatronymic}";
                            guestFullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                            guestFullNameLabel.DoubleClick += GuestFullNameLabelDoubleClick;
                            guestFullNameLabel.Cursor = Cursors.Hand;
                            guestListTableLayoutPanel.Controls.Add(guestFullNameLabel);
                            guestListTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                            quantitySatisfyingConditions += 1;
                            logger.Debug($"������������ � �������� {guests[i].GuestId} ������������� �������� ������");
                        }
                    }

                    guestListTableLayoutPanel.RowCount = quantitySatisfyingConditions + 2;
                    guestListTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85 - (10 * quantitySatisfyingConditions)));
                }
            }
        }
        #endregion

        #region ������������
        public HotelMainForm()
        {
            InitializeComponent();
        }
        #endregion
    }
}