using System;
using System.Windows.Forms;

namespace Cashier.App
{
    public partial class FormDifference : Form
    {
        public FormDifference()
        {
            InitializeComponent();
        }

        private readonly decimal difference;
        public FormDifference(decimal difference):this()
        {
            this.difference = difference;
        }

        

        private void FormDifference_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void FormDifference_Load(object sender, EventArgs e)
        {
            labelDifference.Text = difference.ToString();
        }
    }
}
