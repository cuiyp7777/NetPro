using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRedisCon
{
    public partial class Form1 : Form
    {
        private static ConnectionMultiplexer _redis;
        private IDatabase _db;
        public Form1()
        {
            InitializeComponent();
        }
        //连接
        private void button1_Click(object sender, EventArgs e)
        {
            if (_redis == null || !_redis.IsConnected)
            {
                //1.连接redis 内存数据库(IP地址，redis的端口，密码)
                _redis = ConnectionMultiplexer.Connect("127.0.0.1:6379,password=P@ssw0rd");
            }
            //数据库有多个库
            _db = _redis.GetDatabase(db: 1);
        }
        /// <summary>
        /// 赋值
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            _db.StringSet("test", this.textBox4.Text);
        }
        //取值
        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox5.Text = _db.StringGet("test");
        }
    }
}
