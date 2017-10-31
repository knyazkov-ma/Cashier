using Cashier.App.ViewModel;
using Cashier.DataService.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Cashier.App.Mapper
{
    public static class SaleDocumentMapper
    {
        public static SaleDocumentViewModel ToModel(this SaleDocumentDTO dto)
        {
            var model = new SaleDocumentViewModel();
            model.Id = dto.Id;
            model.DocumentState = dto.State;

            model.Items = new BindingList<SaleDocumentItemViewModel>();
            foreach(var item in dto.Items)
                model.Items.Add(item.ToModel());
            if(model.Items.Any())
                model.CurrentItem = model.Items[0];

            return model;
        }

        public static SaleDocumentDTO ToDTO(this SaleDocumentViewModel model)
        {
            var dto = new SaleDocumentDTO();

            dto.Id = model.Id;

            dto.Items = model.Items.Select(t => new SaleDocumentItemDTO()
            {
                 Code = t.Code,
                 Count = t.Count,
                 Id = t.Id,
                 Name = t.Name,
                 Price = t.Price
            });

            return dto;
        }
    }
}
