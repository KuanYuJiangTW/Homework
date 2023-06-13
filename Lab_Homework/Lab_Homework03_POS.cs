using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab_Homework
{
    public partial class Lab_Homework03_POS : Form
    {
        public Lab_Homework03_POS()
        {
            InitializeComponent();
        }

        string ListResult = "";
        string ListResult_o = "";
        string ListResult_h = "";
        string ListResult_r = "";
//---------------------------------------
        int count = 0;
        int count_o = 0;
        int count_h = 0;
        int count_r = 0;
//---------------------------------------
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
//---------------------------------------
        private void btnJinXuanTea_Click(object sender, EventArgs e) //加入清單
        {
            //string a = 300.ToString();
            //string b = 400.ToString();
            //string c = 500.ToString();
            //string d = 600.ToString();

            //L.JinXuan = a ;
            //L.Oolong = b;
            //L.HighBlack = c;
            //L.RubyBlack = d;          
            a += 300;         
            count++; 

            ListResult = "金萱 4兩 x" + count + ",共NT $" + a + "元" ;


            textList.Text = ListResult + "\r\n" + ListResult_o + "\r\n"
                          + ListResult_h + "\r\n" + ListResult_r;//顯示在購物清單

            textTotalPrice.Text = "NT$ " + (a + b + c + d);//顯示在總金額

        }

        private void btnOolongTea_Click(object sender, EventArgs e)
        {
            
            b += 400;
            count_o++;
            ListResult_o = "烏龍 4兩 x" + count_o + ",共NT $" + b + "元";

            textList.Text = ListResult + "\r\n" + ListResult_o + "\r\n"
                          + ListResult_h + "\r\n" + ListResult_r;//顯示在購物清單

            textTotalPrice.Text = "NT$ " + (a + b + c + d);//顯示在總金額


        }

        private void btnHighBlackTea_Click(object sender, EventArgs e)
        {
            c += 500;
            count_h++;
            ListResult_h = "高山紅茶 4兩 x" + count_h + ",共NT $" + c + "元";

            textList.Text = ListResult + "\r\n" + ListResult_o + "\r\n" 
                          + ListResult_h + "\r\n" + ListResult_r;//顯示在購物清單

            textTotalPrice.Text = "NT$ " + (a + b + c + d);//顯示在總金額

        }

        private void btnRubyBlackTea_Click(object sender, EventArgs e)
        {
            d += 600;
            count_r++;
            ListResult_r = "紅玉紅茶 4兩 x" + count_r + ",共NT $" + d + "元";

            textList.Text = ListResult + "\r\n" + ListResult_o + "\r\n"
                          + ListResult_h + "\r\n" + ListResult_r;//顯示在購物清單

            textTotalPrice.Text = "NT$ " + (a + b + c + d);//顯示在總金額

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //textList.Text = 0 + "\r\n" + ListResult_o + "\r\n"
            // + ListResult_h + "\r\n" + ListResult_r;//顯示在購物清單
            //~Lab_Homework03();
            //textList.Text = null;
            textList.Text = "尚未點餐";
            textTotalPrice.Text = "NT$ 0";

            ListResult = "";
            ListResult_o = "";
            ListResult_h = "";
            ListResult_r = "";
            //---------------------------------------
            count = 0;
            count_o = 0;
            count_h = 0;
            count_r = 0;
            //---------------------------------------
            a = 0;
            b = 0;
            c = 0;
            d = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額 : NT$ " + (a + b + c + d),"確認付款");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額 : NT$ " + (a + b + c + d) + "\r\n" + "折扣後金額 : NT$ " + (a + b + c + d)*0.9
                           , "確認付款");
        }
    }
}
