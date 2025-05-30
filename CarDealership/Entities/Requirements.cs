using CarDealership.Enums;

namespace CarDealership.Entities
{
    public class Requirements
    {
        public string BrandName { get; set; }
        public int BirthYear { get; set; }
        public TechnicalCharacteristics TechnicalCharacteristics { get; set; }
        public TechnicalCondition TechnicalCondition { get; set; }
    }
}