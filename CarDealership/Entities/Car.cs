using CarDealership.Enums;

namespace CarDealership.Entities
{
    public class Car : Entity
    {
        public string BrandName { get; set; }
        public int BirthYear { get; set; }
        public TechnicalCharacteristics TechnicalCharacteristics { get; set; }
        public TechnicalFeatures TechnicalFeatures { get; set; }
        public TechnicalCondition TechnicalCondition { get; set; }
        public decimal Price { get; set; }
        public bool IsFavourite { get; set; }
    }
}