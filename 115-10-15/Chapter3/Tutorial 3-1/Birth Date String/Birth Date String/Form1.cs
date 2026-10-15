using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Birth_Date_String
{
    // 表單主要類別：負責 UI 事件處理與輸入欄位的簡單組合顯示
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 按下「顯示日期」按鈕時觸發的事件處理程序
        // 會將使用者在四個 TextBox 中輸入的內容組合成一個字串，
        // 使用中文逗號「，」作為分隔，然後顯示在 dateOutputLabel 上。
        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 組合各輸入欄位成為一個顯示字串，使用中文逗號分隔
            string output = dayOfWeekTextBox.Text + "，" + monthTextBox.Text + "，" + dayOfMonthTextBox.Text + "，" + yearTextBox.Text;
            // 將結果顯示在畫面上的標籤
            dateOutputLabel.Text = output;
        }

        // 按下「清除」按鈕時觸發的事件處理程序
        // 會清空所有輸入欄位與輸出標籤，並將焦點回到第一個輸入欄位
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除所有輸入與輸出
            dayOfWeekTextBox.Clear();
            monthTextBox.Clear();
            dayOfMonthTextBox.Clear();
            yearTextBox.Clear();
            dateOutputLabel.Text = string.Empty;
            // 將游標移回第一個欄位，方便使用者繼續輸入
            dayOfWeekTextBox.Focus();
        }

        // 按下「離開」按鈕時關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前表單（結束程式視窗）
            this.Close();
        }

        // 表單載入時的事件（目前未實作額外邏輯）
        private void Form1_Load(object sender, EventArgs e)
        {
            // 可在此處加入初始化資料或設定預設值
        }

        // dateOutputLabel 的 Click 事件（通常不需要處理，保留空實作）
        private void dateOutputLabel_Click(object sender, EventArgs e)
        {
            // 保留為空：避免未處理的例外或未使用警告
        }
    }
}
