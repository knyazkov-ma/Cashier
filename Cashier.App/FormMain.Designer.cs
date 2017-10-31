namespace Cashier.App
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSourceMain = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentCode = new System.Windows.Forms.Label();
            this.labelCurrentPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCurrentCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCurrentAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCurrentName = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDocumentAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDocumentState = new System.Windows.Forms.Label();
            this.labelDocumentNumber = new System.Windows.Forms.Label();
            this.labelPositionCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceMain
            // 
            this.bindingSourceMain.AllowNew = false;
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnCount,
            this.ColumnAmount});
            this.dataGridViewMain.DataSource = this.bindingSourceMain;
            this.dataGridViewMain.Location = new System.Drawing.Point(31, 12);
            this.dataGridViewMain.MultiSelect = false;
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.Size = new System.Drawing.Size(732, 199);
            this.dataGridViewMain.TabIndex = 1;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "Name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnName.HeaderText = "Наименование";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 450;
            // 
            // ColumnCount
            // 
            this.ColumnCount.DataPropertyName = "Count";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnCount.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnCount.HeaderText = "Кол-во";
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.ReadOnly = true;
            this.ColumnCount.Width = 80;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnAmount.HeaderText = "Сумма";
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.ReadOnly = true;
            this.ColumnAmount.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Код:";
            // 
            // labelCurrentCode
            // 
            this.labelCurrentCode.AutoSize = true;
            this.labelCurrentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentCode.Location = new System.Drawing.Point(88, 214);
            this.labelCurrentCode.Name = "labelCurrentCode";
            this.labelCurrentCode.Size = new System.Drawing.Size(50, 25);
            this.labelCurrentCode.TabIndex = 3;
            this.labelCurrentCode.Text = "Код";
            // 
            // labelCurrentPrice
            // 
            this.labelCurrentPrice.AutoSize = true;
            this.labelCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentPrice.Location = new System.Drawing.Point(286, 214);
            this.labelCurrentPrice.Name = "labelCurrentPrice";
            this.labelCurrentPrice.Size = new System.Drawing.Size(64, 25);
            this.labelCurrentPrice.TabIndex = 5;
            this.labelCurrentPrice.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(210, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена:";
            // 
            // labelCurrentCount
            // 
            this.labelCurrentCount.AutoSize = true;
            this.labelCurrentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentCount.Location = new System.Drawing.Point(479, 214);
            this.labelCurrentCount.Name = "labelCurrentCount";
            this.labelCurrentCount.Size = new System.Drawing.Size(80, 25);
            this.labelCurrentCount.TabIndex = 7;
            this.labelCurrentCount.Text = "Кол-во";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(387, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Кол-во:";
            // 
            // labelCurrentAmount
            // 
            this.labelCurrentAmount.AutoSize = true;
            this.labelCurrentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentAmount.Location = new System.Drawing.Point(683, 214);
            this.labelCurrentAmount.Name = "labelCurrentAmount";
            this.labelCurrentAmount.Size = new System.Drawing.Size(80, 25);
            this.labelCurrentAmount.TabIndex = 9;
            this.labelCurrentAmount.Text = "Сумма";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(591, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Сумма:";
            // 
            // labelCurrentName
            // 
            this.labelCurrentName.AutoSize = true;
            this.labelCurrentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentName.Location = new System.Drawing.Point(26, 251);
            this.labelCurrentName.Name = "labelCurrentName";
            this.labelCurrentName.Size = new System.Drawing.Size(202, 31);
            this.labelCurrentName.TabIndex = 10;
            this.labelCurrentName.Text = "Наименование";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.Location = new System.Drawing.Point(32, 285);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(731, 80);
            this.textBoxInput.TabIndex = 11;
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(555, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Сумма документа";
            // 
            // labelDocumentAmount
            // 
            this.labelDocumentAmount.AutoSize = true;
            this.labelDocumentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDocumentAmount.Location = new System.Drawing.Point(550, 419);
            this.labelDocumentAmount.Name = "labelDocumentAmount";
            this.labelDocumentAmount.Size = new System.Drawing.Size(178, 55);
            this.labelDocumentAmount.TabIndex = 13;
            this.labelDocumentAmount.Text = "Сумма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Вид документа:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(192, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Продажа";
            // 
            // labelDocumentState
            // 
            this.labelDocumentState.AutoSize = true;
            this.labelDocumentState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDocumentState.Location = new System.Drawing.Point(286, 370);
            this.labelDocumentState.Name = "labelDocumentState";
            this.labelDocumentState.Size = new System.Drawing.Size(81, 25);
            this.labelDocumentState.TabIndex = 16;
            this.labelDocumentState.Text = "Статус";
            // 
            // labelDocumentNumber
            // 
            this.labelDocumentNumber.AutoSize = true;
            this.labelDocumentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDocumentNumber.Location = new System.Drawing.Point(192, 410);
            this.labelDocumentNumber.Name = "labelDocumentNumber";
            this.labelDocumentNumber.Size = new System.Drawing.Size(146, 25);
            this.labelDocumentNumber.TabIndex = 17;
            this.labelDocumentNumber.Text = "№ документа";
            // 
            // labelPositionCount
            // 
            this.labelPositionCount.AutoSize = true;
            this.labelPositionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPositionCount.Location = new System.Drawing.Point(192, 449);
            this.labelPositionCount.Name = "labelPositionCount";
            this.labelPositionCount.Size = new System.Drawing.Size(98, 25);
            this.labelPositionCount.TabIndex = 18;
            this.labelPositionCount.Text = "Позиций";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(44, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "№ документа:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(92, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Позиций:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 509);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelPositionCount);
            this.Controls.Add(this.labelDocumentNumber);
            this.Controls.Add(this.labelDocumentState);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDocumentAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelCurrentName);
            this.Controls.Add(this.labelCurrentAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelCurrentCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelCurrentPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCurrentCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(811, 547);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(811, 547);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Простой интерфейс для кассира";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrentCode;
        private System.Windows.Forms.Label labelCurrentPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCurrentCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCurrentAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelCurrentName;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDocumentAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDocumentState;
        private System.Windows.Forms.Label labelDocumentNumber;
        private System.Windows.Forms.Label labelPositionCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource bindingSourceMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
    }
}

