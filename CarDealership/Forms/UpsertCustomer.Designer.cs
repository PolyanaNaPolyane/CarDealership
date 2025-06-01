namespace CarDealership.Forms
{
    partial class UpsertCustomer
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
            budgetTextBox = new TextBox();
            addressTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            nameTextBox = new TextBox();
            budgetLabel = new Label();
            requirementsGroupBox = new GroupBox();
            birthYearLabel = new Label();
            birthYearTextBox = new TextBox();
            brandNameTextBox = new TextBox();
            technicalConditionComboBox = new ComboBox();
            brandNameLabel = new Label();
            engineCapacityLabel = new Label();
            topSpeedTextBox = new TextBox();
            technicalConditionLabel = new Label();
            engineCapacityTextBox = new TextBox();
            topSpeedLabel = new Label();
            addressLabel = new Label();
            phoneNumberLabel = new Label();
            nameLabel = new Label();
            upsertButton = new Button();
            requirementsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // budgetTextBox
            // 
            budgetTextBox.Location = new Point(118, 408);
            budgetTextBox.Name = "budgetTextBox";
            budgetTextBox.Size = new Size(125, 27);
            budgetTextBox.TabIndex = 35;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(118, 94);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(125, 27);
            addressTextBox.TabIndex = 34;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(118, 46);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(125, 27);
            phoneNumberTextBox.TabIndex = 33;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(118, 2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 32;
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Location = new Point(12, 415);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new Size(66, 20);
            budgetLabel.TabIndex = 31;
            budgetLabel.Text = "Бюджет:";
            // 
            // requirementsGroupBox
            // 
            requirementsGroupBox.Controls.Add(birthYearLabel);
            requirementsGroupBox.Controls.Add(birthYearTextBox);
            requirementsGroupBox.Controls.Add(brandNameTextBox);
            requirementsGroupBox.Controls.Add(technicalConditionComboBox);
            requirementsGroupBox.Controls.Add(brandNameLabel);
            requirementsGroupBox.Controls.Add(engineCapacityLabel);
            requirementsGroupBox.Controls.Add(topSpeedTextBox);
            requirementsGroupBox.Controls.Add(technicalConditionLabel);
            requirementsGroupBox.Controls.Add(engineCapacityTextBox);
            requirementsGroupBox.Controls.Add(topSpeedLabel);
            requirementsGroupBox.Location = new Point(12, 141);
            requirementsGroupBox.Name = "requirementsGroupBox";
            requirementsGroupBox.Size = new Size(252, 251);
            requirementsGroupBox.TabIndex = 30;
            requirementsGroupBox.TabStop = false;
            requirementsGroupBox.Text = "Вимоги";
            // 
            // birthYearLabel
            // 
            birthYearLabel.AutoSize = true;
            birthYearLabel.Location = new Point(11, 75);
            birthYearLabel.Name = "birthYearLabel";
            birthYearLabel.Size = new Size(31, 20);
            birthYearLabel.TabIndex = 25;
            birthYearLabel.Text = "Рік:";
            // 
            // birthYearTextBox
            // 
            birthYearTextBox.Location = new Point(106, 68);
            birthYearTextBox.Name = "birthYearTextBox";
            birthYearTextBox.Size = new Size(125, 27);
            birthYearTextBox.TabIndex = 26;
            // 
            // brandNameTextBox
            // 
            brandNameTextBox.Location = new Point(106, 26);
            brandNameTextBox.Name = "brandNameTextBox";
            brandNameTextBox.Size = new Size(125, 27);
            brandNameTextBox.TabIndex = 10;
            // 
            // technicalConditionComboBox
            // 
            technicalConditionComboBox.FormattingEnabled = true;
            technicalConditionComboBox.Items.AddRange(new object[] { "Нова", "Б/У", "Після ДТП" });
            technicalConditionComboBox.Location = new Point(106, 209);
            technicalConditionComboBox.Name = "technicalConditionComboBox";
            technicalConditionComboBox.Size = new Size(125, 28);
            technicalConditionComboBox.TabIndex = 24;
            // 
            // brandNameLabel
            // 
            brandNameLabel.AutoSize = true;
            brandNameLabel.Location = new Point(11, 33);
            brandNameLabel.Name = "brandNameLabel";
            brandNameLabel.Size = new Size(55, 20);
            brandNameLabel.TabIndex = 4;
            brandNameLabel.Text = "Бренд:";
            // 
            // engineCapacityLabel
            // 
            engineCapacityLabel.AutoSize = true;
            engineCapacityLabel.Location = new Point(11, 120);
            engineCapacityLabel.Name = "engineCapacityLabel";
            engineCapacityLabel.Size = new Size(53, 20);
            engineCapacityLabel.TabIndex = 13;
            engineCapacityLabel.Text = "Об'єм:";
            // 
            // topSpeedTextBox
            // 
            topSpeedTextBox.Location = new Point(106, 160);
            topSpeedTextBox.Name = "topSpeedTextBox";
            topSpeedTextBox.Size = new Size(125, 27);
            topSpeedTextBox.TabIndex = 15;
            // 
            // technicalConditionLabel
            // 
            technicalConditionLabel.AutoSize = true;
            technicalConditionLabel.Location = new Point(11, 217);
            technicalConditionLabel.Name = "technicalConditionLabel";
            technicalConditionLabel.Size = new Size(44, 20);
            technicalConditionLabel.TabIndex = 23;
            technicalConditionLabel.Text = "Стан:";
            // 
            // engineCapacityTextBox
            // 
            engineCapacityTextBox.Location = new Point(106, 113);
            engineCapacityTextBox.Name = "engineCapacityTextBox";
            engineCapacityTextBox.Size = new Size(125, 27);
            engineCapacityTextBox.TabIndex = 16;
            // 
            // topSpeedLabel
            // 
            topSpeedLabel.AutoSize = true;
            topSpeedLabel.Location = new Point(11, 167);
            topSpeedLabel.Name = "topSpeedLabel";
            topSpeedLabel.Size = new Size(83, 20);
            topSpeedLabel.TabIndex = 14;
            topSpeedLabel.Text = "Швидкість:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(12, 101);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(62, 20);
            addressLabel.TabIndex = 29;
            addressLabel.Text = "Адреса:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(12, 53);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(72, 20);
            phoneNumberLabel.TabIndex = 28;
            phoneNumberLabel.Text = "Телефон:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(38, 20);
            nameLabel.TabIndex = 27;
            nameLabel.Text = "Ім'я:";
            // 
            // upsertButton
            // 
            upsertButton.Location = new Point(82, 454);
            upsertButton.Name = "upsertButton";
            upsertButton.Size = new Size(94, 29);
            upsertButton.TabIndex = 26;
            upsertButton.Text = "button1";
            upsertButton.UseVisualStyleBackColor = true;
            upsertButton.Click += upsertButton_Click;
            // 
            // UpsertCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 504);
            Controls.Add(budgetTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(budgetLabel);
            Controls.Add(requirementsGroupBox);
            Controls.Add(addressLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(nameLabel);
            Controls.Add(upsertButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UpsertCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpsertCustomer";
            requirementsGroupBox.ResumeLayout(false);
            requirementsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox budgetTextBox;
        private TextBox addressTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox nameTextBox;
        private Label budgetLabel;
        private GroupBox requirementsGroupBox;
        private TextBox brandNameTextBox;
        private ComboBox technicalConditionComboBox;
        private Label brandNameLabel;
        private Label engineCapacityLabel;
        private TextBox topSpeedTextBox;
        private Label technicalConditionLabel;
        private TextBox engineCapacityTextBox;
        private Label topSpeedLabel;
        private Label addressLabel;
        private Label phoneNumberLabel;
        private Label nameLabel;
        private Button upsertButton;
        private Label birthYearLabel;
        private TextBox birthYearTextBox;
    }
}