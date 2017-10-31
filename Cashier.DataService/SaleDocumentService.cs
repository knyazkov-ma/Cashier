using Cashier.Data.Repository;
using Cashier.DataService.DTO;
using Cashier.DataService.Helpers;
using Cashier.DataService.Interface;
using Cashier.Entity;
using System;
using System.Collections.Generic;

namespace Cashier.DataService
{
    public class SaleDocumentService: ISaleDocumentService
    {
        private readonly IBaseRepository<Catalog> catalogRepository;
        private readonly IBaseRepository<SaleDocument> saleDocumentRepository;
        private readonly IBaseRepository<Stock> stockRepository;
        private readonly IRepository repository;

        public SaleDocumentService(IBaseRepository<Catalog> catalogRepository,
            IBaseRepository<SaleDocument> saleDocumentRepository,
            IBaseRepository<Stock> stockRepository,
            IRepository repository)
        {
            this.catalogRepository = catalogRepository;
            this.saleDocumentRepository = saleDocumentRepository;
            this.stockRepository = stockRepository;
            this.repository = repository;
        }

        public SaleDocumentDTO GetNew()
        {
            SaleDocument document = new SaleDocument() { State = SaleDocumentState.Open };
            saleDocumentRepository.Save(document);
            repository.SaveChanges();

            return new SaleDocumentDTO()
            {
                Id = document.Id,
                State = document.State.GetDisplayName(),
                Items = new List<SaleDocumentItemDTO>()
            };
        }

        public SaleDocumentItemDTO GetDocumentItemByCode(string code)
        {
            Catalog catalog = catalogRepository.Get(t => t.Code.ToUpper() == code.ToUpper());

            return new SaleDocumentItemDTO()
            {
                 Code = catalog.Code,
                 Count = 1,
                 Name = catalog.Name,
                 Price = catalog.Price
            };
        }
    }
}
