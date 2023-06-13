using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_Homework
{
    public partial class Lab_Homework01 : Form
    {
        public Lab_Homework01()
        {
            InitializeComponent();
        }

        private void Say_HELLO_Click(object sender, EventArgs e)
        {
            string name = textCN_Name.Text,
                   ENname = textEN_Name.Text,
                   Sex = text_Sex.Text,
                   CON = text_CON.Text;
            MessageBox.Show
                (
                "Hello,我是" + name + "\r\n" +
                "英文名字是" + ENname + "\r\n" +
                "性別是" + Sex + "\r\n" +
                "星座是" + CON + "\r\n" +
                "很高興認識你。"
                );


        }

        private void Say_Hi_Click(object sender, EventArgs e)
        {
            string name = textCN_Name.Text,
                    ENname = textEN_Name.Text,
                    Sex = text_Sex.Text,
                    CON = text_CON.Text;
            MessageBox.Show
                (
                "Hello,我是" + name + "\r\n" +
                "英文名字是" + ENname + "\r\n" +
                "性別是" + Sex + "\r\n" +
                "星座是" + CON + "\r\n" +
                "很高興認識你。"
                );
        }
    }
}
