using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double km; // 儲存行駛公里數
            double liters; // 儲存耗油量
            double kmpl; // 儲存每公升行駛公里數
            if (double.TryParse(this.Text, out km))
            {
                if (double.TryParse(this.Text, out liters))
                {
                    if (km>0 && liters>0)
                    {
                        kmpl = km / liters; // 計算每公升行駛公里數
                    outputDescriptionLabel.Text = "每公升行駛公里數: " + kmpl.ToString("F2");
                     }
                    else
                    {
                        MessageBox.Show("行駛公里數和耗油量必須大於零。", "輸入錯誤");
                    }
                }
                else
                {
                    MessageBox.Show("請輸入有效的耗油量。", "輸入錯誤");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的行駛公里數。", "輸入錯誤");
            }
        }

                private void exitButton_Click(object sender, EventArgs e)
                {
                    // 關閉表單。
                    this.Close();
                }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void milesTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
