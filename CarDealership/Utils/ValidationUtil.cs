namespace CarDealership.Utils
{
    public static class ValidationUtil
    {
        public static bool IsValidBrandName(TextBox textBox)
        {
            return !string.IsNullOrWhiteSpace(textBox.Text);
        }

        public static bool IsValidBirthYear(TextBox textBox)
        {
            if (!int.TryParse(textBox.Text, out var birthYear))
            {
                return false;
            }

            return birthYear >= 1950 && birthYear <= DateTime.Now.Year;
        }
    }
}
