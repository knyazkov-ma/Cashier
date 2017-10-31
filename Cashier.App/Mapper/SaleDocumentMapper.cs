using Cashier.App.ViewModel;
using Cashier.DataService.DTO;

namespace Cashier.App.Mapper
{
    public static class SaleDocumentMapper
    {
        public static SaleDocumentViewModel ToModel(this SaleDocumentDTO dto)
        {
            var model = new SaleDocumentViewModel();
            model.Id = dto.Id;
            model.DocumentState = dto.State;

            return model;
        }
    }
}
