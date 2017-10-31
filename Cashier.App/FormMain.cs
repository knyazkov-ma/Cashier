using Cashier.App.ViewModel;
using System.Linq;
using Cashier.DataService.Interface;
using System;
using System.Windows.Forms;
using Cashier.App.Mapper;
using Cashier.Entity;

namespace Cashier.App
{
    public partial class FormMain : Form
    {
        private SaleDocumentViewModel documentModel;
        private readonly ISaleDocumentService saleDocumentService;

        public FormMain(ISaleDocumentService saleDocumentService)
            :this()
        {
            this.saleDocumentService = saleDocumentService; ;
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void setDataBindings()
        {
            labelDocumentNumber.DataBindings.Clear();
            labelDocumentNumber.DataBindings.Add("Text", documentModel, "Id");

            labelPositionCount.DataBindings.Clear();
            labelPositionCount.DataBindings.Add("Text", documentModel, "PositionCount");

            labelDocumentAmount.DataBindings.Clear();
            labelDocumentAmount.DataBindings.Add("Text", documentModel, "DocumentAmount");

            labelDocumentState.DataBindings.Clear();
            labelDocumentState.DataBindings.Add("Text", documentModel, "DocumentStateName");

            labelCurrentCode.DataBindings.Clear();
            labelCurrentCode.DataBindings.Add("Text", documentModel, "CurrentItem.Code");

            labelCurrentPrice.DataBindings.Clear();
            labelCurrentPrice.DataBindings.Add("Text", documentModel, "CurrentItem.Price");

            labelCurrentCount.DataBindings.Clear();
            labelCurrentCount.DataBindings.Add("Text", documentModel, "CurrentItem.Count");

            labelCurrentAmount.DataBindings.Clear();
            labelCurrentAmount.DataBindings.Add("Text", documentModel, "CurrentItem.Amount");

            labelCurrentName.DataBindings.Clear();
            labelCurrentName.DataBindings.Add("Text", documentModel, "CurrentItem.Name");

            bindingSourceMain.Clear();
            bindingSourceMain.DataSource = documentModel.Items;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            documentModel = saleDocumentService.Create().ToModel();

            setDataBindings();
            textBoxInput.Focus();
        }

        
        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Control)
            {
                documentModel = saleDocumentService.Create().ToModel();
                setDataBindings();
                return;
            }
            
            if (documentModel.DocumentState == SaleDocumentState.Complete)
                return;

            if (e.KeyCode == Keys.Delete && e.Control)
            {
                saleDocumentService.Delete(documentModel.Id);
                documentModel = saleDocumentService.Create().ToModel();
                setDataBindings();
                return;
            }

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

            if (e.KeyCode == Keys.S && e.Control && documentModel.Items.Any())
            {
                decimal difference = 0;
                using (Form f = new FormAmount(documentModel.DocumentAmount, delegate(decimal sum) 
                    {
                        difference = sum - documentModel.DocumentAmount;
                        saleDocumentService.Save(documentModel.ToDTO());
                        
                    }))
                {
                    f.ShowDialog();
                }

                using (Form f = new FormDifference(difference))
                {
                    f.ShowDialog();
                }

                documentModel = saleDocumentService.Get(documentModel.Id).ToModel();
                setDataBindings();
                return;
            }


            if (e.KeyCode != Keys.Enter)
                return;
            if (textBoxInput.Text.StartsWith("#"))
            {
                string code = textBoxInput.Text.Substring(1);
                SaleDocumentItemViewModel item = saleDocumentService.GetDocumentItemByCode(code).ToModel();
                if (item == null)
                {
                    MessageBox.Show(String.Format("Позиция с кодом {0} не найдена", code), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
