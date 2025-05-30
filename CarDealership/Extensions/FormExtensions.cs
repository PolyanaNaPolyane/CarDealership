namespace CarDealership.Extensions
{
    public static class FormExtensions
    {
        public static void Show<T>(this Form form) where T : Form, new()
        {
            var formToShow = new T();
            formToShow.FormClosed += (s, e) => form.Show();
            formToShow.Show();
            form.Hide();
        }

        public static void ShowError(this Form form, string message)
        {
            MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
