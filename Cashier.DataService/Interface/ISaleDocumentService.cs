using Cashier.DataService.DTO;

namespace Cashier.DataService.Interface
{
    public interface ISaleDocumentService
    {
        SaleDocumentDTO Create();
        SaleDocumentDTO Get(long id);
        SaleDocumentItemDTO GetDocumentItemByCode(string code);

        void Save(SaleDocumentDTO dto);

        void Delete(long id);
    }
}
