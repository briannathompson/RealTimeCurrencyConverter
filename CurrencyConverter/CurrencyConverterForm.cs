using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class CurrencyConverterForm : Form
    {
        // Create currencyConverter object to later initialize instance of the CurrencyConverter class
        CurrencyConverter currencyConverter;

        public CurrencyConverterForm()
        {
            InitializeComponent();

            // Create an instance of the CurrencyConverter class
            currencyConverter = new CurrencyConverter();
        }

        private void CurrencyConverterForm_Load(object sender, EventArgs e)
        {
            // Get the key-value pairs from the currencyConverter and store it in symbolData
            Dictionary<string, string> symbolData = currencyConverter.GetSymbols();

            cmbFromCurrency.Items.Clear();
            cmbToCurrency.Items.Clear();

            // Use the symbolData Dictionary as a source of data for the comboboxes
            cmbFromCurrency.DataSource = new BindingSource(symbolData, null);
            cmbFromCurrency.DisplayMember = "Value";   // Ex: United States Dollar; displays as item in combo box
            cmbFromCurrency.ValueMember = "Key";   // Ex: USD

            cmbToCurrency.DataSource = new BindingSource(symbolData, null);
            cmbToCurrency.DisplayMember = "Value";   // Ex: United States Dollar; displays as item in combo box
            cmbToCurrency.ValueMember = "Key";   // Ex: USD
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Get the key from each combobox and store it in a string
            string fromCurrency = ((KeyValuePair<string, string>)cmbFromCurrency.SelectedItem).Key;
            string toCurrency = ((KeyValuePair<string, string>)cmbToCurrency.SelectedItem).Key;

            // Create variable to access the amount entered into the textbox
            // TODO: System.Globalization.NumberStyles.Currency(?) to prevent errors when users enter nonnumeric characters
            double currencyAmount = double.Parse(txtFromCurrencyAmount.Text);

            // Call Convert method to convert the currency then store the result in finalValue
            double finalValue = currencyConverter.Convert(fromCurrency, toCurrency, currencyAmount);

            // Display the final value in txtToCurrencyAmount
            txtToCurrencyAmount.Text = finalValue.ToString();
        }
    }
}