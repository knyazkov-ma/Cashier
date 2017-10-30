namespace Cashier.DataService.DTO
{
    public class PurchaseDocumentItemDTO
    {
        public long Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public int Count { get; set; }

        public decimal Price { get; set; }
               

    }
}
