using CarDealership.Entities;
using CarDealership.Extensions;
using CarDealership.Interfaces;
using CarDealership.Repositories;

namespace CarDealership.Forms
{
    public partial class Customers : Form
    {
        private readonly ICustomerRepository _customerRepository = new CustomerRepository();
        private readonly ICarRepository _carRepository = new CarRepository();
        private readonly IOrderRepository _orderRepository = new OrderRepository();

        public Customers()
        {
            InitializeComponent();
            InitializeTables();
        }

        public Customer SelectedCustomer => _customerRepository.Entities.ToList()[customersGridView.SelectedRows[0].Index];
        public IEnumerable<Car> CarsByCustomer(Customer customer) => _carRepository.GetByCustomerRequirements(customer);

        private void InitializeTables()
        {
            customersGridView.DataSource = _customerRepository.Entities.ToTableData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new UpsertCustomer();
            addCustomerForm.ShowDialog(this);
            customersGridView.DataSource = _customerRepository.Entities.ToTableData();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var editCustomerForm = new UpsertCustomer(SelectedCustomer);
            editCustomerForm.ShowDialog(this);
            customersGridView.DataSource = _customerRepository.Entities.ToTableData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _customerRepository.Delete(SelectedCustomer);
            customersGridView.DataSource = _customerRepository.Entities.ToTableData();
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            var selectedCustomer = SelectedCustomer;
            var selectedCarIndex = carsByCustomerGridView.SelectedRows[0].Index;
            var selectedCar = CarsByCustomer(selectedCustomer).ToList()[selectedCarIndex];

            _orderRepository.Add(new Order
            {
                Id = _orderRepository.NextId,
                CustomerName = selectedCustomer.Name,
                ContactDetails = new ContactDetails
                {
                    Address = selectedCustomer.ContactDetails.Address,
                    PhoneNumber = selectedCustomer.ContactDetails.PhoneNumber,
                },
                BrandName = selectedCar.BrandName,
                BirthYear = selectedCar.BirthYear,
                TechnicalCharacteristics = new TechnicalCharacteristics
                {
                    EngineCapacity = selectedCar.TechnicalCharacteristics.EngineCapacity,
                    TopSpeed = selectedCar.TechnicalCharacteristics.TopSpeed
                },
                TechnicalFeatures = new TechnicalFeatures
                {
                    Color = selectedCar.TechnicalFeatures.Color,
                    EngineType = selectedCar.TechnicalFeatures.EngineType,
                    GearboxType = selectedCar.TechnicalFeatures.GearboxType
                },
                TechnicalCondition = selectedCar.TechnicalCondition,
                Price = selectedCar.Price,
                IsApproved = false
            });
        }

        private void filterCarsByCustomerButton_Click(object sender, EventArgs e)
        {
            carsByCustomerGridView.DataSource = CarsByCustomer(SelectedCustomer).ToTableData();
        }
    }
}
