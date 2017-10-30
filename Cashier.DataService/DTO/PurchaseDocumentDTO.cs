using System.Collections.Generic;

namespace Cashier.DataService.DTO
{
    public class PurchaseDocumentDTO 
    {
        public long Id { get; set; }

        public string State { get; set; }

        public string Number { get; set; }
         
        public IEnumerable<PurchaseDocumentItemDTO> Items { get; set; }
    }
}
