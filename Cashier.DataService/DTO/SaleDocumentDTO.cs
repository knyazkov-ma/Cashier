using Cashier.Entity;
using System.Collections.Generic;

namespace Cashier.DataService.DTO
{
    public class SaleDocumentDTO 
    {
        public long Id { get; set; }

        public SaleDocumentState State { get; set; }

        public IEnumerable<SaleDocumentItemDTO> Items { get; set; }
    }
}
