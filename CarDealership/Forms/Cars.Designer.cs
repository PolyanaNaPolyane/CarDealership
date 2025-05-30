namespace CarDealership.Forms
{
    partial class Cars
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
            покупціToolStripMenuItem = new ToolStripMenuItem();
            menu = new MenuStrip();
            customersMenuItem = new ToolStripMenuItem();
            ordersMenuItem = new ToolStripMenuItem();
            carsComparisonMenuItem = new ToolStripMenuItem();
            brandNameTextBox = new TextBox();
            birthYearTextBox = new TextBox();
            filterButton = new Button();
            technicalConditionComboBox = new ComboBox();
            brandNameLabel = new Label();
            birthYearLable = new Label();
            technicalConditionLabel = new Label();
            filteredCarsGridView = new DataGridView();
            Brand = new DataGridViewTextBoxColumn();
            BirthYear = new DataGridViewTextBoxColumn();
            EngineCapacity = new DataGridViewTextBoxColumn();
            TopSpeed = new DataGridViewTextBoxColumn();
            EngineType = new DataGridViewTextBoxColumn();
            GearboxType = new DataGridViewTextBoxColumn();
            Color = new DataGridViewTextBoxColumn();
            TechnicalCondition = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            deleteButton = new Button();
            addButton = new Button();
            editButton = new Button();
            addFavouriteButton = new Button();
            deleteFavouriteButton = new Button();
            favouriteCarsGridView = new DataGridView();
            carsGroupBox = new GroupBox();
            favouriteGroupBox = new GroupBox();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filteredCarsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)favouriteCarsGridView).BeginInit();
            carsGroupBox.SuspendLayout();
            favouriteGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // покупціToolStripMenuItem
            // 
            покупціToolStripMenuItem.Name = "покупціToolStripMenuItem";
            покупціToolStripMenuItem.Size = new Size(224, 26);
            покупціToolStripMenuItem.Text = "Покупці";
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { customersMenuItem, ordersMenuItem, carsComparisonMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(907, 28);
            menu.TabIndex = 3;
            menu.Text = "menuStrip1";
            // 
            // customersMenuItem
            // 
            customersMenuItem.Name = "customersMenuItem";
            customersMenuItem.Size = new Size(79, 24);
            customersMenuItem.Text = "Покупці";
            customersMenuItem.Click += customersMenuItem_Click;
            // 
            // ordersMenuItem
            // 
            ordersMenuItem.Name = "ordersMenuItem";
            ordersMenuItem.Size = new Size(71, 24);
            ordersMenuItem.Text = "Заявки";
            // 
            // carsComparisonMenuItem
            // 
            carsComparisonMenuItem.Name = "carsComparisonMenuItem";
            carsComparisonMenuItem.Size = new Size(107, 24);
            carsComparisonMenuItem.Text = "Порівняння";
            // 
            // brandNameTextBox
            // 
            brandNameTextBox.Location = new Point(75, 46);
            brandNameTextBox.Name = "brandNameTextBox";
            brandNameTextBox.Size = new Size(125, 27);
            brandNameTextBox.TabIndex = 4;
            // 
            // birthYearTextBox
            // 
            birthYearTextBox.Location = new Point(318, 49);
            birthYearTextBox.Name = "birthYearTextBox";
            birthYearTextBox.Size = new Size(125, 27);
            birthYearTextBox.TabIndex = 5;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(708, 46);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(150, 31);
            filterButton.TabIndex = 7;
            filterButton.Text = "Відфільтрувати";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // technicalConditionComboBox
            // 
            technicalConditionComboBox.FormattingEnabled = true;
            technicalConditionComboBox.Items.AddRange(new object[] { "Усі", "Нові", "Використані", "Після ДТП" });
            technicalConditionComboBox.Location = new Point(536, 49);
            technicalConditionComboBox.Name = "technicalConditionComboBox";
            technicalConditionComboBox.Size = new Size(151, 28);
            technicalConditionComboBox.TabIndex = 8;
            // 
            // brandNameLabel
            // 
            brandNameLabel.AutoSize = true;
            brandNameLabel.Location = new Point(12, 49);
            brandNameLabel.Name = "brandNameLabel";
            brandNameLabel.Size = new Size(57, 20);
            brandNameLabel.TabIndex = 9;
            brandNameLabel.Text = "Марка:";
            // 
            // birthYearLable
            // 
            birthYearLable.AutoSize = true;
            birthYearLable.Location = new Point(223, 49);
            birthYearLable.Name = "birthYearLable";
            birthYearLable.Size = new Size(89, 20);
            birthYearLable.TabIndex = 10;
            birthYearLable.Text = "Рік випуску:";
            // 
            // technicalConditionLabel
            // 
            technicalConditionLabel.AutoSize = true;
            technicalConditionLabel.Location = new Point(458, 52);
            technicalConditionLabel.Name = "technicalConditionLabel";
            technicalConditionLabel.Size = new Size(72, 20);
            technicalConditionLabel.TabIndex = 11;
            technicalConditionLabel.Text = "Тех. стан:";
            // 
            // filteredCarsGridView
            // 
            filteredCarsGridView.AllowUserToAddRows = false;
            filteredCarsGridView.AllowUserToDeleteRows = false;
            filteredCarsGridView.AllowUserToResizeRows = false;
            filteredCarsGridView.BackgroundColor = SystemColors.Control;
            filteredCarsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            filteredCarsGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            filteredCarsGridView.Location = new Point(20, 26);
            filteredCarsGridView.MultiSelect = false;
            filteredCarsGridView.Name = "filteredCarsGridView";
            filteredCarsGridView.RowHeadersWidth = 51;
            filteredCarsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            filteredCarsGridView.ShowEditingIcon = false;
            filteredCarsGridView.Size = new Size(675, 175);
            filteredCarsGridView.TabIndex = 12;
            // 
            // Brand
            // 
            Brand.HeaderText = "Марка";
            Brand.MinimumWidth = 6;
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
            Brand.Width = 125;
            // 
            // BirthYear
            // 
            BirthYear.HeaderText = "Рік випуску";
            BirthYear.MinimumWidth = 6;
            BirthYear.Name = "BirthYear";
            BirthYear.ReadOnly = true;
            BirthYear.Width = 125;
            // 
            // EngineCapacity
            // 
            EngineCapacity.HeaderText = "Об'єм двигуна";
            EngineCapacity.MinimumWidth = 6;
            EngineCapacity.Name = "EngineCapacity";
            EngineCapacity.ReadOnly = true;
            EngineCapacity.Width = 125;
            // 
            // TopSpeed
            // 
            TopSpeed.HeaderText = "Максимальна швидкість";
            TopSpeed.MinimumWidth = 6;
            TopSpeed.Name = "TopSpeed";
            TopSpeed.ReadOnly = true;
            TopSpeed.Width = 125;
            // 
            // EngineType
            // 
            EngineType.HeaderText = "Двигун";
            EngineType.MinimumWidth = 6;
            EngineType.Name = "EngineType";
            EngineType.ReadOnly = true;
            EngineType.Width = 125;
            // 
            // GearboxType
            // 
            GearboxType.HeaderText = "Коробка передач";
            GearboxType.MinimumWidth = 6;
            GearboxType.Name = "GearboxType";
            GearboxType.ReadOnly = true;
            GearboxType.Width = 125;
            // 
            // Color
            // 
            Color.HeaderText = "Колір";
            Color.MinimumWidth = 6;
            Color.Name = "Color";
            Color.ReadOnly = true;
            Color.Width = 125;
            // 
            // TechnicalCondition
            // 
            TechnicalCondition.HeaderText = "Тех. стан";
            TechnicalCondition.MinimumWidth = 6;
            TechnicalCondition.Name = "TechnicalCondition";
            TechnicalCondition.ReadOnly = true;
            TechnicalCondition.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Ціна";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 125;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(713, 63);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 31);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(713, 26);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 31);
            addButton.TabIndex = 14;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(713, 101);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 31);
            editButton.TabIndex = 15;
            editButton.Text = "Редагувати";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // addFavouriteButton
            // 
            addFavouriteButton.Location = new Point(713, 138);
            addFavouriteButton.Name = "addFavouriteButton";
            addFavouriteButton.Size = new Size(150, 31);
            addFavouriteButton.TabIndex = 16;
            addFavouriteButton.Text = "Додати в обране";
            addFavouriteButton.UseVisualStyleBackColor = true;
            addFavouriteButton.Click += toggleCarFavourite_Click;
            // 
            // deleteFavouriteButton
            // 
            deleteFavouriteButton.Location = new Point(713, 26);
            deleteFavouriteButton.Name = "deleteFavouriteButton";
            deleteFavouriteButton.Size = new Size(150, 31);
            deleteFavouriteButton.TabIndex = 17;
            deleteFavouriteButton.Text = "Видалити обране";
            deleteFavouriteButton.UseVisualStyleBackColor = true;
            deleteFavouriteButton.Click += toggleCarFavourite_Click;
            // 
            // favouriteCarsGridView
            // 
            favouriteCarsGridView.AllowUserToAddRows = false;
            favouriteCarsGridView.AllowUserToDeleteRows = false;
            favouriteCarsGridView.AllowUserToResizeRows = false;
            favouriteCarsGridView.BackgroundColor = SystemColors.Control;
            favouriteCarsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            favouriteCarsGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            favouriteCarsGridView.Location = new Point(20, 26);
            favouriteCarsGridView.MultiSelect = false;
            favouriteCarsGridView.Name = "favouriteCarsGridView";
            favouriteCarsGridView.RowHeadersWidth = 51;
            favouriteCarsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            favouriteCarsGridView.ShowEditingIcon = false;
            favouriteCarsGridView.Size = new Size(675, 175);
            favouriteCarsGridView.TabIndex = 18;
            // 
            // carsGroupBox
            // 
            carsGroupBox.Controls.Add(filteredCarsGridView);
            carsGroupBox.Controls.Add(addButton);
            carsGroupBox.Controls.Add(deleteButton);
            carsGroupBox.Controls.Add(addFavouriteButton);
            carsGroupBox.Controls.Add(editButton);
            carsGroupBox.Location = new Point(12, 83);
            carsGroupBox.Name = "carsGroupBox";
            carsGroupBox.Size = new Size(880, 217);
            carsGroupBox.TabIndex = 19;
            carsGroupBox.TabStop = false;
            carsGroupBox.Text = "Автомобілі";
            // 
            // favouriteGroupBox
            // 
            favouriteGroupBox.Controls.Add(favouriteCarsGridView);
            favouriteGroupBox.Controls.Add(deleteFavouriteButton);
            favouriteGroupBox.Location = new Point(12, 306);
            favouriteGroupBox.Name = "favouriteGroupBox";
            favouriteGroupBox.Size = new Size(880, 217);
            favouriteGroupBox.TabIndex = 20;
            favouriteGroupBox.TabStop = false;
            favouriteGroupBox.Text = "Обране";
            // 
            // Cars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 534);
            Controls.Add(favouriteGroupBox);
            Controls.Add(carsGroupBox);
            Controls.Add(technicalConditionLabel);
            Controls.Add(birthYearLable);
            Controls.Add(brandNameLabel);
            Controls.Add(technicalConditionComboBox);
            Controls.Add(filterButton);
            Controls.Add(birthYearTextBox);
            Controls.Add(brandNameTextBox);
            Controls.Add(menu);
            Name = "Cars";
            Text = "Автосалон";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)filteredCarsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)favouriteCarsGridView).EndInit();
            carsGroupBox.ResumeLayout(false);
            favouriteGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem покупціToolStripMenuItem;
        private ToolStripMenuItem customersMenuItem;
        private ToolStripMenuItem менюToolStripMenuItem1;
        private MenuStrip menu;
        private ToolStripMenuItem ordersMenuItem;
        private ToolStripMenuItem carsComparisonMenuItem;
        private TextBox brandNameTextBox;
        private TextBox birthYearTextBox;
        private Button filterButton;
        private ComboBox technicalConditionComboBox;
        private Label brandNameLabel;
        private Label birthYearLable;
        private Label technicalConditionLabel;
        private DataGridView filteredCarsGridView;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn BirthYear;
        private DataGridViewTextBoxColumn EngineCapacity;
        private DataGridViewTextBoxColumn TopSpeed;
        private DataGridViewTextBoxColumn EngineType;
        private DataGridViewTextBoxColumn GearboxType;
        private DataGridViewTextBoxColumn Color;
        private DataGridViewTextBoxColumn TechnicalCondition;
        private DataGridViewTextBoxColumn Price;
        private Button deleteButton;
        private Button addButton;
        private Button editButton;
        private Button addFavouriteButton;
        private Button deleteFavouriteButton;
        private DataGridView favouriteCarsGridView;
        private GroupBox carsGroupBox;
        private GroupBox favouriteGroupBox;
    }
}
