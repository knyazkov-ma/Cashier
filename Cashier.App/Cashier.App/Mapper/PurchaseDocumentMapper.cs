using Cashier.App.ViewModel;
using Cashier.DataService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier.App.Mapper
{
    public static class PurchaseDocumentMapper
    {
        public static PurchaseDocumentViewModel ToModel(this PurchaseDocumentDTO dto)
        {
            var model = new PurchaseDocumentViewModel();
            model.Id = dto.Id;
            model.DocumentNumber = dto.Number;
            model.DocumentState = dto.State;

            return model;
        }
    }
}
