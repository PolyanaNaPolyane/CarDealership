using System.Text.RegularExpressions;
using CarDealership.Enums;

namespace CarDealership.Utils
{
    public static class ValidationUtil
    {
        public static bool IsValidBrandName(this TextBox textBox)
        {
            return !string.IsNullOrWhiteSpace(textBox.Text);
        }

        public static bool IsValidBirthYear(this TextBox textBox)
        {
            if (!int.TryParse(textBox.Text, out var birthYear))
            {
                return false;
            }

            return birthYear >= 1950 && birthYear <= DateTime.Now.Year;
        }

        public static bool IsValidEngineCapacity(this TextBox textBox)
        {
            if (!float.TryParse(textBox.Text, out var engineCapacity))
            {
                return false;
            }

            return engineCapacity >= 0.5 && engineCapacity <= 10;
        }

        public static bool IsValidTopSpeed(this TextBox textBox)
        {
            if (!int.TryParse(textBox.Text, out var topSpeed))
            {
                return false;
            }

            return topSpeed > 0 && topSpeed <= 400;
        }

        public static bool IsValidEngineType(this ComboBox comboBox)
        {
            return Enum.IsDefined(typeof(EngineType), comboBox.SelectedIndex);
        }

        public static bool IsValidUserName(this TextBox textBox)
        {
            string pattern = @"^[A-Za-zА-Яа-яІіЇїЄєҐґ]+$";

            return Regex.IsMatch(textBox.Text, pattern);
        }

        public static bool IsValidPhoneNumber(this TextBox textBox)
        {
            string pattern = @"^\+380\d{9}$";

            return Regex.IsMatch(textBox.Text, pattern);
        }

        public static bool IsValidAddress(this TextBox textBox)
        {
            string pattern = @"^[A-Za-zА-Яа-яІіЇїЄєҐґ0-9\s\.,\/\-]+$";

            return !string.IsNullOrWhiteSpace(textBox.Text) && Regex.IsMatch(textBox.Text, pattern);
        }
    }
}
