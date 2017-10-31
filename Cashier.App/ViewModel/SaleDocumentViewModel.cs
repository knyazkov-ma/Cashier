using Cashier.Entity;
using System.ComponentModel;
using System.Linq;
using Cashier.DataService.Helpers;

namespace Cashier.App.ViewModel
{
    public class SaleDocumentViewModel : BaseViewModel
    {

        public SaleDocumentViewModel()
        {
            Items = new BindingList<SaleDocumentItemViewModel>();
            CurrentItem = new SaleDocumentItemViewModel();
            documentState =  SaleDocumentState.Open;
        }

        public long Id { get; set; }

        private SaleDocumentState documentState;
        public SaleDocumentState DocumentState
        {
            get
            {
                return this.documentState;
            }

            set
            {
                if (value != this.documentState)
                {
                    this.documentState = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public string DocumentStateName
        {
            get { return documentState.GetDisplayName(); }
        }
        
        public int PositionCount
        {
            get
            {
                return Items != null && Items.Any() ? Items.Count(): 0;
            }
        }

        public decimal DocumentAmount
        {
            get
            {
                return Items!=null && Items.Any() ? Items.Sum(t => t.Amount): 0;
            }
        }
        
        private SaleDocumentItemViewModel currentItem;
        public SaleDocumentItemViewModel CurrentItem
        {
            get
            {
                return this.currentItem;
            }

            set
            {
                if (value != this.currentItem)
                {
                    this.currentItem = value;
                    NotifyPropertyChanged();
                }
            }
        }

        
        public void NotifyChanged()
        {
            NotifyPropertyChanged("CurrentItem");
            NotifyPropertyChanged("PositionCount");
            NotifyPropertyChanged("DocumentAmount");
        }

        public BindingList<SaleDocumentItemViewModel> Items { get; set; }
    }
}
