using CarDealership.Entities;
using CarDealership.Enums;

namespace CarDealership.Interfaces
{
    public interface ICarRepository : IBaseRepository<Car>
    {
        public IEnumerable<Car> GetByCustomerRequirements(Customer customer);
        public IEnumerable<Car> Get(
            string brand = null,
            string year = null,
            TechnicalCondition? technicalCondition = null);
    }
}
