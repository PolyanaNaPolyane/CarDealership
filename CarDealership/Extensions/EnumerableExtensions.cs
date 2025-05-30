using CarDealership.Entities;

namespace CarDealership.Extensions
{
    public static class EnumerableExtensions
    {
        public static object ToTableData(this IEnumerable<Car> cars)
        {
            return cars.Select(car => new
            {
                Марка = car.BrandName,
                Рік = car.BirthYear,
                Обʼєм = car.TechnicalCharacteristics.EngineCapacity,
                Швидкість = car.TechnicalCharacteristics.TopSpeed,
                ТипДвигуна = car.TechnicalFeatures.EngineType.GetDisplayName(),
                Коробка = car.TechnicalFeatures.GearboxType.GetDisplayName(),
                Колір = car.TechnicalFeatures.Color,
                Стан = car.TechnicalCondition.GetDisplayName(),
                Ціна = car.Price
            }).ToList();
        }

        public static object ToTableData(this IEnumerable<Customer> customers)
        {
            return customers.Select(customer => new
            {
                Імʼя = customer.Name,
                Телефон = customer.ContactDetails.PhoneNumber,
                Адреса = customer.ContactDetails.Address,
                БажанаМарка = customer.Requirements.BrandName,
                БажанийРік = customer.Requirements.BirthYear,
                БажанийОбʼєм = customer.Requirements.TechnicalCharacteristics.EngineCapacity,
                БажанаШвидкість = customer.Requirements.TechnicalCharacteristics.TopSpeed,
                БажанийСтан = customer.Requirements.TechnicalCondition.GetDisplayName(),
                Бюджет = customer.Budget
            }).ToList();
        }

        public static object ToTableData(this IEnumerable<Order> orders)
        {
            return orders.Select(order => new
            {
                Імʼя = order.CustomerName,
                Телефон = order.ContactDetails.PhoneNumber,
                Адреса = order.ContactDetails.Address,
                Марка = order.BrandName,
                Рік = order.BirthYear,
                Обʼєм = order.TechnicalCharacteristics.EngineCapacity,
                Швидкість = order.TechnicalCharacteristics.TopSpeed,
                ТипДвигуна = order.TechnicalFeatures.EngineType.GetDisplayName(),
                Коробка = order.TechnicalFeatures.GearboxType.GetDisplayName(),
                Колір = order.TechnicalFeatures.Color,
                Стан = order.TechnicalCondition.GetDisplayName(),
                Ціна = order.Price,
                Підтверджено = order.IsApproved ? "Так" : "Ні"
            }).ToList();
        }
    }
}
