using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab_Homework
{
    public partial class Lab_Homework04_Score : Form
    {
        public Lab_Homework04_Score()
        {
            InitializeComponent();
        }
        string Score = "";        
        
        private void button1_Click(object sender, EventArgs e)
        {
            double Ch = 0;
            double En = 0;
            double Math = 0;
            bool TCh = double.TryParse(textCh.Text, out Ch);
            bool TEn = double.TryParse(textEn.Text, out En);
            bool TMath = double.TryParse(textMath.Text, out Math);

            if (TCh == true && TEn == true && TMath == true)
            {
                
                Scores emp = new Scores(textName.Text, Ch,En,Math);
                
                Score =  "姓名 : " +  emp.Name + "\r\n" + 
                         "國文 : " + emp.Ch + "分" + "\r\n" +
                         "英文 : " + emp.En + "分" + "\r\n" +
                         "數學 : " + emp.Math + "分";
            }
            else
            {
                MessageBox.Show("好好打字");

                textCh.Clear();
                textCh.Focus();
                textEn.Clear();
                textEn.Focus();
                textMath.Clear();
                textMath.Focus();
            }
}

        private void button2_Click(object sender, EventArgs e)
        {
            textScore.Text = Score;
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            double Ch = 0;
            double En = 0;
            double Math = 0;
//--------------------------------------------------------
            Ch = double.Parse(textCh.Text);
            En = double.Parse(textEn.Text);
            Math = double.Parse(textMath.Text);
//--------------------------------------------------------
            double[] array = {Ch,En,Math};
            string[] array2 = { "國文", "英文", "數學" };

            
            textMaxMin.Text = "最高科目成績為 : " + 
                               array2[Array.IndexOf(array, array.Max())] +
                               array.Max() + "分" + "\r\n" +
                               "最低科目成績為 : " +
                               array2[Array.IndexOf(array, array.Min())] +
                               array.Min() + "分";      
        }
    }
}
