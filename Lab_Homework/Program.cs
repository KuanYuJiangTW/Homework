using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Lab_Homework
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Lab_HomePage());
        }
    }

    public struct List
    {
        public string JinXuan;//金萱
        public string Oolong;//烏龍
        public string HighBlack;//高山紅茶
        public string RubyBlack;//紅玉紅茶


        //JinXuan = ListJinXuanTea;
        //Oolong = ListOolongTea;
        //HighBlack = ListHighBlackTea;
        //RubyBlack = ListRubyBlackTea;
    }

    public struct Scores
    {
        public string Name { get; set; }
        public double Ch { get; set; }
        public double En { get; set; }
        public double Math { get; set; }

        public Scores(string textName, double textCh, double textEn, double textMath)
        {
            Name = textName;
            Ch = textCh;
            En = textEn;
            Math = textMath;
        }

    }
}
