using System.Collections.Generic;

namespace Cashier.Entity
{
    /// <summary>
    /// Документ продажи
    /// </summary>
    public class SaleDocument : BaseEntity
    {
        /// <summary>
        /// Состояние
        /// </summary>
        public SaleDocumentState State { get; set; }

        
        /// <summary>
        /// Товарные позиции
        /// </summary>
        public IEnumerable<SaleDocumentItem> Items { get; set; }
    }
}
