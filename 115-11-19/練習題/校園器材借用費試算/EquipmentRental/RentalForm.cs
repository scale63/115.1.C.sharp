using System;
using System.Windows.Forms;

namespace EquipmentRental
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            dailyRateLabel.Text = "—";
            discountLabel.Text = "—";
            totalLabel.Text = "—";
            feedbackLabel.Text = "";

            int days;
            if (int.TryParse(daysTextBox.Text, out days))
            {
                if (days < 1 || days > 7)
                {
                    feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
                }
                else
                {
                    int dailyRate;
                    if (days <= 2)
                    {
                        dailyRate = 80;
                    }
                    else if (days <= 5)
                    {
                        dailyRate = 70;
                    }
                    else
                    {
                        dailyRate = 60;
                    }

                    int discount;
                    string discountMessage;
                    if (clubCheckBox.Checked)
                    {
                        if (days >= 3)
                        {
                            discount = 30;
                            discountMessage = "折抵 30 元";
                        }
                        else
                        {
                            discount = 0;
                            discountMessage = "未達折抵門檻";
                        }
                    }
                    else
                    {
                        discount = 0;
                        discountMessage = "無優惠";
                    }

                    int total = days * dailyRate - discount;
                    dailyRateLabel.Text = dailyRate.ToString() + " 元";
                    discountLabel.Text = discountMessage;
                    totalLabel.Text = total.ToString() + " 元";
                }
            }
            else
            {
                feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            daysTextBox.Text = "";
            clubCheckBox.Checked = false;
            feedbackLabel.Text = "";
            dailyRateLabel.Text = "—";
            discountLabel.Text = "—";
            totalLabel.Text = "—";
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {

        }

        private void daysTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
