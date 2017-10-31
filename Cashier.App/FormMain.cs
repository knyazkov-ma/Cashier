using Cashier.App.ViewModel;
using Cashier.DataService;
using Cashier.DataService.Interface;
using System;
using System.Windows.Forms;
using Cashier.App.Mapper;
using Unity.ServiceLocation;

namespace Cashier.App
{
    public partial class FormMain : Form
    {
        private SaleDocumentViewModel documentModel;
        private readonly ISaleDocumentService saleDocumentService;
        public FormMain()
        {
            InitializeComponent();
            UnityServiceLocator serviceLocator = new UnityServiceLocator(UnityConfig.GetConfiguredContainer());
            saleDocumentService = serviceLocator.GetInstance<ISaleDocumentService>();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            documentModel = saleDocumentService.GetNew().ToModel();

            labelDocumentNumber.DataBindings.Add("Text", documentModel, "Id");
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
                documentModel.CurrentItem = (SaleDocumentItemViewModel)bindingSourceMain.Current;
                return;
            }

            if (e.KeyCode == Keys.Down)
            {
                bindingSourceMain.MoveNext();
                documentModel.CurrentItem = (SaleDocumentItemViewModel)bindingSourceMain.Current;
                return;
            }

            if (e.KeyCode == Keys.Delete)
            {
                int p = bindingSourceMain.CurrencyManager.Position;
                bindingSourceMain.RemoveCurrent();
                documentModel.CurrentItem = (SaleDocumentItemViewModel)bindingSourceMain.Current;
                if(p > 0)
                    dataGridViewMain.Rows[p - 1].Selected = true;
                documentModel.NotifyChanged();
                return;
            }


            if (e.KeyCode != Keys.Enter)
                return;
            if (textBoxInput.Text.StartsWith("#"))
            {
                SaleDocumentItemViewModel item = saleDocumentService.GetDocumentItemByCode(textBoxInput.Text.Substring(1)).ToModel();
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
