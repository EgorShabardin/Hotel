using System.Windows.Forms;
using System.Drawing;

namespace Hotel
{
    partial class GuestCardInformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestCardInformationForm));
            guestCardInformationTableLayoutPanel = new TableLayoutPanel();
            guestFullNameLabel = new Label();
            guestBirthdayLabel = new Label();
            paymentLabel = new Label();
            amountOfDaysTableLayoutPanel = new TableLayoutPanel();
            amountOfDaysTitleLabel = new Label();
            amountOfDaysNumericUpDown = new NumericUpDown();
            travelingWithAnimalsCheckBox = new CheckBox();
            saveButton = new Button();
            guestCardInformationTableLayoutPanel.SuspendLayout();
            amountOfDaysTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountOfDaysNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // guestCardInformationTableLayoutPanel
            // 
            guestCardInformationTableLayoutPanel.ColumnCount = 1;
            guestCardInformationTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            guestCardInformationTableLayoutPanel.Controls.Add(guestFullNameLabel, 0, 1);
            guestCardInformationTableLayoutPanel.Controls.Add(guestBirthdayLabel, 0, 2);
            guestCardInformationTableLayoutPanel.Controls.Add(paymentLabel, 0, 3);
            guestCardInformationTableLayoutPanel.Controls.Add(amountOfDaysTableLayoutPanel, 0, 4);
            guestCardInformationTableLayoutPanel.Controls.Add(travelingWithAnimalsCheckBox, 0, 5);
            guestCardInformationTableLayoutPanel.Controls.Add(saveButton, 0, 6);
            guestCardInformationTableLayoutPanel.Dock = DockStyle.Fill;
            guestCardInformationTableLayoutPanel.Location = new Point(0, 0);
            guestCardInformationTableLayoutPanel.Margin = new Padding(0);
            guestCardInformationTableLayoutPanel.Name = "guestCardInformationTableLayoutPanel";
            guestCardInformationTableLayoutPanel.RowCount = 7;
            guestCardInformationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3448277F));
            guestCardInformationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9425287F));
            guestCardInformationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9425287F));
            guestCardInformationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9425287F));
            guestCardInformationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9425287F));
            guestCardInformationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9425287F));
            guestCardInformationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9425287F));
            guestCardInformationTableLayoutPanel.Size = new Size(482, 553);
            guestCardInformationTableLayoutPanel.TabIndex = 0;
            // 
            // guestFullNameLabel
            // 
            guestFullNameLabel.AutoSize = true;
            guestFullNameLabel.BorderStyle = BorderStyle.FixedSingle;
            guestFullNameLabel.Dock = DockStyle.Fill;
            guestFullNameLabel.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            guestFullNameLabel.Location = new Point(15, 72);
            guestFullNameLabel.Margin = new Padding(15);
            guestFullNameLabel.Name = "guestFullNameLabel";
            guestFullNameLabel.Size = new Size(452, 52);
            guestFullNameLabel.TabIndex = 0;
            guestFullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guestBirthdayLabel
            // 
            guestBirthdayLabel.AutoSize = true;
            guestBirthdayLabel.BorderStyle = BorderStyle.FixedSingle;
            guestBirthdayLabel.Dock = DockStyle.Fill;
            guestBirthdayLabel.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            guestBirthdayLabel.Location = new Point(15, 154);
            guestBirthdayLabel.Margin = new Padding(15);
            guestBirthdayLabel.Name = "guestBirthdayLabel";
            guestBirthdayLabel.Size = new Size(452, 52);
            guestBirthdayLabel.TabIndex = 1;
            guestBirthdayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.BorderStyle = BorderStyle.FixedSingle;
            paymentLabel.Dock = DockStyle.Fill;
            paymentLabel.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            paymentLabel.Location = new Point(15, 236);
            paymentLabel.Margin = new Padding(15);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new Size(452, 52);
            paymentLabel.TabIndex = 3;
            paymentLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // amountOfDaysTableLayoutPanel
            // 
            amountOfDaysTableLayoutPanel.ColumnCount = 2;
            amountOfDaysTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            amountOfDaysTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            amountOfDaysTableLayoutPanel.Controls.Add(amountOfDaysTitleLabel, 1, 0);
            amountOfDaysTableLayoutPanel.Controls.Add(amountOfDaysNumericUpDown, 0, 0);
            amountOfDaysTableLayoutPanel.Dock = DockStyle.Fill;
            amountOfDaysTableLayoutPanel.Location = new Point(0, 303);
            amountOfDaysTableLayoutPanel.Margin = new Padding(0);
            amountOfDaysTableLayoutPanel.Name = "amountOfDaysTableLayoutPanel";
            amountOfDaysTableLayoutPanel.RowCount = 1;
            amountOfDaysTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            amountOfDaysTableLayoutPanel.Size = new Size(482, 82);
            amountOfDaysTableLayoutPanel.TabIndex = 4;
            // 
            // amountOfDaysTitleLabel
            // 
            amountOfDaysTitleLabel.AutoSize = true;
            amountOfDaysTitleLabel.BorderStyle = BorderStyle.FixedSingle;
            amountOfDaysTitleLabel.Dock = DockStyle.Fill;
            amountOfDaysTitleLabel.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            amountOfDaysTitleLabel.Location = new Point(272, 7);
            amountOfDaysTitleLabel.Margin = new Padding(7, 7, 16, 7);
            amountOfDaysTitleLabel.Name = "amountOfDaysTitleLabel";
            amountOfDaysTitleLabel.Size = new Size(194, 68);
            amountOfDaysTitleLabel.TabIndex = 0;
            amountOfDaysTitleLabel.Text = "Количество дней";
            amountOfDaysTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // amountOfDaysNumericUpDown
            // 
            amountOfDaysNumericUpDown.BackColor = SystemColors.Window;
            amountOfDaysNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            amountOfDaysNumericUpDown.Dock = DockStyle.Fill;
            amountOfDaysNumericUpDown.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            amountOfDaysNumericUpDown.Location = new Point(60, 21);
            amountOfDaysNumericUpDown.Margin = new Padding(60, 21, 60, 3);
            amountOfDaysNumericUpDown.Name = "amountOfDaysNumericUpDown";
            amountOfDaysNumericUpDown.ReadOnly = true;
            amountOfDaysNumericUpDown.Size = new Size(145, 39);
            amountOfDaysNumericUpDown.TabIndex = 0;
            amountOfDaysNumericUpDown.TabStop = false;
            amountOfDaysNumericUpDown.TextAlign = HorizontalAlignment.Center;
            amountOfDaysNumericUpDown.ThousandsSeparator = true;
            amountOfDaysNumericUpDown.ValueChanged += AmountOfDaysNumericUpDownValueChanged;
            // 
            // travelingWithAnimalsCheckBox
            // 
            travelingWithAnimalsCheckBox.AutoSize = true;
            travelingWithAnimalsCheckBox.Cursor = Cursors.Hand;
            travelingWithAnimalsCheckBox.Dock = DockStyle.Left;
            travelingWithAnimalsCheckBox.FlatStyle = FlatStyle.System;
            travelingWithAnimalsCheckBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            travelingWithAnimalsCheckBox.Location = new Point(15, 388);
            travelingWithAnimalsCheckBox.Margin = new Padding(15, 3, 3, 3);
            travelingWithAnimalsCheckBox.Name = "travelingWithAnimalsCheckBox";
            travelingWithAnimalsCheckBox.Size = new Size(289, 76);
            travelingWithAnimalsCheckBox.TabIndex = 5;
            travelingWithAnimalsCheckBox.Text = "Путешествую с животными";
            travelingWithAnimalsCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.DeepSkyBlue;
            saveButton.Cursor = Cursors.Hand;
            saveButton.Dock = DockStyle.Fill;
            saveButton.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            saveButton.Location = new Point(130, 482);
            saveButton.Margin = new Padding(130, 15, 130, 15);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(222, 56);
            saveButton.TabIndex = 6;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += SaveButtonClick;
            // 
            // GuestCardInformationForm
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(482, 553);
            Controls.Add(guestCardInformationTableLayoutPanel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "GuestCardInformationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Карточка постояльца отеля";
            FormClosing += GuestCardInformationFormFormClosing;
            guestCardInformationTableLayoutPanel.ResumeLayout(false);
            guestCardInformationTableLayoutPanel.PerformLayout();
            amountOfDaysTableLayoutPanel.ResumeLayout(false);
            amountOfDaysTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountOfDaysNumericUpDown).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private TableLayoutPanel guestCardInformationTableLayoutPanel;
        private Label guestFullNameLabel;
        private Label guestBirthdayLabel;
        private Label paymentLabel;
        private TableLayoutPanel amountOfDaysTableLayoutPanel;
        private Label amountOfDaysTitleLabel;
        private NumericUpDown amountOfDaysNumericUpDown;
        private CheckBox travelingWithAnimalsCheckBox;
        private Button saveButton;
    }
}