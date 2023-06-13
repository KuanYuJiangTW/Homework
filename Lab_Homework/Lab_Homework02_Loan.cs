using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab_Homework
{
    public partial class Lab_Homework02 : Form
    {

        public Lab_Homework02()
        {
            InitializeComponent();
        }

        public double MonPay { get; private set; }//回去修改這個


        public void MonthPay_Click(object sender, EventArgs e)
        {
           Double Amt = double.Parse(textLoan.Text); //貸款金額
           Double RT = double.Parse(textRepayTerm.Text); //期限(年)
           Double itr = double.Parse(textInterrest_Rate.Text); //年利率%

            //本息公式:
            MonPay = Amt * Math.Pow((1 + (itr / 1200)), (RT*12))* ((itr / 1200)/(Math.Pow((1 + (itr / 1200)), (RT * 12))-1));
            //MonPay = 12000 * Math.Pow(1.01,12) * (0.01 / (Math.Pow(1.01,12) - 1));

            MessageBox.Show("月付額:" + Convert.ToInt32(MonPay));
        }

        private void TotalPay_Click(object sender, EventArgs e)
        {
            Double Amt = double.Parse(textLoan.Text); //貸款金額
            Double RT = double.Parse(textRepayTerm.Text); //期限(年)
            Double itr = double.Parse(textInterrest_Rate.Text); //年利率%

            //本息公式:
            MonPay = Amt * Math.Pow((1 + (itr / 1200)), (RT * 12)) * ((itr / 1200) / (Math.Pow((1 + (itr / 1200)), (RT * 12)) - 1));
            

            MessageBox.Show("總付款:" + Convert.ToInt32(MonPay * 12));
        }
        
        private void btnReport_Click(object sender, EventArgs e)
        {
            Double Amt = double.Parse(textLoan.Text); //貸款金額
            Double RT = double.Parse(textRepayTerm.Text); //期限(年)
            Double itr = double.Parse(textInterrest_Rate.Text); //年利率%

            MonPay = Amt * Math.Pow((1 + (itr / 1200)), (RT * 12)) * ((itr / 1200) / (Math.Pow((1 + (itr / 1200)), (RT * 12)) - 1));

            string MonPay_st = Convert.ToInt32(MonPay).ToString();
            string TotalPay_st = Convert.ToInt32(MonPay * 12).ToString();

            
            Lab_Homework02_1 lab = new Lab_Homework02_1(textLoan.Text, textRepayTerm.Text, textInterrest_Rate.Text
               , MonPay_st, TotalPay_st);
            lab.Show();



            //lab.textLoan_01 = Amt;












            //"貸款金額:" + Amt + "\n" +
            //                "期限(年):" + RT + "\n" +
            //                "年利率%:" + itr + "\n" +
            //                "月付款:" + Convert.ToInt32(MonPay) + "\n" +
            //                "總付款:" + Convert.ToInt32(MonPay * 12)
        }

        private void textLoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
