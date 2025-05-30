using System.ComponentModel.DataAnnotations;

namespace CarDealership.Enums
{
    public enum TechnicalCondition
    {
        [Display(Name = "Нова")]
        New,
        [Display(Name = "Б/У")]
        Used,
        [Display(Name = "Після ДТП")]
        AfterAccident
    }
}