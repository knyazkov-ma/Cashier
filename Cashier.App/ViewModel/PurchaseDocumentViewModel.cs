using System.ComponentModel;
using System.Linq;

namespace Cashier.App.ViewModel
{
    public class PurchaseDocumentViewModel : BaseViewModel
    {

        public PurchaseDocumentViewModel()
        {
            Items = new BindingList<PurchaseDocumentItemViewModel>();
            CurrentItem = new PurchaseDocumentItemViewModel();
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
        
        private PurchaseDocumentItemViewModel currentItem;
        public PurchaseDocumentItemViewModel CurrentItem
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

        public BindingList<PurchaseDocumentItemViewModel> Items { get; set; }
    }
}
