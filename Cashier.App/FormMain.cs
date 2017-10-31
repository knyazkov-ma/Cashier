using Cashier.App.ViewModel;
using Cashier.DataService;
using Cashier.DataService.Interface;
using System;
using System.Windows.Forms;
using Cashier.App.Mapper;

namespace Cashier.App
{
    public partial class FormMain : Form
    {
        private PurchaseDocumentViewModel documentModel;
        private readonly IPurchaseDocumentService purchaseDocumentService;
        public FormMain()
        {
            InitializeComponent();
            purchaseDocumentService = new PurchaseDocumentService();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            documentModel = purchaseDocumentService.GetNew().ToModel();

            labelDocumentNumber.DataBindings.Add("Text", documentModel, "DocumentNumber");
            labelPositionCount.DataBindings.Add("Text", documentModel, "PositionCount");
            labelDocumentAmount.DataBindings.Add("Text", documentModel, "DocumentAmount");
            labelDocumentState.DataBindings.Add("Text", documentModel, "DocumentState");

            labelCurrentCode.DataBindings.Add("Text", documentModel, "CurrentItem.Code");
            labelCurrentPrice.DataBindings.Add("Text", documentModel, "CurrentItem.Price");
            labelCurrentCount.DataBindings.Add("Text", documentModel, "CurrentItem.Count");
            labelCurrentAmount.DataBindings.Add("Text", documentModel, "CurrentItem.Amount");
            labelCurrentName.DataBindings.Add("Text", documentModel, "CurrentItem.Name");

            bindingSourceMain.DataSource = documentModel.Items;
        }

        
        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                bindingSourceMain.MovePrevious();
                documentModel.CurrentItem = (PurchaseDocumentItemViewModel)bindingSourceMain.Current;
                return;
            }

            if (e.KeyCode == Keys.Down)
            {
                bindingSourceMain.MoveNext();
                documentModel.CurrentItem = (PurchaseDocumentItemViewModel)bindingSourceMain.Current;
                return;
            }

            if (e.KeyCode == Keys.Delete)
            {
                int p = bindingSourceMain.CurrencyManager.Position;
                bindingSourceMain.RemoveCurrent();
                documentModel.CurrentItem = (PurchaseDocumentItemViewModel)bindingSourceMain.Current;
                if(p > 0)
                    dataGridViewMain.Rows[p - 1].Selected = true;
                documentModel.NotifyChanged();
                return;
            }


            if (e.KeyCode != Keys.Enter)
                return;
            if (textBoxInput.Text.StartsWith("#"))
            {
                PurchaseDocumentItemViewModel item = purchaseDocumentService.GetDocumentItemByCode(textBoxInput.Text.Substring(1)).ToModel();
                if (item == null)
                {
                    return;
                }

                documentModel.Items.Add(item);
                documentModel.CurrentItem = item;
                documentModel.NotifyChanged();

                bindingSourceMain.MoveLast();
            }
            else
            {
                int count = 0;
                if (Int32.TryParse(textBoxInput.Text, out count))
                {
                    documentModel.CurrentItem.Count = count;
                    documentModel.NotifyChanged();
                }
            }

            textBoxInput.Text = "";
        }
    }
}
