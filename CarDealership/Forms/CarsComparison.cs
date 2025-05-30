using CarDealership.Entities;
using CarDealership.Extensions;
using CarDealership.Interfaces;
using CarDealership.Repositories;

namespace CarDealership.Forms
{
    public partial class CarsComparison : Form
    {
        private readonly ICarRepository _carRepository = new CarRepository();
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
            comparisonGridView.DataSource = _carsToCompare.ToComparisonTableData();
        }

        private void addToComparisonButton_Click(object sender, EventArgs e)
        {
            _carsToCompare.Add(CarToAddForComparison);
            carsToCompareGridView.DataSource = _carsToCompare.ToTableData();
        }

        private void deleteFromComparisonButton_Click(object sender, EventArgs e)
        {
            _carsToCompare.Remove(CarToDeleteFromComparison);
            carsToCompareGridView.DataSource = _carsToCompare.ToTableData();
        }
    }
}
