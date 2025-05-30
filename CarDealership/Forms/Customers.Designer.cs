namespace CarDealership.Forms
{
    partial class Customers
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
            addButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            customersGridView = new DataGridView();
            carsByCustomerGridView = new DataGridView();
            createOrderButton = new Button();
            filterCarsByCustomerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)customersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carsByCustomerGridView).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(711, 12);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 31);
            addButton.TabIndex = 0;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(711, 49);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 31);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(710, 86);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 31);
            editButton.TabIndex = 2;
            editButton.Text = "Редагувати";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // customersGridView
            // 
            customersGridView.AllowUserToAddRows = false;
            customersGridView.AllowUserToDeleteRows = false;
            customersGridView.AllowUserToResizeRows = false;
            customersGridView.BackgroundColor = SystemColors.Control;
            customersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            customersGridView.Location = new Point(12, 12);
            customersGridView.MultiSelect = false;
            customersGridView.Name = "customersGridView";
            customersGridView.RowHeadersWidth = 51;
            customersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customersGridView.ShowEditingIcon = false;
            customersGridView.Size = new Size(675, 175);
            customersGridView.TabIndex = 13;
            // 
            // carsByCustomerGridView
            // 
            carsByCustomerGridView.AllowUserToAddRows = false;
            carsByCustomerGridView.AllowUserToDeleteRows = false;
            carsByCustomerGridView.AllowUserToResizeRows = false;
            carsByCustomerGridView.BackgroundColor = SystemColors.Control;
            carsByCustomerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carsByCustomerGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            carsByCustomerGridView.Location = new Point(12, 220);
            carsByCustomerGridView.MultiSelect = false;
            carsByCustomerGridView.Name = "carsByCustomerGridView";
            carsByCustomerGridView.RowHeadersWidth = 51;
            carsByCustomerGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            carsByCustomerGridView.ShowEditingIcon = false;
            carsByCustomerGridView.Size = new Size(675, 175);
            carsByCustomerGridView.TabIndex = 14;
            // 
            // createOrderButton
            // 
            createOrderButton.Location = new Point(711, 257);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Size = new Size(150, 31);
            createOrderButton.TabIndex = 16;
            createOrderButton.Text = "Створити заявку";
            createOrderButton.UseVisualStyleBackColor = true;
            createOrderButton.Click += createOrderButton_Click;
            // 
            // filterCarsByCustomerButton
            // 
            filterCarsByCustomerButton.Location = new Point(710, 220);
            filterCarsByCustomerButton.Name = "filterCarsByCustomerButton";
            filterCarsByCustomerButton.Size = new Size(150, 31);
            filterCarsByCustomerButton.TabIndex = 17;
            filterCarsByCustomerButton.Text = "Підібрати авто";
            filterCarsByCustomerButton.UseVisualStyleBackColor = true;
            filterCarsByCustomerButton.Click += filterCarsByCustomerButton_Click;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 407);
            Controls.Add(filterCarsByCustomerButton);
            Controls.Add(createOrderButton);
            Controls.Add(carsByCustomerGridView);
            Controls.Add(customersGridView);
            Controls.Add(editButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Name = "Customers";
            Text = "Покупці";
            ((System.ComponentModel.ISupportInitialize)customersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)carsByCustomerGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private Button deleteButton;
        private Button editButton;
        private DataGridView customersGridView;
        private DataGridView carsByCustomerGridView;
        private Button createOrderButton;
        private Button filterCarsByCustomerButton;
    }
}