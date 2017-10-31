using System.Collections.Generic;

namespace Cashier.DataService.DTO
{
    public class SaleDocumentDTO 
    {
        public long Id { get; set; }

        public string State { get; set; }

        public string Number { get; set; }
         
        public IEnumerable<SaleDocumentItemDTO> Items { get; set; }
    }
}
