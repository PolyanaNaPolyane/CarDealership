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
            ((System.ComponentModel.ISupportInitialize)carsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carsToCompareGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comparisonGridView).BeginInit();
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
            carsGridView.Location = new Point(12, 12);
            carsGridView.Name = "carsGridView";
            carsGridView.RowHeadersWidth = 51;
            carsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            carsGridView.ShowEditingIcon = false;
            carsGridView.Size = new Size(675, 175);
            carsGridView.TabIndex = 13;
            // 
            // compareButton
            // 
            compareButton.Location = new Point(708, 255);
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
            carsToCompareGridView.Location = new Point(12, 210);
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
            comparisonGridView.Location = new Point(12, 410);
            comparisonGridView.Name = "comparisonGridView";
            comparisonGridView.RowHeadersWidth = 51;
            comparisonGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            comparisonGridView.ShowEditingIcon = false;
            comparisonGridView.Size = new Size(675, 175);
            comparisonGridView.TabIndex = 17;
            // 
            // addToComparisonButton
            // 
            addToComparisonButton.Location = new Point(708, 12);
            addToComparisonButton.Name = "addToComparisonButton";
            addToComparisonButton.Size = new Size(175, 31);
            addToComparisonButton.TabIndex = 18;
            addToComparisonButton.Text = "Додати до порівняння";
            addToComparisonButton.UseVisualStyleBackColor = true;
            addToComparisonButton.Click += addToComparisonButton_Click;
            // 
            // deleteFromComparisonButton
            // 
            deleteFromComparisonButton.Location = new Point(708, 210);
            deleteFromComparisonButton.Name = "deleteFromComparisonButton";
            deleteFromComparisonButton.Size = new Size(175, 31);
            deleteFromComparisonButton.TabIndex = 19;
            deleteFromComparisonButton.Text = "Видалити";
            deleteFromComparisonButton.UseVisualStyleBackColor = true;
            deleteFromComparisonButton.Click += deleteFromComparisonButton_Click;
            // 
            // CarsComparison
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 602);
            Controls.Add(deleteFromComparisonButton);
            Controls.Add(addToComparisonButton);
            Controls.Add(comparisonGridView);
            Controls.Add(carsToCompareGridView);
            Controls.Add(compareButton);
            Controls.Add(carsGridView);
            Name = "CarsComparison";
            Text = "Порівняння машин";
            ((System.ComponentModel.ISupportInitialize)carsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)carsToCompareGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)comparisonGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView carsGridView;
        private Button compareButton;
        private DataGridView carsToCompareGridView;
        private DataGridView comparisonGridView;
        private Button addToComparisonButton;
        private Button deleteFromComparisonButton;
    }
}