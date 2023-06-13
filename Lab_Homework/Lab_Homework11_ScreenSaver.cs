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
    public partial class Lab_Homework11_ScreenSaver : Form
    {
        private Timer timer;
        private Point previousMousePosition;
        public Lab_Homework11_ScreenSaver()
        {
            InitializeComponent();


            Load += Lab_Homework11_ScreenSaver_Load;

            // 初始化計時器
            timer = new Timer();
            timer.Interval = 1000; // 每秒檢查一次滑鼠位置
            timer.Tick += Timer_Tick;// 設定計時器事件處理方法


            // 設定表單為全螢幕
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;


        }

        private void Lab_Homework11_ScreenSaver_Load(object sender, EventArgs e)
        {
                        
            Cursor.Hide(); // 隱藏滑鼠游標
            timer.Start(); // 啟動計時器
            previousMousePosition = Cursor.Position;
            //// 訂閱滑鼠移動事件
            //this.MouseMove += new MouseEventHandler(Lab_Homework11_ScreenSaver_MouseMove);
            ////MouseMove += Lab_Homework11_ScreenSaver_MouseMove;
        }
        private void StopScreenSaver()
        {
            Cursor.Show(); // 顯示滑鼠游標
            timer.Stop(); // 停止計時器
            Close(); // 關閉程式
        }

        private void Timer_Tick(object sender, EventArgs e)
        {         

            Random random = new Random();
            pictureBox1.Left = random.Next(0, this.Width - pictureBox1.Width);
            pictureBox1.Top = random.Next(0, this.Height - pictureBox1.Height);

            // 在計時器觸發時執行自訂的 screen saver 程式碼
            // 在這裡可以實現你的自訂 screen saver 邏輯
            // 例如，繪製圖形、播放動畫等等
            // 檢查滑鼠位置是否變化
            if (Cursor.Position != previousMousePosition)
                StopScreenSaver();


        }




        //private void Lab_Homework11_ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        //{

        //    // 滑鼠移動時結束程式
        //    Application.Exit();
        //}


    }
}
