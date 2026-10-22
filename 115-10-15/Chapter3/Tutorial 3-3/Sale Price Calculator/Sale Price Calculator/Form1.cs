using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;
            decimal discountPercentage;
            decimal salePrice;

            originalPrice = Convert.ToDecimal(originalPriceTextBox.Text);
            discountPercentage = Convert.ToDecimal(discountPercentageTextBox.Text);

            salePrice = originalPrice - (originalPrice * discountPercentage / 100);

            salePriceLabel.Text = salePrice.ToString("C");

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
