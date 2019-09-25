using System.ComponentModel.DataAnnotations;

namespace CatalogParser.Enums
{
    public enum StoreType
    {
        [Display(Name = "Не выбрано")]
        NotSelected,
        [Display(Name = "Магазин")]
        Market,
        [Display(Name = "Склад")]
        Storage
    }
}