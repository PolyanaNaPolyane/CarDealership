using CarDealership.Enums;

namespace CarDealership.Entities
{
    public class Order : Entity
    {
        public string CustomerName { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public string BrandName { get; set; }
        public int BirthYear { get; set; }
        public TechnicalCharacteristics TechnicalCharacteristics { get; set; }
        public TechnicalFeatures TechnicalFeatures { get; set; }
        public TechnicalCondition TechnicalCondition { get; set; }
        public decimal Price { get; set; }
        public bool IsApproved { get; set; }
    }
}
