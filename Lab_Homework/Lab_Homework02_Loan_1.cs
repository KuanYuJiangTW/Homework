using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Homework
{
    public partial class Lab_Homework02_1 : Form
    {

        public Lab_Homework02_1(string Loan, string RepayTerm, string Interrest_Rate, string MonthPay, string TotalPay)
        {
            InitializeComponent();
            textLoan_01.Text = Loan;
            textRepayTerm01.Text = RepayTerm;
            textInterrest_Rate01.Text = Interrest_Rate;
            textMonthPay01.Text = MonthPay;
            textTotalPay01.Text = TotalPay;



        }



        private void textLoan_01_TextChanged(object sender, EventArgs e)
        {

            
        }
    }
}
