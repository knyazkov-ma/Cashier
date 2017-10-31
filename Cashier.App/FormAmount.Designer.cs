namespace Cashier.App
{
    partial class FormAmount
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
            this.labelDocumentAmount = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelCurrentName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDocumentAmount
            // 
            this.labelDocumentAmount.AutoSize = true;
            this.labelDocumentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDocumentAmount.Location = new System.Drawing.Point(195, 0);
            this.labelDocumentAmount.Name = "labelDocumentAmount";
            this.labelDocumentAmount.Size = new System.Drawing.Size(178, 55);
            this.labelDocumentAmount.TabIndex = 16;
            this.labelDocumentAmount.Text = "Сумма";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.Location = new System.Drawing.Point(14, 63);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(449, 80);
            this.textBoxInput.TabIndex = 15;
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyDown);
            // 
            // labelCurrentName
            // 
            this.labelCurrentName.AutoSize = true;
            this.labelCurrentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentName.Location = new System.Drawing.Point(11, 8);
            this.labelCurrentName.Name = "labelCurrentName";
            this.labelCurrentName.Size = new System.Drawing.Size(126, 31);
            this.labelCurrentName.TabIndex = 14;
            this.labelCurrentName.Text = "К оплате";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxInput);
            this.panel1.Controls.Add(this.labelDocumentAmount);
            this.panel1.Controls.Add(this.labelCurrentName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 158);
            this.panel1.TabIndex = 17;
            // 
            // FormAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 158);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAmount";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Закрытие чека";
            this.Load += new System.EventHandler(this.FormAmount_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAmount_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDocumentAmount;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelCurrentName;
        private System.Windows.Forms.Panel panel1;
    }
}