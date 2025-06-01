namespace CarDealership.Forms
{
    partial class Orders
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
            ordersGridView = new DataGridView();
            approveButton = new Button();
            deleteButton = new Button();
            rejectButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ordersGridView).BeginInit();
            SuspendLayout();
            // 
            // ordersGridView
            // 
            ordersGridView.AllowUserToAddRows = false;
            ordersGridView.AllowUserToDeleteRows = false;
            ordersGridView.AllowUserToResizeRows = false;
            ordersGridView.BackgroundColor = SystemColors.Control;
            ordersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            ordersGridView.Location = new Point(12, 12);
            ordersGridView.MultiSelect = false;
            ordersGridView.Name = "ordersGridView";
            ordersGridView.RowHeadersWidth = 51;
            ordersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersGridView.ShowEditingIcon = false;
            ordersGridView.Size = new Size(675, 175);
            ordersGridView.TabIndex = 14;
            // 
            // approveButton
            // 
            approveButton.Location = new Point(704, 12);
            approveButton.Name = "approveButton";
            approveButton.Size = new Size(150, 31);
            approveButton.TabIndex = 15;
            approveButton.Text = "Підтвердити";
            approveButton.UseVisualStyleBackColor = true;
            approveButton.Click += approveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(704, 86);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 31);
            deleteButton.TabIndex = 16;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // rejectButton
            // 
            rejectButton.Location = new Point(704, 49);
            rejectButton.Name = "rejectButton";
            rejectButton.Size = new Size(150, 31);
            rejectButton.TabIndex = 17;
            rejectButton.Text = "Відхилити";
            rejectButton.UseVisualStyleBackColor = true;
            rejectButton.Click += rejectButton_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 199);
            Controls.Add(rejectButton);
            Controls.Add(deleteButton);
            Controls.Add(approveButton);
            Controls.Add(ordersGridView);
            Name = "Orders";
            Text = "Заявки";
            ((System.ComponentModel.ISupportInitialize)ordersGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ordersGridView;
        private Button approveButton;
        private Button deleteButton;
        private Button rejectButton;
    }
}