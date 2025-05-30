using CarDealership.Entities;
using CarDealership.Enums;
using CarDealership.Interfaces;

namespace CarDealership.Repositories
{
    public class CarRepository : BaseRepository<Car>, ICarRepository
    {
        public CarRepository() : base(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Data\cars.json"))
        {
        }

        public IEnumerable<Car> GetByCustomerRequirements(Customer customer)
        {
            IEnumerable<Car> filteredCars = Get(
                customer.Requirements.BrandName,
                customer.Requirements.BirthYear.ToString(),
                customer.Requirements.TechnicalCondition);

            filteredCars = filteredCars.Where(car =>
                car.TechnicalCharacteristics.EngineCapacity >= customer.Requirements.TechnicalCharacteristics.EngineCapacity
                && car.TechnicalCharacteristics.TopSpeed >= customer.Requirements.TechnicalCharacteristics.TopSpeed
                && car.Price <= customer.Budget);

            return filteredCars;
        }

        public IEnumerable<Car> Get(
            string brand = null,
            string year = null,
            TechnicalCondition? technicalCondition = null)
        {
            IEnumerable<Car> filteredCars = _entities;

            if (!string.IsNullOrWhiteSpace(brand))
                filteredCars = filteredCars.Where(car => car.BrandName.ToLower().Contains(brand.ToLower()));

            if (!string.IsNullOrWhiteSpace(year) && int.TryParse(year, out int parsedYear))
                filteredCars = filteredCars.Where(car => car.BirthYear == parsedYear);

            if (technicalCondition != null)
                filteredCars = filteredCars.Where(car => car.TechnicalCondition == technicalCondition);

            return filteredCars;
        }
    }
}
