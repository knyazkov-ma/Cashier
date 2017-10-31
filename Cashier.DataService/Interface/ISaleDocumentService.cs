using Cashier.DataService.DTO;

namespace Cashier.DataService.Interface
{
    public interface ISaleDocumentService
    {
        SaleDocumentDTO GetNew();
        SaleDocumentItemDTO GetDocumentItemByCode(string code);
    }
}
