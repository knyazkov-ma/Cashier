using Cashier.DataService.DTO;
using Cashier.DataService.Interface;
using System;
using System.Collections.Generic;

namespace Cashier.DataService
{
    public class SaleDocumentService: ISaleDocumentService
    {
        private string[] names = new string[] { "Мороженное детское", "Пельмени", "Печенье" };

        public SaleDocumentDTO GetNew()
        {
            return new SaleDocumentDTO()
            {
                Id = 100123,
                Number = "100123",
                State = "Открыт",
                Items = new List<SaleDocumentItemDTO>()
            };
        }

        public SaleDocumentItemDTO GetDocumentItemByCode(string code)
        {
            Random rnd = new Random();
            return new SaleDocumentItemDTO()
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
