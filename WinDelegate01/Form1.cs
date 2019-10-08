using System;
using System.Windows.Forms;

namespace WinDelegate01
{
    //1、定义委托（同样nameplace下通用）
    public delegate void SetTextDelegate(string value);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDia f2 = new FormDia();
            //4、调用
            f2.setTextVoid += setText;
            f2.ShowDialog();
        }

        public void setText(string text)
        {
            //为Form1窗体控制赋值
            this.textBox1.Text = text;
        }
    }
}
