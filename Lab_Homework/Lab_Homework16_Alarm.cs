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
    public partial class Lab_Homework16_Alarm : Form
    {
        private Timer timer;
        public Lab_Homework16_Alarm()
        {
            InitializeComponent();
          
            timer = new Timer();
            timer.Interval = 1000; // 設定間隔為 1 秒 (1000 毫秒)
            timer.Tick += timer1_Tick; // 設定計時器事件處理方法
        }
        private void Lab_Homework16_Alarm_Load(object sender, EventArgs e)
        {
            timer.Start(); // 啟動計時器
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 每次計時器觸發時更新時間
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}