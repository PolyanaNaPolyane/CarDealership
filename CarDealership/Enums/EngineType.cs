using System.ComponentModel.DataAnnotations;

namespace CarDealership.Enums
{
    public enum EngineType
    {
        [Display(Name = "Бензиновий")]
        Petrol,
        [Display(Name = "Гібридний")]
        Hybrid,
        [Display(Name = "Дизельний")]
        Diesel
    }
}