namespace Cashier.App.ViewModel
{
    public class PurchaseDocumentItemViewModel : BaseViewModel
    {
        public long Id { get; set; }

        private string code;
        public string Code
        {
            get
            {
                return this.code;
            }

            set
            {
                if (value != this.code)
                {
                    this.code = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value != this.name)
                {
                    this.name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int count;
        public int Count
        {
            get
            {
                return this.count;
            }

            set
            {
                if (value != this.count)
                {
                    this.count = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged("Amount");
                }
            }
        }


        private decimal price;
        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value != this.price)
                {
                    this.price = value;
                    NotifyPropertyChanged();
                }
            }
        }
        
        public decimal Amount
        {
            get
            {
                return price * count;
            }
        }

    }
}
