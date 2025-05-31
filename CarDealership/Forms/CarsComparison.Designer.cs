namespace CarDealership.Forms
{
    partial class CarsComparison
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
            carsGridView = new DataGridView();
            compareButton = new Button();
            carsToCompareGridView = new DataGridView();
            comparisonGridView = new DataGridView();
            addToComparisonButton = new Button();
            deleteFromComparisonButton = new Button();
            carsGroupBox = new GroupBox();
            carsToCompareGroupBox = new GroupBox();
            comparisonResultGroupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)carsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carsToCompareGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comparisonGridView).BeginInit();
            carsGroupBox.SuspendLayout();
            carsToCompareGroupBox.SuspendLayout();
            comparisonResultGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // carsGridView
            // 
            carsGridView.AllowUserToAddRows = false;
            carsGridView.AllowUserToDeleteRows = false;
            carsGridView.AllowUserToResizeRows = false;
            carsGridView.BackgroundColor = SystemColors.Control;
            carsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carsGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            carsGridView.Location = new Point(17, 26);
            carsGridView.Name = "carsGridView";
            carsGridView.RowHeadersWidth = 51;
            carsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            carsGridView.ShowEditingIcon = false;
            carsGridView.Size = new Size(675, 175);
            carsGridView.TabIndex = 13;
            // 
            // compareButton
            // 
            compareButton.Location = new Point(715, 63);
            compareButton.Name = "compareButton";
            compareButton.Size = new Size(175, 31);
            compareButton.TabIndex = 15;
            compareButton.Text = "Порівняти";
            compareButton.UseVisualStyleBackColor = true;
            compareButton.Click += compareButton_Click;
            // 
            // carsToCompareGridView
            // 
            carsToCompareGridView.AllowUserToAddRows = false;
            carsToCompareGridView.AllowUserToDeleteRows = false;
            carsToCompareGridView.AllowUserToResizeRows = false;
            carsToCompareGridView.BackgroundColor = SystemColors.Control;
            carsToCompareGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carsToCompareGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            carsToCompareGridView.Location = new Point(17, 26);
            carsToCompareGridView.Name = "carsToCompareGridView";
            carsToCompareGridView.RowHeadersWidth = 51;
            carsToCompareGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            carsToCompareGridView.ShowEditingIcon = false;
            carsToCompareGridView.Size = new Size(675, 175);
            carsToCompareGridView.TabIndex = 16;
            // 
            // comparisonGridView
            // 
            comparisonGridView.AllowUserToAddRows = false;
            comparisonGridView.AllowUserToDeleteRows = false;
            comparisonGridView.AllowUserToResizeRows = false;
            comparisonGridView.BackgroundColor = SystemColors.Control;
            comparisonGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            comparisonGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            comparisonGridView.Location = new Point(17, 26);
            comparisonGridView.Name = "comparisonGridView";
            comparisonGridView.RowHeadersWidth = 51;
            comparisonGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            comparisonGridView.ShowEditingIcon = false;
            comparisonGridView.Size = new Size(675, 84);
            comparisonGridView.TabIndex = 17;
            // 
            // addToComparisonButton
            // 
            addToComparisonButton.Location = new Point(715, 26);
            addToComparisonButton.Name = "addToComparisonButton";
            addToComparisonButton.Size = new Size(175, 31);
            addToComparisonButton.TabIndex = 18;
            addToComparisonButton.Text = "Додати до порівняння";
            addToComparisonButton.UseVisualStyleBackColor = true;
            addToComparisonButton.Click += addToComparisonButton_Click;
            // 
            // deleteFromComparisonButton
            // 
            deleteFromComparisonButton.Location = new Point(715, 26);
            deleteFromComparisonButton.Name = "deleteFromComparisonButton";
            deleteFromComparisonButton.Size = new Size(175, 31);
            deleteFromComparisonButton.TabIndex = 19;
            deleteFromComparisonButton.Text = "Видалити";
            deleteFromComparisonButton.UseVisualStyleBackColor = true;
            deleteFromComparisonButton.Click += deleteFromComparisonButton_Click;
            // 
            // carsGroupBox
            // 
            carsGroupBox.Controls.Add(carsGridView);
            carsGroupBox.Controls.Add(addToComparisonButton);
            carsGroupBox.Location = new Point(12, 12);
            carsGroupBox.Name = "carsGroupBox";
            carsGroupBox.Size = new Size(904, 216);
            carsGroupBox.TabIndex = 20;
            carsGroupBox.TabStop = false;
            carsGroupBox.Text = "Автомобілі";
            // 
            // carsToCompareGroupBox
            // 
            carsToCompareGroupBox.Controls.Add(carsToCompareGridView);
            carsToCompareGroupBox.Controls.Add(deleteFromComparisonButton);
            carsToCompareGroupBox.Controls.Add(compareButton);
            carsToCompareGroupBox.Location = new Point(12, 234);
            carsToCompareGroupBox.Name = "carsToCompareGroupBox";
            carsToCompareGroupBox.Size = new Size(904, 216);
            carsToCompareGroupBox.TabIndex = 21;
            carsToCompareGroupBox.TabStop = false;
            carsToCompareGroupBox.Text = "Автомобілі для порівняння";
            // 
            // comparisonResultGroupBox
            // 
            comparisonResultGroupBox.Controls.Add(comparisonGridView);
            comparisonResultGroupBox.Location = new Point(12, 456);
            comparisonResultGroupBox.Name = "comparisonResultGroupBox";
            comparisonResultGroupBox.Size = new Size(904, 125);
            comparisonResultGroupBox.TabIndex = 22;
            comparisonResultGroupBox.TabStop = false;
            comparisonResultGroupBox.Text = "Результат порівняння";
            // 
            // CarsComparison
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 593);
            Controls.Add(comparisonResultGroupBox);
            Controls.Add(carsToCompareGroupBox);
            Controls.Add(carsGroupBox);
            Name = "CarsComparison";
            Text = "Порівняння машин";
            ((System.ComponentModel.ISupportInitialize)carsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)carsToCompareGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)comparisonGridView).EndInit();
            carsGroupBox.ResumeLayout(false);
            carsToCompareGroupBox.ResumeLayout(false);
            comparisonResultGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView carsGridView;
        private Button compareButton;
        private DataGridView carsToCompareGridView;
        private DataGridView comparisonGridView;
        private Button addToComparisonButton;
        private Button deleteFromComparisonButton;
        private GroupBox carsGroupBox;
        private GroupBox carsToCompareGroupBox;
        private GroupBox comparisonResultGroupBox;
    }
}