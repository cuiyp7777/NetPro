using System;
using System.Windows.Forms;

namespace WinDelegate01
{
    public partial class FormDia : Form
    {
        public FormDia()
        {
            InitializeComponent();
        }
        //2、定义委托事件
        public event SetTextDelegate setTextVoid;

        private void button1_Click(object sender, EventArgs e)
        {
            //3、传参（FormDia窗体中的参数）
            if (setTextVoid != null)
            {
                setTextVoid(this.textBox1.Text);
            }
        }
    }
}
