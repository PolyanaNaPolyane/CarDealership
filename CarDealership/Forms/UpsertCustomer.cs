using CarDealership.Entities;
using CarDealership.Enums;
using CarDealership.Interfaces;
using CarDealership.Repositories;

namespace CarDealership.Forms
{
    public partial class UpsertCustomer : Form
    {
        private readonly ICustomerRepository _customerRepository = new CustomerRepository();
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
    }
}
