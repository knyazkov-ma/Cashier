using System.ComponentModel;
using System.Linq;

namespace Cashier.App.ViewModel
{
    public class SaleDocumentViewModel : BaseViewModel
    {

        public SaleDocumentViewModel()
        {
            Items = new BindingList<SaleDocumentItemViewModel>();
            CurrentItem = new SaleDocumentItemViewModel();
            documentState = "Открытый";
        }

        public long Id { get; set; }

        private string documentState;
        public string DocumentState
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

        private string documentNumber;
        public string DocumentNumber
        {
            get
            {
                return this.documentNumber;
            }

            set
            {
                if (value != this.documentNumber)
                {
                    this.documentNumber = value;
                    NotifyPropertyChanged();
                }
            }
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
