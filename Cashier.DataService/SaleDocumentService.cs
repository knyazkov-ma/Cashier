using Cashier.Data.Repository;
using Cashier.DataService.DTO;
using Cashier.DataService.Interface;
using Cashier.Entity;
using System.Linq;
using System.Collections.Generic;
using Cashier.DataService.Aspects;

namespace Cashier.DataService
{
    [Transaction]
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

        public SaleDocumentDTO Create()
        {
            SaleDocument document = new SaleDocument() { State = SaleDocumentState.Open };
            saleDocumentRepository.Save(document);
            repository.SaveChanges();

            return new SaleDocumentDTO()
            {
                Id = document.Id,
                State = document.State,
                Items = new List<SaleDocumentItemDTO>()
            };
        }

        public SaleDocumentDTO Get(long id)
        {
            SaleDocument document =  saleDocumentRepository.Get(id);
            
            return new SaleDocumentDTO()
            {
                Id = document.Id,
                State = document.State,
                Items = document.Items.Select(t => new SaleDocumentItemDTO()
                {
                     Id = t.Id,
                     Code = t.Code,
                     Count = t.Count,
                     Name = t.Name,
                     Price = t.Price
                })
            };
        }

        public void Delete(long id)
        {
            saleDocumentRepository.Delete(id);
            repository.SaveChanges();
        }

        public SaleDocumentItemDTO GetDocumentItemByCode(string code)
        {
            Catalog catalog = catalogRepository.Get(t => t.Code.ToUpper() == code.ToUpper());
            if (catalog == null)
                return null;

            return new SaleDocumentItemDTO()
            {
                 Code = catalog.Code,
                 Count = 1,
                 Name = catalog.Name,
                 Price = catalog.Price
            };
        }

        [Transaction]
        public void Save(SaleDocumentDTO dto)
        {
            SaleDocument document = saleDocumentRepository.Get(dto.Id);
            document.State = SaleDocumentState.Complete;

            foreach (SaleDocumentItemDTO item in dto.Items)
            {
                document.Items.Add(new SaleDocumentItem()
                {
                    Amount = item.Price * item.Count,
                    Count = item.Count,
                    Name = item.Name,
                    Price = item.Price,
                    Code = item.Code,
                    Document = document
                });

                Stock stock = stockRepository.Get(t => t.Catalog.Code == item.Code);
                stock.Count -= item.Count;
                stockRepository.Save(stock);
            }
                        
            saleDocumentRepository.Save(document);
            
            repository.SaveChanges();
        }
    }
}
