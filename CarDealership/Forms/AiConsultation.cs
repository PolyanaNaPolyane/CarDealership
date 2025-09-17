using CarDealership.Utils;

namespace CarDealership.Forms
{
    public partial class AiConsultation : Form
    {
        public AiConsultation()
        {
            InitializeComponent();
        }

        private void askButton_Click(object sender, EventArgs e)
        {
            using var geminiClient = new GeminiClient();
            answerRichTextBox.Text = geminiClient.SendRequest(questionRichTextBox.Text);
        }
    }
}
