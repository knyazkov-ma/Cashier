using System.ComponentModel.DataAnnotations;

namespace Cashier.Entity
{
    /// <summary>
    /// Состояние документа продажи
    /// </summary>
    public enum SaleDocumentState
    {
        [Display(Name = "Открытый")]
        Open,

        [Display(Name = "Закрыт")]
        Complete
    }
}
