using Cashier.DataService.DTO;

namespace Cashier.DataService.Interface
{
    public interface IPurchaseDocumentService
    {
        PurchaseDocumentDTO GetNew();
        PurchaseDocumentItemDTO GetDocumentItemByCode(string code);
    }
}
