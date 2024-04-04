using System.Windows.Forms;
using System.Drawing;

namespace Hotel
{
    partial class HotelMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelMainForm));
            mainTableLayoutPanel = new TableLayoutPanel();
            hotelFormContentTableLayoutPanel = new TableLayoutPanel();
            guestStatusesTableLayoutPanel = new TableLayoutPanel();
            statusTitleLabel = new Label();
            guestListTableLayoutPanel = new TableLayoutPanel();
            guestFullNameLabel = new Label();
            guestInformationTableLayoutPanel = new TableLayoutPanel();
            hotelFormMenuTableLayoutPanel = new TableLayoutPanel();
            clockLabel = new Label();
            searchLineTextBox = new TextBox();
            searchPictureBox = new PictureBox();
            clockTimer = new Timer(components);
            mainTableLayoutPanel.SuspendLayout();
            hotelFormContentTableLayoutPanel.SuspendLayout();
            guestStatusesTableLayoutPanel.SuspendLayout();
            guestListTableLayoutPanel.SuspendLayout();
            hotelFormMenuTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).BeginInit();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(hotelFormContentTableLayoutPanel, 0, 1);
            mainTableLayoutPanel.Controls.Add(hotelFormMenuTableLayoutPanel, 0, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 2;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            mainTableLayoutPanel.Size = new Size(982, 653);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // hotelFormContentTableLayoutPanel
            // 
            hotelFormContentTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            hotelFormContentTableLayoutPanel.ColumnCount = 3;
            hotelFormContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            hotelFormContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            hotelFormContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            hotelFormContentTableLayoutPanel.Controls.Add(guestStatusesTableLayoutPanel, 0, 0);
            hotelFormContentTableLayoutPanel.Controls.Add(guestListTableLayoutPanel, 1, 0);
            hotelFormContentTableLayoutPanel.Controls.Add(guestInformationTableLayoutPanel, 2, 0);
            hotelFormContentTableLayoutPanel.Dock = DockStyle.Fill;
            hotelFormContentTableLayoutPanel.Location = new Point(0, 65);
            hotelFormContentTableLayoutPanel.Margin = new Padding(0);
            hotelFormContentTableLayoutPanel.Name = "hotelFormContentTableLayoutPanel";
            hotelFormContentTableLayoutPanel.RowCount = 1;
            hotelFormContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            hotelFormContentTableLayoutPanel.Size = new Size(982, 588);
            hotelFormContentTableLayoutPanel.TabIndex = 0;
            // 
            // guestStatusesTableLayoutPanel
            // 
            guestStatusesTableLayoutPanel.ColumnCount = 1;
            guestStatusesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            guestStatusesTableLayoutPanel.Controls.Add(statusTitleLabel, 0, 0);
            guestStatusesTableLayoutPanel.Dock = DockStyle.Fill;
            guestStatusesTableLayoutPanel.Location = new Point(1, 1);
            guestStatusesTableLayoutPanel.Margin = new Padding(0);
            guestStatusesTableLayoutPanel.Name = "guestStatusesTableLayoutPanel";
            guestStatusesTableLayoutPanel.RowCount = 2;
            guestStatusesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            guestStatusesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            guestStatusesTableLayoutPanel.Size = new Size(215, 586);
            guestStatusesTableLayoutPanel.TabIndex = 0;
            // 
            // statusTitleLabel
            // 
            statusTitleLabel.AutoSize = true;
            statusTitleLabel.Dock = DockStyle.Fill;
            statusTitleLabel.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statusTitleLabel.Location = new Point(3, 0);
            statusTitleLabel.Name = "statusTitleLabel";
            statusTitleLabel.Size = new Size(209, 87);
            statusTitleLabel.TabIndex = 0;
            statusTitleLabel.Text = "Статус";
            statusTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guestListTableLayoutPanel
            // 
            guestListTableLayoutPanel.ColumnCount = 1;
            guestListTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            guestListTableLayoutPanel.Controls.Add(guestFullNameLabel, 0, 0);
            guestListTableLayoutPanel.Dock = DockStyle.Fill;
            guestListTableLayoutPanel.Location = new Point(217, 1);
            guestListTableLayoutPanel.Margin = new Padding(0);
            guestListTableLayoutPanel.Name = "guestListTableLayoutPanel";
            guestListTableLayoutPanel.RowCount = 2;
            guestListTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            guestListTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            guestListTableLayoutPanel.Size = new Size(391, 586);
            guestListTableLayoutPanel.TabIndex = 1;
            // 
            // guestFullNameLabel
            // 
            guestFullNameLabel.AutoSize = true;
            guestFullNameLabel.Dock = DockStyle.Fill;
            guestFullNameLabel.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            guestFullNameLabel.Location = new Point(3, 0);
            guestFullNameLabel.Name = "guestFullNameLabel";
            guestFullNameLabel.Size = new Size(385, 87);
            guestFullNameLabel.TabIndex = 0;
            guestFullNameLabel.Text = "ФИО гостя";
            guestFullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guestInformationTableLayoutPanel
            // 
            guestInformationTableLayoutPanel.ColumnCount = 1;
            guestInformationTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            guestInformationTableLayoutPanel.Dock = DockStyle.Fill;
            guestInformationTableLayoutPanel.Location = new Point(609, 1);
            guestInformationTableLayoutPanel.Margin = new Padding(0);
            guestInformationTableLayoutPanel.Name = "guestInformationTableLayoutPanel";
            guestInformationTableLayoutPanel.RowCount = 6;
            guestInformationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            guestInformationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            guestInformationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            guestInformationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            guestInformationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            guestInformationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            guestInformationTableLayoutPanel.Size = new Size(372, 586);
            guestInformationTableLayoutPanel.TabIndex = 2;
            // 
            // hotelFormMenuTableLayoutPanel
            // 
            hotelFormMenuTableLayoutPanel.ColumnCount = 3;
            hotelFormMenuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            hotelFormMenuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            hotelFormMenuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            hotelFormMenuTableLayoutPanel.Controls.Add(clockLabel, 0, 0);
            hotelFormMenuTableLayoutPanel.Controls.Add(searchLineTextBox, 1, 0);
            hotelFormMenuTableLayoutPanel.Controls.Add(searchPictureBox, 2, 0);
            hotelFormMenuTableLayoutPanel.Dock = DockStyle.Fill;
            hotelFormMenuTableLayoutPanel.Location = new Point(0, 0);
            hotelFormMenuTableLayoutPanel.Margin = new Padding(0);
            hotelFormMenuTableLayoutPanel.Name = "hotelFormMenuTableLayoutPanel";
            hotelFormMenuTableLayoutPanel.RowCount = 1;
            hotelFormMenuTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            hotelFormMenuTableLayoutPanel.Size = new Size(982, 65);
            hotelFormMenuTableLayoutPanel.TabIndex = 1;
            // 
            // clockLabel
            // 
            clockLabel.AutoSize = true;
            clockLabel.Dock = DockStyle.Fill;
            clockLabel.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clockLabel.Location = new Point(4, 0);
            clockLabel.Margin = new Padding(4, 0, 4, 0);
            clockLabel.Name = "clockLabel";
            clockLabel.Size = new Size(237, 65);
            clockLabel.TabIndex = 0;
            clockLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchLineTextBox
            // 
            searchLineTextBox.BackColor = SystemColors.Control;
            searchLineTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchLineTextBox.Cursor = Cursors.IBeam;
            searchLineTextBox.Dock = DockStyle.Fill;
            searchLineTextBox.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchLineTextBox.ForeColor = SystemColors.WindowText;
            searchLineTextBox.Location = new Point(248, 13);
            searchLineTextBox.Margin = new Padding(3, 13, 3, 3);
            searchLineTextBox.Name = "searchLineTextBox";
            searchLineTextBox.PlaceholderText = "Поиск ...";
            searchLineTextBox.Size = new Size(632, 34);
            searchLineTextBox.TabIndex = 1;
            searchLineTextBox.TabStop = false;
            // 
            // searchPictureBox
            // 
            searchPictureBox.Cursor = Cursors.Hand;
            searchPictureBox.Dock = DockStyle.Fill;
            searchPictureBox.Image = (Image)resources.GetObject("searchPictureBox.Image");
            searchPictureBox.Location = new Point(899, 16);
            searchPictureBox.Margin = new Padding(16);
            searchPictureBox.Name = "searchPictureBox";
            searchPictureBox.Size = new Size(67, 33);
            searchPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            searchPictureBox.TabIndex = 2;
            searchPictureBox.TabStop = false;
            searchPictureBox.Click += SearchPictureBoxClick;
            // 
            // clockTimer
            // 
            clockTimer.Enabled = true;
            clockTimer.Interval = 10;
            clockTimer.Tick += ClockTimerTick;
            // 
            // HotelMainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(982, 653);
            Controls.Add(mainTableLayoutPanel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "HotelMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Отель";
            Load += HotelMainFormLoad;
            mainTableLayoutPanel.ResumeLayout(false);
            hotelFormContentTableLayoutPanel.ResumeLayout(false);
            guestStatusesTableLayoutPanel.ResumeLayout(false);
            guestStatusesTableLayoutPanel.PerformLayout();
            guestListTableLayoutPanel.ResumeLayout(false);
            guestListTableLayoutPanel.PerformLayout();
            hotelFormMenuTableLayoutPanel.ResumeLayout(false);
            hotelFormMenuTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private TableLayoutPanel hotelFormContentTableLayoutPanel;
        private TableLayoutPanel guestStatusesTableLayoutPanel;
        private TableLayoutPanel guestListTableLayoutPanel;
        private TableLayoutPanel guestInformationTableLayoutPanel;
        private TableLayoutPanel hotelFormMenuTableLayoutPanel;
        private Label clockLabel;
        private Timer clockTimer;
        private Label statusTitleLabel;
        private Label guestFullNameLabel;
        private TextBox searchLineTextBox;
        private PictureBox searchPictureBox;
    }
}