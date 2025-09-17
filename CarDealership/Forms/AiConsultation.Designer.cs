namespace CarDealership.Forms
{
    partial class AiConsultation
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
            askButton = new Button();
            textBox1 = new TextBox();
            aiConsultationGroupBox = new GroupBox();
            answerRichTextBox = new RichTextBox();
            questionRichTextBox = new RichTextBox();
            aiConsultationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // askButton
            // 
            askButton.Location = new Point(760, 26);
            askButton.Name = "askButton";
            askButton.Size = new Size(106, 215);
            askButton.TabIndex = 0;
            askButton.Text = "Запитати";
            askButton.UseVisualStyleBackColor = true;
            askButton.Click += askButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 27);
            textBox1.TabIndex = 1;
            // 
            // aiConsultationGroupBox
            // 
            aiConsultationGroupBox.Controls.Add(answerRichTextBox);
            aiConsultationGroupBox.Controls.Add(questionRichTextBox);
            aiConsultationGroupBox.Controls.Add(textBox1);
            aiConsultationGroupBox.Controls.Add(askButton);
            aiConsultationGroupBox.Location = new Point(12, 12);
            aiConsultationGroupBox.Name = "aiConsultationGroupBox";
            aiConsultationGroupBox.Size = new Size(883, 510);
            aiConsultationGroupBox.TabIndex = 3;
            aiConsultationGroupBox.TabStop = false;
            aiConsultationGroupBox.Text = "Консультаційний пункт";
            // 
            // answerRichTextBox
            // 
            answerRichTextBox.Location = new Point(12, 259);
            answerRichTextBox.Name = "answerRichTextBox";
            answerRichTextBox.Size = new Size(731, 215);
            answerRichTextBox.TabIndex = 3;
            answerRichTextBox.Text = "";
            // 
            // questionRichTextBox
            // 
            questionRichTextBox.Location = new Point(12, 26);
            questionRichTextBox.Name = "questionRichTextBox";
            questionRichTextBox.Size = new Size(731, 215);
            questionRichTextBox.TabIndex = 2;
            questionRichTextBox.Text = "";
            // 
            // AiConsultation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 534);
            Controls.Add(aiConsultationGroupBox);
            MaximizeBox = false;
            Name = "AiConsultation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Консультація";
            aiConsultationGroupBox.ResumeLayout(false);
            aiConsultationGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button askButton;
        private TextBox textBox1;
        private GroupBox aiConsultationGroupBox;
        private RichTextBox questionRichTextBox;
        private RichTextBox answerRichTextBox;
    }
}