using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public int RATE { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const  decimal RATE = 0.005m; // Interest rate of 0.5%
            decimal Balance; // To hold the starting balance
          int months;   
          

            

            if (decimal.TryParse(startingBalTextBox.Text, out Balance))
            {
                if(int.TryParse(monthsTextBox.Text, out months))
                {
                  int count = 1;
                while (count <= months)
                {
                        Balance = Balance * (1 + RATE); // Add 0.5% interest
                    detailListBox.Items.Add($"第{count} 個月的本利和: {Balance:C2}");
                    count = count + 1;  

                    }
                // Display the ending balance.
                endingBalanceLabel.Text = Balance.ToString("c");
            }
            else
            {
                MessageBox.Show("請輸入有效的月份數");
                }
            }
            else
            { 
                MessageBox.Show("請輸入有效的起始餘額");
            }
            endingBalanceLabel.Text = Balance.ToString("C");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes, the endingBalanceLabel control,
            // and the ListBox.
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // Reset the focus.
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void endingBalanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void startingBalTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
