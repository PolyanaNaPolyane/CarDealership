using System.Text;
using CarDealership.Entities;
using CarDealership.Enums;
using CarDealership.Interfaces;
using CarDealership.Utils;

namespace CarDealership.Forms
{
    public partial class UpsertCustomer : Form
    {
        private readonly ICustomerRepository _customerRepository = RepositoryFactoryUtil.CustomerRepository;
        private readonly Customer _customer;

        public UpsertCustomer(Customer customer = null)
        {
            _customer = customer;
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            if (_customer == null)
            {
                Text = "Додати користувача";
                upsertButton.Text = "Додати";

                return;
            }

            Text = "Редагувати користувача";
            upsertButton.Text = "Редагувати";

            nameTextBox.Text = _customer.Name;
            phoneNumberTextBox.Text = _customer.ContactDetails.PhoneNumber;
            addressTextBox.Text = _customer.ContactDetails.Address;
            brandNameTextBox.Text = _customer.Requirements.BrandName;
            birthYearTextBox.Text = _customer.Requirements.BirthYear.ToString();
            engineCapacityTextBox.Text = _customer.Requirements.TechnicalCharacteristics.EngineCapacity.ToString();
            topSpeedTextBox.Text = _customer.Requirements.TechnicalCharacteristics.TopSpeed.ToString();
            technicalConditionComboBox.SelectedIndex = (int)_customer.Requirements.TechnicalCondition;
            budgetTextBox.Text = _customer.Budget.ToString();
        }

        private void upsertButton_Click(object sender, EventArgs e)
        {
            var errors = GetValidationErrors();

            if (errors.Length != 0)
            {
                MessageUtil.ShowError(errors.ToString());
                return;
            }

            var customer = new Customer
            {
                Id = _customer?.Id ?? _customerRepository.NextId,
                Name = nameTextBox.Text,
                ContactDetails = new ContactDetails
                {
                    PhoneNumber = phoneNumberTextBox.Text,
                    Address = addressTextBox.Text
                },
                Requirements = new Requirements
                {
                    BrandName = brandNameTextBox.Text,
                    BirthYear = int.Parse(birthYearTextBox.Text),
                    TechnicalCharacteristics = new TechnicalCharacteristics
                    {
                        EngineCapacity = float.Parse(engineCapacityTextBox.Text),
                        TopSpeed = int.Parse(topSpeedTextBox.Text)
                    },
                    TechnicalCondition = (TechnicalCondition)technicalConditionComboBox.SelectedIndex
                },
                Budget = decimal.Parse(budgetTextBox.Text)
            };

            if (_customer == null)
            {
                _customerRepository.Add(customer);
            }
            else
            {
                _customerRepository.Update(customer);
            }

            Close();
        }

        private StringBuilder GetValidationErrors()
        {
            var errors = new StringBuilder();
            int errorNumber = 1;

            void AppendIfInvalid(bool isValid, string message)
            {
                if (isValid)
                {
                    return;
                }

                errors.AppendLine($"{errorNumber}) {message}");
                errorNumber++;
            }

            AppendIfInvalid(nameTextBox.IsValidUserName(out var invalidNameMessage), invalidNameMessage);
            AppendIfInvalid(phoneNumberTextBox.IsValidPhoneNumber(out var invalidPhoneNumberMessage), invalidPhoneNumberMessage);
            AppendIfInvalid(addressTextBox.IsValidAddress(out var invalidAddressMessage), invalidAddressMessage);
            AppendIfInvalid(brandNameTextBox.IsValidBrandName(out var invalidBrandNameMessage), invalidBrandNameMessage);
            AppendIfInvalid(birthYearTextBox.IsValidBirthYear(out var invalidBirthYearMessage), invalidBirthYearMessage);
            AppendIfInvalid(engineCapacityTextBox.IsValidEngineCapacity(out var invalidEngineCapacityMessage), invalidEngineCapacityMessage);
            AppendIfInvalid(topSpeedTextBox.IsValidTopSpeed(out var invalidTopSpeedMessage), invalidTopSpeedMessage);
            AppendIfInvalid(technicalConditionComboBox.IsValidTechnicalCondition(out var invalidTechnicalConditionMessage), invalidTechnicalConditionMessage);
            AppendIfInvalid(budgetTextBox.IsValidBudget(out var invalidBudgetMessage), invalidBudgetMessage);

            return errors;
        }
    }
}
