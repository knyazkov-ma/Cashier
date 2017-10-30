using Cashier.DataService.DTO;
using Cashier.DataService.Interface;
using System;
using System.Collections.Generic;

namespace Cashier.DataService
{
    public class PurchaseDocumentService: IPurchaseDocumentService
    {
        private string[] names = new string[] { "Мороженное детское", "Пельмени", "Печенье" };

        public PurchaseDocumentDTO GetNew()
        {
            return new PurchaseDocumentDTO()
            {
                Id = 100123,
                Number = "100123",
                State = "Открыт",
                Items = new List<PurchaseDocumentItemDTO>()
            };
        }

        public PurchaseDocumentItemDTO GetDocumentItemByCode(string code)
        {
            Random rnd = new Random();
            return new PurchaseDocumentItemDTO()
            {
                Id = rnd.Next(10000, 55555),
                Code = code,
                Name = names[rnd.Next(0, 2)],
                Price = rnd.Next(100, 1000) * 0.51m,
                Count = 1
            };
        }
    }
}
