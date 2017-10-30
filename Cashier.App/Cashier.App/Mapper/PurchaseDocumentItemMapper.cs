using Cashier.App.ViewModel;
using Cashier.DataService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier.App.Mapper
{
    public static class PurchaseDocumentItemMapper
    {
        public static PurchaseDocumentItemViewModel ToModel(this PurchaseDocumentItemDTO dto)
        {
            var model = new PurchaseDocumentItemViewModel();
            model.Id = dto.Id;
            model.Count = dto.Count;
            model.Price = dto.Price;
            model.Name = dto.Name;
            model.Code = dto.Code;

            return model;
        }
    }
}
