using CarDealership.Entities;
using CarDealership.Extensions;
using CarDealership.Interfaces;
using CarDealership.Utils;

namespace CarDealership.Forms
{
    public partial class CarsComparison : Form
    {
        private readonly ICarRepository _carRepository = RepositoryFactoryUtil.CarRepository;
        private readonly List<Car> _carsToCompare = new List<Car>();

        public CarsComparison()
        {
            InitializeComponent();
            InitializeTables();
        }

        public Car CarToAddForComparison => _carRepository.Get().ToList()[carsGridView.SelectedRows[0].Index];
        public Car CarToDeleteFromComparison => _carsToCompare[carsToCompareGridView.SelectedRows[0].Index];

        private void InitializeTables()
        {
            carsGridView.DataSource = _carRepository.Get().ToTableData();
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            if (_carsToCompare.Count == 0)
            {
                MessageUtil.ShowError("Додайте автомобілі для порівняння");
                return;
            }

            comparisonGridView.DataSource = _carsToCompare.ToComparisonTableData();
        }

        private void addToComparisonButton_Click(object sender, EventArgs e)
        {
            if (!carsGridView.IsSelectedRow())
            {
                MessageUtil.ShowError("Оберіть автомобіль для порівняння");
                return;
            }

            var carToAddForComparison = CarToAddForComparison;

            if (_carsToCompare.Contains(carToAddForComparison))
            {
                MessageUtil.ShowError("Автомобіль вже доданий до порівняння");
                return;
            }

            _carsToCompare.Add(carToAddForComparison);
            carsToCompareGridView.DataSource = _carsToCompare.ToTableData();
        }

        private void deleteFromComparisonButton_Click(object sender, EventArgs e)
        {
            if (!carsGridView.IsSelectedRow())
            {
                MessageUtil.ShowError("Оберіть автомобіль, який потрібно видалити з порівняння");
                return;
            }

            _carsToCompare.Remove(CarToDeleteFromComparison);
            carsToCompareGridView.DataSource = _carsToCompare.ToTableData();
        }
    }
}
