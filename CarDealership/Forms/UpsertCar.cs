using System.Text;
using CarDealership.Entities;
using CarDealership.Enums;
using CarDealership.Interfaces;
using CarDealership.Utils;

namespace CarDealership.Forms
{
    public partial class UpsertCar : Form
    {
        private readonly ICarRepository _carRepository = RepositoryFactoryUtil.CarRepository;
        private readonly Car _car;

        public UpsertCar(Car car = null)
        {
            _car = car;
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            if (_car == null)
            {
                upsertButton.Text = "Додати";
                Text = "Додати автомобіль ";

                return;
            }

            upsertButton.Text = "Редагувати";
            Text = "Редагувати автомобіль ";

            brandNameTextBox.Text = _car.BrandName;
            birthYearTextBox.Text = _car.BirthYear.ToString();
            engineCapacityTextBox.Text = _car.TechnicalCharacteristics.EngineCapacity.ToString();
            topSpeedTextBox.Text = _car.TechnicalCharacteristics.TopSpeed.ToString();
            engineTypeComboBox.SelectedIndex = (int)_car.TechnicalFeatures.EngineType;
            gearboxTypeComboBox.SelectedIndex = (int)_car.TechnicalFeatures.GearboxType;
            colorComboBox.SelectedItem = _car.TechnicalFeatures.Color;
            technicalConditionComboBox.SelectedIndex = (int)_car.TechnicalCondition;
            priceTextBox.Text = _car.Price.ToString();
        }

        private void upsertButton_Click(object sender, EventArgs e)
        {
            var errors = GetValidationErrors();

            if (errors.Length != 0)
            {
                MessageUtil.ShowError(errors.ToString());
                return;
            }

            var car = new Car
            {
                Id = _car?.Id ?? _carRepository.NextId,
                BrandName = brandNameTextBox.Text,
                BirthYear = int.Parse(birthYearTextBox.Text),
                TechnicalCharacteristics = new TechnicalCharacteristics
                {
                    EngineCapacity = float.Parse(engineCapacityTextBox.Text),
                    TopSpeed = int.Parse(topSpeedTextBox.Text)
                },
                TechnicalFeatures = new TechnicalFeatures
                {
                    EngineType = (EngineType)engineTypeComboBox.SelectedIndex,
                    GearboxType = (GearboxType)gearboxTypeComboBox.SelectedIndex,
                    Color = colorComboBox.SelectedItem.ToString()
                },
                TechnicalCondition = (TechnicalCondition)technicalConditionComboBox.SelectedIndex,
                Price = decimal.Parse(priceTextBox.Text),
                IsFavourite = false
            };

            if (_car == null)
            {
                _carRepository.Add(car);
            }
            else
            {
                _carRepository.Update(car);
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

            AppendIfInvalid(brandNameTextBox.IsValidBrandName(out var invalidBrandNameMessage), invalidBrandNameMessage);
            AppendIfInvalid(birthYearTextBox.IsValidBirthYear(out var invalidBirthYearMessage), invalidBirthYearMessage);
            AppendIfInvalid(engineCapacityTextBox.IsValidEngineCapacity(out var invalidEngineCapacityMessage), invalidEngineCapacityMessage);
            AppendIfInvalid(topSpeedTextBox.IsValidTopSpeed(out var invalidTopSpeedMessage), invalidTopSpeedMessage);
            AppendIfInvalid(engineTypeComboBox.IsValidEngineType(out var invalidEngineTypeMessage), invalidEngineTypeMessage);
            AppendIfInvalid(gearboxTypeComboBox.IsValidGearboxType(out var invalidGearboxTypeMessage), invalidGearboxTypeMessage);
            AppendIfInvalid(colorComboBox.IsValidColor(out var invalidColorMessage), invalidColorMessage);
            AppendIfInvalid(technicalConditionComboBox.IsValidTechnicalCondition(out var invalidTechnicalConditionMessage), invalidTechnicalConditionMessage);
            AppendIfInvalid(priceTextBox.IsValidPrice(out var invalidPriceMessage), invalidPriceMessage);

            return errors;
        }
    }
}
