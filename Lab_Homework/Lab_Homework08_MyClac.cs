using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Homework
{
    public partial class Lab_Homework08_MyClac : Form
    {
        public Lab_Homework08_MyClac()
        {
            InitializeComponent();
        }

        Double c = 0;
        Double a = 0;
        Double b = 0;
        private void btnplus_Click(object sender, EventArgs e)
        {
            if (a != null && b != null)
            {
            Double a = double.Parse(textnum1.Text);
            Double b = double.Parse(textnum2.Text);
            
                c = a + b;
                textanswer.Text = Convert.ToString(c);
            }
            else
            {
                textanswer.Text = "請輸入數字!!!";
            };
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            Double a = double.Parse(textnum1.Text);
            Double b = double.Parse(textnum2.Text);
            c = a - b;
            textanswer.Text = Convert.ToString(c);
        }

        private void btntimes_Click(object sender, EventArgs e)
        {
            Double a = double.Parse(textnum1.Text);
            Double b = double.Parse(textnum2.Text);
            c = a * b;
            textanswer.Text = Convert.ToString(c);
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            Double a = double.Parse(textnum1.Text);
            Double b = double.Parse(textnum2.Text);
            c = a / b;
            textanswer.Text = Convert.ToString(c);
        }
    }
}
