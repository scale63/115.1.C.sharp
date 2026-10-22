using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double test1, test2, test3, average;   // Declare variables to hold the test scores and average.


                test1 = double.Parse(test1TextBox.Text);   // Get the first test score from the text box.
                test2 = double.Parse(test2TextBox.Text);   // Get the second test score from the text box.
                test3 = double.Parse(test3TextBox.Text);   // Get the third test score from the text box.

                average = (test1 + test2 + test3) / 3;   // Calculate the average of the three test scores. 
                averageLabel.Text = average.ToString("F1");   // Display the average in the label, formatted to one decimal place. }
            }
            catch (FormatException)
            {
                // Display an error message if the input is not a valid number.
                MessageBox.Show("Please enter valid numeric values for all test scores.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the input and output controls.
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
