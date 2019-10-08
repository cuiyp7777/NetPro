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
    public partial class Form2 : Form
    {
        public event updateTimeValue upMin;//分钟更新
        public event updateTimeValue upSec;//秒更新
        int nMin = DateTime.Now.Minute;
        int nSec = DateTime.Now.Second;

        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBox1.Text = DateTime.Now.ToString("HH:mm:ss");
            //分状态改变
            if (nMin != DateTime.Now.Minute)
            {
                nMin = DateTime.Now.Minute;
                upMin(DateTime.Now.Minute);
            }
            //秒状态改变
            if (nSec != DateTime.Now.Second)
            {
                nSec = DateTime.Now.Second;
                upSec(DateTime.Now.Second);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
        }
    }
}
