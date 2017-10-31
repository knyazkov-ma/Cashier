namespace Cashier.Entity
{
    /// <summary>
    /// Товар
    /// </summary>
    public class Catalog: BaseEntity
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        public string Code { get; set; }
    }
}
