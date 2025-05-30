using CarDealership.Entities;
using CarDealership.Enums;
using CarDealership.Extensions;
using CarDealership.Repositories;
using CarDealership.Utils;

namespace CarDealership.Forms
{
    public partial class Cars : Form
    {
        private readonly CarRepository _carRepository = new CarRepository();

        public Cars()
        {
            InitializeComponent();
            InitializeTables();
            technicalConditionComboBox.SelectedIndex = 0;
        }

        public string CarBrand => brandNameTextBox.Text;
        public string CarYear => birthYearTextBox.Text;
        public TechnicalCondition? CarCondition => technicalConditionComboBox.SelectedIndex <= 0 ? null : (TechnicalCondition)(technicalConditionComboBox.SelectedIndex - 1);
        public IEnumerable<Car> FilteredCars => _carRepository.Get(CarBrand, CarYear, CarCondition);
        public IEnumerable<Car> FavouriteCars => _carRepository.Get().Where(car => car.IsFavourite);
        public Car SelectedCar => FilteredCars.ToList()[filteredCarsGridView.SelectedRows[0].Index];

        private void InitializeTables()
        {
            filteredCarsGridView.DataSource = FilteredCars.ToTableData();
            favouriteCarsGridView.DataSource = FavouriteCars.ToTableData();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (!ValidationUtil.IsValidBirthYear(birthYearTextBox))
            {
                MessageUtil.ShowError($"Рік повинен бути числом від 1950 до {DateTime.Now.Year}");
                return;
            }

            filteredCarsGridView.DataSource = FilteredCars.ToTableData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!filteredCarsGridView.IsSelectedRow())
            {
                MessageUtil.ShowError("Оберіть автомобіль для видалення");
                return;
            }

            _carRepository.Delete(SelectedCar);
            filteredCarsGridView.DataSource = FilteredCars.ToTableData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addCarForm = new UpsertCar();
            addCarForm.ShowDialog(this);
            filteredCarsGridView.DataSource = FilteredCars.ToTableData();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (!filteredCarsGridView.IsSelectedRow())
            {
                MessageUtil.ShowError("Оберіть автомобіль для редагування");
                return;
            }

            var editCarForm = new UpsertCar(SelectedCar);
            editCarForm.ShowDialog(this);
            filteredCarsGridView.DataSource = FilteredCars.ToTableData();
        }

        private void toggleCarFavourite_Click(object sender, EventArgs e)
        {
            if (!filteredCarsGridView.IsSelectedRow())
            {
                MessageUtil.ShowError("Оберіть автомобіль для додавання/видалення обраного");
                return;
            }

            var carToToggleFavourite = SelectedCar;
            carToToggleFavourite.IsFavourite = !carToToggleFavourite.IsFavourite;
            _carRepository.Update(carToToggleFavourite);
            favouriteCarsGridView.DataSource = FavouriteCars.ToTableData();
        }

        private void customersMenuItem_Click(object sender, EventArgs e)
        {
            this.Show<Customers>();
        }

        private void ordersMenuItem_Click(object sender, EventArgs e)
        {
            this.Show<Orders>();
        }

        private void carsComparisonMenuItem_Click(object sender, EventArgs e)
        {
            this.Show<CarsComparison>();
        }
    }
}
