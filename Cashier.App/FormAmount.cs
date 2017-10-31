using System;
using System.Windows.Forms;

namespace Cashier.App
{
    public partial class FormAmount : Form
    {
        public FormAmount()
        {
            InitializeComponent();
        }

        private readonly Action<decimal> beforeClose;
        private readonly decimal documentAmount;
        public FormAmount(decimal documentAmount, Action<decimal> beforeClose):this()
        {
            this.documentAmount = documentAmount;
            this.beforeClose = beforeClose;
            textBoxInput.Focus();
        }

        private void FormAmount_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            decimal sum = 0;
            if (Decimal.TryParse(textBoxInput.Text, out sum) && documentAmount <= sum)
            {
                beforeClose(sum);
                Close();
            }
            
        }

        private void FormAmount_Load(object sender, EventArgs e)
        {
            labelDocumentAmount.Text = documentAmount.ToString();
        }
    }
}
