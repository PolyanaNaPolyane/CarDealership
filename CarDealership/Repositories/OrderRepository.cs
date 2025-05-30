using CarDealership.Entities;
using CarDealership.Interfaces;

namespace CarDealership.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository() : base(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Data\orders.json"))
        {
        }
    }
}
