using System.ComponentModel.DataAnnotations;

namespace CarDealership.Enums
{
    public enum GearboxType
    {
        [Display(Name = "Ручна")]
        Manual,
        [Display(Name = "Автоматична")]
        Automatic
    }
}