using Cashier.App.ViewModel;
using Cashier.DataService.DTO;

namespace Cashier.App.Mapper
{
    public static class SaleDocumentItemMapper
    {
        public static SaleDocumentItemViewModel ToModel(this SaleDocumentItemDTO dto)
        {
            if (dto == null)
                return null;

            var model = new SaleDocumentItemViewModel();
            model.Id = dto.Id;
            model.Count = dto.Count;
            model.Price = dto.Price;
            model.Name = dto.Name;
            model.Code = dto.Code;

            return model;
        }
    }
}
