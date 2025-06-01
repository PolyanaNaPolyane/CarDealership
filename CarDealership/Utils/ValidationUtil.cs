using System.Text.RegularExpressions;
using CarDealership.Enums;

namespace CarDealership.Utils
{
    public static class ValidationUtil
    {
        public static bool IsValidBrandName(this TextBox textBox, out string message)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                message = "Марка повинна бути заповнена";
                return false;
            }

            message = null;
            return true;
        }

        public static bool IsValidBirthYear(this TextBox textBox, out string message)
        {
            if (!int.TryParse(textBox.Text, out var birthYear) || birthYear < 1950 || birthYear > DateTime.Now.Year)
            {
                message = $"Рік повинен бути числом від 1950 до {DateTime.Now.Year}";
                return false;
            }

            message = null;
            return true;
        }

        public static bool IsValidEngineCapacity(this TextBox textBox, out string message)
        {
            if (!float.TryParse(textBox.Text, out var engineCapacity) || engineCapacity < 0.5 || engineCapacity > 10)
            {
                message = "Об'єм двигуна повинен бути від 0.5 до 10";
                return false;
            }

            message = null;
            return true;
        }

        public static bool IsValidTopSpeed(this TextBox textBox, out string message)
        {
            if (!int.TryParse(textBox.Text, out var topSpeed) || topSpeed <= 0 || topSpeed > 400)
            {
                message = "Швидкість повинна від 0 до 400";
                return false;
            }

            message = null;
            return true;
        }

        public static bool IsValidColor(this ComboBox comboBox, out string message)
        {
            if (comboBox.SelectedIndex < 0)
            {
                message = "Оберіть колір з випадаючого списка";
                return false;
            }

            message = null;
            return true;
        }

        public static bool IsValidEngineType(this ComboBox comboBox, out string message)
        {
            if (!Enum.IsDefined(typeof(EngineType), comboBox.SelectedIndex))
            {
                message = "Оберіть тип двигуна з випадаючого списка";
                return false;
            }

            message = null;
            return true;
        }

        public static bool IsValidGearboxType(this ComboBox comboBox, out string message)
        {
            if (!Enum.IsDefined(typeof(GearboxType), comboBox.SelectedIndex))
            {
                message = "Оберіть тип коробки з випадаючого списка";
                return false;
            }

            message = null;
            return true;
        }

        public static bool IsValidTechnicalCondition(this ComboBox comboBox, out string message)
        {
            if (!Enum.IsDefined(typeof(TechnicalCondition), comboBox.SelectedIndex))
            {
                message = "Оберіть технічний стан з випадаючого списка";
                return false;
            }
            
            message = null;
            return true;
        }

        public static bool IsValidPrice(this TextBox textBox, out string message)
        {
            if (!decimal.TryParse(textBox.Text, out var price) || price <= 0)
            {
                message = "Ціна повинна бути більшою 0";
                return false;
            }

            message = null;
            return true;
        }

        public static bool IsValidUserName(this TextBox textBox, out string message)
        {
            string pattern = @"^[A-Za-zА-Яа-яІіЇїЄєҐґ]+$";

            if (!Regex.IsMatch(textBox.Text, pattern))
            {
                message = "Ім’я не повинно бути пустим або містити цифри, спеціальні символи або пробіли";
                return false;
            }

            message = null;
            return true;
        }

        public static bool IsValidPhoneNumber(this TextBox textBox, out string message)
        {
            string pattern = @"^\+380\d{9}$";

            if (!Regex.IsMatch(textBox.Text, pattern))
            {
                message = "Номер телефону повинен починатися з +380, а далі мають слідувати 9 цифр";
                return false;
            }

            message = null;
            return true;
        }

        public static bool IsValidAddress(this TextBox textBox, out string message)
        {
            string pattern = @"^[A-Za-zА-Яа-яІіЇїЄєҐґ0-9\s\.,\/\-]+$";

            if (string.IsNullOrWhiteSpace(textBox.Text) || !Regex.IsMatch(textBox.Text, pattern))
            {
                message = "Адреса не повинна бути порожньою і не складається з некоректних символів";
                return false;
            }

            message = null;
            return true;
        }

        public static bool IsValidBudget(this TextBox textBox, out string message)
        {
            if (!decimal.TryParse(textBox.Text, out var budget) || budget <= 0)
            {
                message = "Бюджет повинен бути більшим 0";
                return false;
            }

            message = null;
            return true;
        }
    }
}
