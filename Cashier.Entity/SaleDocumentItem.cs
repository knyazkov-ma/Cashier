namespace Cashier.Entity
{
    /// <summary>
    /// Товарная позиция в документе продажи
    /// </summary>
    public class SaleDocumentItem : BaseEntity
    {
        /// <summary>
        /// Код
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Count { get; set; }
        
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Документ продажи
        /// </summary>
        public SaleDocument Document { get; set; }
    }
}
