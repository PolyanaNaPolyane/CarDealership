using CarDealership.Entities;

namespace CarDealership.Interfaces
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        public bool Contains(Customer customer);
    }
}
