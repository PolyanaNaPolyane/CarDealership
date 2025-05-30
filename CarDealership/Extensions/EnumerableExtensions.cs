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
    }
}
