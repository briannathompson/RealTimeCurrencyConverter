namespace CurrencyConverter
{
    partial class CurrencyConverterForm
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
            this.cmbFromCurrency = new System.Windows.Forms.ComboBox();
            this.cmbToCurrency = new System.Windows.Forms.ComboBox();
            this.txtFromCurrencyAmount = new System.Windows.Forms.TextBox();
            this.txtToCurrencyAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbFromCurrency
            // 
            this.cmbFromCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFromCurrency.FormattingEnabled = true;
            this.cmbFromCurrency.Location = new System.Drawing.Point(152, 79);
            this.cmbFromCurrency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFromCurrency.Name = "cmbFromCurrency";
            this.cmbFromCurrency.Size = new System.Drawing.Size(349, 31);
            this.cmbFromCurrency.TabIndex = 0;
            // 
            // cmbToCurrency
            // 
            this.cmbToCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToCurrency.FormattingEnabled = true;
            this.cmbToCurrency.Location = new System.Drawing.Point(152, 164);
            this.cmbToCurrency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbToCurrency.Name = "cmbToCurrency";
            this.cmbToCurrency.Size = new System.Drawing.Size(349, 31);
            this.cmbToCurrency.TabIndex = 1;
            // 
            // txtFromCurrencyAmount
            // 
            this.txtFromCurrencyAmount.Location = new System.Drawing.Point(35, 79);
            this.txtFromCurrencyAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFromCurrencyAmount.Name = "txtFromCurrencyAmount";
            this.txtFromCurrencyAmount.Size = new System.Drawing.Size(109, 30);
            this.txtFromCurrencyAmount.TabIndex = 2;
            // 
            // txtToCurrencyAmount
            // 
            this.txtToCurrencyAmount.Location = new System.Drawing.Point(35, 164);
            this.txtToCurrencyAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtToCurrencyAmount.Name = "txtToCurrencyAmount";
            this.txtToCurrencyAmount.Size = new System.Drawing.Size(109, 30);
            this.txtToCurrencyAmount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.Location = new System.Drawing.Point(13, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnConvert.Location = new System.Drawing.Point(208, 215);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(115, 44);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(112, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Real-Time Currency Converter";
            // 
            // CurrencyConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 272);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToCurrencyAmount);
            this.Controls.Add(this.txtFromCurrencyAmount);
            this.Controls.Add(this.cmbToCurrency);
            this.Controls.Add(this.cmbFromCurrency);
            this.Font = new System.Drawing.Font("Calibri", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CurrencyConverterForm";
            this.Text = "Real-Time Currency Converter";
            this.Load += new System.EventHandler(this.CurrencyConverterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFromCurrency;
        private System.Windows.Forms.ComboBox cmbToCurrency;
        private System.Windows.Forms.TextBox txtFromCurrencyAmount;
        private System.Windows.Forms.TextBox txtToCurrencyAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label3;
    }
}

