using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDelete02
{
    public delegate void updateTimeValue(int nValue);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            //f2窗体委托注册至f1方法
            f2.upMin += F1_upMin;
            f2.upSec += F1_upSec;
            f2.ShowDialog();
        }
        //更新秒
        void F1_upSec(int nValue)
        {
            this.textBoxSec.Text = nValue + "\r\n" + this.textBoxSec.Text;
        }
        //显示分钟
        void F1_upMin(int nValue)
        {
            this.textBoxMin.Text = nValue + "\r\n" + this.textBoxMin.Text;
        }
    }
}
