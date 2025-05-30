using CarDealership.Entities;
using CarDealership.Interfaces;

namespace CarDealership.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository() : base(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Data\customers.json"))
        {
        }
    }
}
