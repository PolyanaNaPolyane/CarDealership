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
    }
}
