using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Homework
{
    public partial class Lab_HomePage : Form
    {
        public Lab_HomePage()
        {
            InitializeComponent();
        }       
        private void CloseWindowInPanel()
        {
            // 遍歷panel中的控件
            foreach (Control control in splitContainer2.Panel2.Controls)
            {
                // 检查控件是否为窗口類型
                if (control is Form form)
                {
                    // 關閉窗口并释放资源
                    form.Dispose();
                    break;  // 如果只希望關閉一个窗口，可以使用break跳出循環
                }
            }
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            // 关闭当前窗口（如果有）
            CloseWindowInPanel();

            Lab_Homework01 Hello = new Lab_Homework01();
            Hello.TopLevel = false;

            Hello.Parent = this.splitContainer2.Panel2;
            Hello.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            // 关闭当前窗口（如果有）
            CloseWindowInPanel();

            Lab_Homework02 Loan = new Lab_Homework02();
            Loan.TopLevel = false;
            Loan.Parent = this.splitContainer2.Panel2;
            Loan.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            // 关闭当前窗口（如果有）
            CloseWindowInPanel();

            Lab_Homework03_POS POS = new Lab_Homework03_POS();
            POS.TopLevel = false;
            POS.Parent = this.splitContainer2.Panel2;
            POS.Show();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            // 关闭当前窗口（如果有）
            CloseWindowInPanel();

            Lab_Homework04_Score Score = new Lab_Homework04_Score();
            Score.TopLevel = false;
            Score.Parent = this.splitContainer2.Panel2;
            Score.Show();
        }

        private void btnMyClac_Click(object sender, EventArgs e)
        {
            // 关闭当前窗口（如果有）
            CloseWindowInPanel();

            Lab_Homework08_MyClac MyClac = new Lab_Homework08_MyClac();
            MyClac.TopLevel = false;
            MyClac.Parent = this.splitContainer2.Panel2;
            MyClac.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            // 关闭当前窗口（如果有）
            CloseWindowInPanel();

            Lab_Homework11_ScreenSaver ScreenSaver = new Lab_Homework11_ScreenSaver();
            ScreenSaver.Show();
        }

        private void btnPictureViewer_Click(object sender, EventArgs e)
        {
            // 关闭当前窗口（如果有）
            CloseWindowInPanel();

            Lab_Homework14_PictureViewer PictureViewer = new Lab_Homework14_PictureViewer();
            PictureViewer.TopLevel = false;
            PictureViewer.Parent = this.splitContainer2.Panel2;
            PictureViewer.Show();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            // 关闭当前窗口（如果有）
            CloseWindowInPanel();

            Lab_Homework16_Alarm Alarm = new Lab_Homework16_Alarm();
            Alarm.TopLevel = false;
            Alarm.Parent = this.splitContainer2.Panel2;
            Alarm.Show();
        }
    }
}
