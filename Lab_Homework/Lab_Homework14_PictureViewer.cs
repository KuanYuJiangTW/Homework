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
    public partial class Lab_Homework14_PictureViewer : Form
    {
        private Form imageViewForm; // 用於顯示放大圖片的窗口

        public Lab_Homework14_PictureViewer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                // 創建新的imageViewForm
                imageViewForm = new Form();
                imageViewForm.StartPosition = FormStartPosition.CenterScreen;
                imageViewForm.Size = new Size(600, 375);
                imageViewForm.FormBorderStyle = FormBorderStyle.Sizable;// 允許使用者調整視窗大小
                imageViewForm.MaximizeBox = false;
                imageViewForm.MinimizeBox = false;

                // 在imageViewForm中顯示放大後的圖片
                PictureBox pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Image = this.pictureBox1.Image; // 使用主視窗中的PictureBox圖片
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                imageViewForm.Controls.Add(pictureBox);

                // 顯示imageViewForm
                imageViewForm.Show();           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {            
                // 創建新的imageViewForm
                imageViewForm = new Form();
                imageViewForm.StartPosition = FormStartPosition.CenterScreen;
                imageViewForm.Size = new Size(300, 168);
                imageViewForm.FormBorderStyle = FormBorderStyle.Sizable;// 允許使用者調整視窗大小
                imageViewForm.MaximizeBox = false;
                imageViewForm.MinimizeBox = false;

                // 在imageViewForm中顯示放大後的圖片
                PictureBox pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Image = this.pictureBox2.Image; // 使用主視窗中的PictureBox圖片
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                imageViewForm.Controls.Add(pictureBox);

                // 顯示imageViewForm
                imageViewForm.Show();           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {            
                // 創建新的imageViewForm
                imageViewForm = new Form();
                imageViewForm.StartPosition = FormStartPosition.CenterScreen;
                imageViewForm.Size = new Size(584, 826);
                imageViewForm.FormBorderStyle = FormBorderStyle.Sizable;// 允許使用者調整視窗大小
                imageViewForm.MaximizeBox = false;
                imageViewForm.MinimizeBox = false;

                // 在imageViewForm中顯示放大後的圖片
                PictureBox pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Image = this.pictureBox3.Image; // 使用主視窗中的PictureBox圖片
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                imageViewForm.Controls.Add(pictureBox);
               
                // 顯示imageViewForm
                imageViewForm.Show();           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // 創建新的imageViewForm
            imageViewForm = new Form();
            imageViewForm.StartPosition = FormStartPosition.CenterScreen;
            imageViewForm.Size = new Size(1200, 750);
            imageViewForm.FormBorderStyle = FormBorderStyle.Sizable;// 允許使用者調整視窗大小
            imageViewForm.MaximizeBox = false;
            imageViewForm.MinimizeBox = false;

            // 在imageViewForm中顯示放大後的圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = this.pictureBox4.Image; // 使用主視窗中的PictureBox圖片
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageViewForm.Controls.Add(pictureBox);

            // 顯示imageViewForm
            imageViewForm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // 創建新的imageViewForm
            imageViewForm = new Form();
            imageViewForm.StartPosition = FormStartPosition.CenterScreen;
            imageViewForm.Size = new Size(600, 375);
            imageViewForm.FormBorderStyle = FormBorderStyle.Sizable;// 允許使用者調整視窗大小
            imageViewForm.MaximizeBox = false;
            imageViewForm.MinimizeBox = false;

            // 在imageViewForm中顯示放大後的圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = this.pictureBox5.Image; // 使用主視窗中的PictureBox圖片
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageViewForm.Controls.Add(pictureBox);

            // 顯示imageViewForm
            imageViewForm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // 創建新的imageViewForm
            imageViewForm = new Form();
            imageViewForm.StartPosition = FormStartPosition.CenterScreen;
            imageViewForm.Size = new Size(600, 375);
            imageViewForm.FormBorderStyle = FormBorderStyle.Sizable;// 允許使用者調整視窗大小
            imageViewForm.MaximizeBox = false;
            imageViewForm.MinimizeBox = false;

            // 在imageViewForm中顯示放大後的圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = this.pictureBox6.Image; // 使用主視窗中的PictureBox圖片
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageViewForm.Controls.Add(pictureBox);

            // 顯示imageViewForm
            imageViewForm.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // 創建新的imageViewForm
            imageViewForm = new Form();
            imageViewForm.StartPosition = FormStartPosition.CenterScreen;
            imageViewForm.Size = new Size(600, 375);
            imageViewForm.FormBorderStyle = FormBorderStyle.Sizable;// 允許使用者調整視窗大小
            imageViewForm.MaximizeBox = false;
            imageViewForm.MinimizeBox = false;

            // 在imageViewForm中顯示放大後的圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = this.pictureBox7.Image; // 使用主視窗中的PictureBox圖片
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageViewForm.Controls.Add(pictureBox);

            // 顯示imageViewForm
            imageViewForm.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // 創建新的imageViewForm
            imageViewForm = new Form();
            imageViewForm.StartPosition = FormStartPosition.CenterScreen;
            imageViewForm.Size = new Size(600, 375);
            imageViewForm.FormBorderStyle = FormBorderStyle.Sizable;// 允許使用者調整視窗大小
            imageViewForm.MaximizeBox = false;
            imageViewForm.MinimizeBox = false;

            // 在imageViewForm中顯示放大後的圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = this.pictureBox8.Image; // 使用主視窗中的PictureBox圖片
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageViewForm.Controls.Add(pictureBox);

            // 顯示imageViewForm
            imageViewForm.Show();
        }
    }
}
