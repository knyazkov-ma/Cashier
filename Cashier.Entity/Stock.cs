namespace Cashier.Entity
{
    /// <summary>
    /// Остатки на складе
    /// </summary>
    public class Stock : BaseEntity
    {
        /// <summary>
        /// Остатки
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Товар
        /// </summary>
        public Catalog Catalog { get; set; }
    }
}
