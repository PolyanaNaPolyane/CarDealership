using CarDealership.Interfaces;
using CarDealership.Repositories;

namespace CarDealership.Utils
{
    public static class RepositoryFactoryUtil
    {
        public static ICarRepository CarRepository = new CarRepository();
        public static ICustomerRepository CustomerRepository = new CustomerRepository();
        public static IOrderRepository OrderRepository = new OrderRepository();
    }
}
