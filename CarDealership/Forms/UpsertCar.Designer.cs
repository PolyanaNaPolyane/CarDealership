namespace CarDealership.Forms
{
    partial class UpsertCar
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
            technicalConditionComboBox = new ComboBox();
            colorComboBox = new ComboBox();
            gearboxTypeComboBox = new ComboBox();
            engineTypeComboBox = new ComboBox();
            upsertButton = new Button();
            priceTextBox = new TextBox();
            topSpeedTextBox = new TextBox();
            engineCapacityTextBox = new TextBox();
            birthYearTextBox = new TextBox();
            brandNameTextBox = new TextBox();
            priceLabel = new Label();
            technicalConditionLabel = new Label();
            colorLabel = new Label();
            gearboxTypeLabel = new Label();
            engineTypeLabel = new Label();
            topSpeedLabel = new Label();
            engineCapacityLabel = new Label();
            birthYearLabel = new Label();
            brandNameLabel = new Label();
            SuspendLayout();
            // 
            // technicalConditionComboBox
            // 
            technicalConditionComboBox.FormattingEnabled = true;
            technicalConditionComboBox.Items.AddRange(new object[] { "Нова", "Б/У", "Після ДТП" });
            technicalConditionComboBox.Location = new Point(138, 333);
            technicalConditionComboBox.Name = "technicalConditionComboBox";
            technicalConditionComboBox.Size = new Size(151, 28);
            technicalConditionComboBox.TabIndex = 41;
            // 
            // colorComboBox
            // 
            colorComboBox.FormattingEnabled = true;
            colorComboBox.Items.AddRange(new object[] { "Білий", "Чорний", "Червоний", "Сірий", "Титановий", "Синій", "Рожевий", "Кремовий" });
            colorComboBox.Location = new Point(138, 288);
            colorComboBox.Name = "colorComboBox";
            colorComboBox.Size = new Size(151, 28);
            colorComboBox.TabIndex = 40;
            // 
            // gearboxTypeComboBox
            // 
            gearboxTypeComboBox.FormattingEnabled = true;
            gearboxTypeComboBox.Items.AddRange(new object[] { "Ручна", "Автоматична" });
            gearboxTypeComboBox.Location = new Point(138, 239);
            gearboxTypeComboBox.Name = "gearboxTypeComboBox";
            gearboxTypeComboBox.Size = new Size(151, 28);
            gearboxTypeComboBox.TabIndex = 39;
            // 
            // engineTypeComboBox
            // 
            engineTypeComboBox.FormattingEnabled = true;
            engineTypeComboBox.Items.AddRange(new object[] { "Бензиновий", "Гібридний", "Дизельний" });
            engineTypeComboBox.Location = new Point(138, 191);
            engineTypeComboBox.Name = "engineTypeComboBox";
            engineTypeComboBox.Size = new Size(151, 28);
            engineTypeComboBox.TabIndex = 38;
            // 
            // upsertButton
            // 
            upsertButton.Location = new Point(108, 432);
            upsertButton.Name = "upsertButton";
            upsertButton.Size = new Size(94, 29);
            upsertButton.TabIndex = 37;
            upsertButton.Text = "button1";
            upsertButton.UseVisualStyleBackColor = true;
            upsertButton.Click += upsertButton_Click;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(138, 380);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(151, 27);
            priceTextBox.TabIndex = 36;
            // 
            // topSpeedTextBox
            // 
            topSpeedTextBox.Location = new Point(138, 146);
            topSpeedTextBox.Name = "topSpeedTextBox";
            topSpeedTextBox.Size = new Size(151, 27);
            topSpeedTextBox.TabIndex = 35;
            // 
            // engineCapacityTextBox
            // 
            engineCapacityTextBox.Location = new Point(138, 101);
            engineCapacityTextBox.Name = "engineCapacityTextBox";
            engineCapacityTextBox.Size = new Size(151, 27);
            engineCapacityTextBox.TabIndex = 34;
            // 
            // birthYearTextBox
            // 
            birthYearTextBox.Location = new Point(138, 56);
            birthYearTextBox.Name = "birthYearTextBox";
            birthYearTextBox.Size = new Size(151, 27);
            birthYearTextBox.TabIndex = 33;
            // 
            // brandNameTextBox
            // 
            brandNameTextBox.Location = new Point(138, 11);
            brandNameTextBox.Name = "brandNameTextBox";
            brandNameTextBox.Size = new Size(151, 27);
            brandNameTextBox.TabIndex = 32;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(24, 387);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(41, 20);
            priceLabel.TabIndex = 31;
            priceLabel.Text = "Ціна";
            // 
            // technicalConditionLabel
            // 
            technicalConditionLabel.AutoSize = true;
            technicalConditionLabel.Location = new Point(24, 341);
            technicalConditionLabel.Name = "technicalConditionLabel";
            technicalConditionLabel.Size = new Size(44, 20);
            technicalConditionLabel.TabIndex = 30;
            technicalConditionLabel.Text = "Стан:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(24, 296);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(51, 20);
            colorLabel.TabIndex = 29;
            colorLabel.Text = "Колір:";
            // 
            // gearboxTypeLabel
            // 
            gearboxTypeLabel.AutoSize = true;
            gearboxTypeLabel.Location = new Point(24, 247);
            gearboxTypeLabel.Name = "gearboxTypeLabel";
            gearboxTypeLabel.Size = new Size(72, 20);
            gearboxTypeLabel.TabIndex = 28;
            gearboxTypeLabel.Text = "Коробка:";
            // 
            // engineTypeLabel
            // 
            engineTypeLabel.AutoSize = true;
            engineTypeLabel.Location = new Point(24, 199);
            engineTypeLabel.Name = "engineTypeLabel";
            engineTypeLabel.Size = new Size(97, 20);
            engineTypeLabel.TabIndex = 27;
            engineTypeLabel.Text = "Тип двигуна:";
            // 
            // topSpeedLabel
            // 
            topSpeedLabel.AutoSize = true;
            topSpeedLabel.Location = new Point(24, 153);
            topSpeedLabel.Name = "topSpeedLabel";
            topSpeedLabel.Size = new Size(83, 20);
            topSpeedLabel.TabIndex = 26;
            topSpeedLabel.Text = "Швидкість:";
            // 
            // engineCapacityLabel
            // 
            engineCapacityLabel.AutoSize = true;
            engineCapacityLabel.Location = new Point(24, 108);
            engineCapacityLabel.Name = "engineCapacityLabel";
            engineCapacityLabel.Size = new Size(53, 20);
            engineCapacityLabel.TabIndex = 25;
            engineCapacityLabel.Text = "Об'єм:";
            // 
            // birthYearLabel
            // 
            birthYearLabel.AutoSize = true;
            birthYearLabel.Location = new Point(24, 63);
            birthYearLabel.Name = "birthYearLabel";
            birthYearLabel.Size = new Size(31, 20);
            birthYearLabel.TabIndex = 24;
            birthYearLabel.Text = "Рік:";
            // 
            // brandNameLabel
            // 
            brandNameLabel.AutoSize = true;
            brandNameLabel.Location = new Point(24, 18);
            brandNameLabel.Name = "brandNameLabel";
            brandNameLabel.Size = new Size(57, 20);
            brandNameLabel.TabIndex = 23;
            brandNameLabel.Text = "Марка:";
            // 
            // UpsertCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 483);
            Controls.Add(technicalConditionComboBox);
            Controls.Add(colorComboBox);
            Controls.Add(gearboxTypeComboBox);
            Controls.Add(engineTypeComboBox);
            Controls.Add(upsertButton);
            Controls.Add(priceTextBox);
            Controls.Add(topSpeedTextBox);
            Controls.Add(engineCapacityTextBox);
            Controls.Add(birthYearTextBox);
            Controls.Add(brandNameTextBox);
            Controls.Add(priceLabel);
            Controls.Add(technicalConditionLabel);
            Controls.Add(colorLabel);
            Controls.Add(gearboxTypeLabel);
            Controls.Add(engineTypeLabel);
            Controls.Add(topSpeedLabel);
            Controls.Add(engineCapacityLabel);
            Controls.Add(birthYearLabel);
            Controls.Add(brandNameLabel);
            Name = "UpsertCar";
            Text = "UpsertCar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox technicalConditionComboBox;
        private ComboBox colorComboBox;
        private ComboBox gearboxTypeComboBox;
        private ComboBox engineTypeComboBox;
        private Button upsertButton;
        private TextBox priceTextBox;
        private TextBox topSpeedTextBox;
        private TextBox engineCapacityTextBox;
        private TextBox birthYearTextBox;
        private TextBox brandNameTextBox;
        private Label priceLabel;
        private Label technicalConditionLabel;
        private Label colorLabel;
        private Label gearboxTypeLabel;
        private Label engineTypeLabel;
        private Label topSpeedLabel;
        private Label engineCapacityLabel;
        private Label birthYearLabel;
        private Label brandNameLabel;
    }
}