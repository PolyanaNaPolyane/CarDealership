using CarDealership.Entities;
using CarDealership.Interfaces;

namespace CarDealership.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository() : base(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Data\customers.json"))
        {
        }

        public bool Contains(Customer customer)
        {
            return Entities
                .Where(c =>
                    c.Id != customer.Id
                    && string.Equals(c.Name, customer.Name, StringComparison.OrdinalIgnoreCase)
                    && c.ContactDetails.PhoneNumber == customer.ContactDetails.PhoneNumber
                    && string.Equals(c.ContactDetails.Address, customer.ContactDetails.Address, StringComparison.OrdinalIgnoreCase))
                .Any();
        }
    }
}
