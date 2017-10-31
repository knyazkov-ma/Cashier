namespace Cashier.Entity
{
    /// <summary>
    /// Товарная позиция в документе продажи
    /// </summary>
    public class SaleDocumentItem : BaseEntity
    {
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
    }
}
