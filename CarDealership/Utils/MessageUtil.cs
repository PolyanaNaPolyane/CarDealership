namespace CarDealership.Utils
{
    public static class MessageUtil
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
