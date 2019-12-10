using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections.TCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Polly;

namespace NetwokCommsClient
{
    public partial class CommsClient : Form
    {
        public CommsClient()
        {
            InitializeComponent();
        }

        //固定的返回匹配字符串
        private void button1_Click(object sender, EventArgs e)
        {
            //连接信息 
            var connInfo = new ConnectionInfo(txtSerIP.Text, int.Parse(txtSerPort.Text));
            //连接服务器
            var newTcpConnection = TCPConnection.GetConnection(connInfo);
            //发送【GetName】请求，获取对应【ResName】值
            string resMsg = newTcpConnection.SendReceiveObject<string, string>("GetName", "ResName", 5000, listBox1.Text);


            ////5秒重联
            //var retryForever =Policy.Handle<Exception>()
            //    .WaitAndRetryForever(retryAttempt => TimeSpan.FromSeconds(5), (exception, timespan) => {
            //        Console.WriteLine(exception.Message);
            //    });
            //retryForever.Execute(() => {
            //    //重连方法？
            //});

            this.txtReInfo.Text = resMsg;
        }
        //动态的返回匹配字符串
        private void button2_Click(object sender, EventArgs e)
        {
            //连接信息 
            var connInfo = new ConnectionInfo(txtSerIP.Text, int.Parse(txtSerPort.Text));
            //连接服务器
            var newTcpConnection = TCPConnection.GetConnection(connInfo);
            //动态生成
            var guidStr = new Guid().ToString();

            string resMsg = newTcpConnection.SendReceiveObject<string, string>("GetDetails", "GetDetailsReturn"+ guidStr, 5000, guidStr);

            this.txtReinfo2.Text = resMsg;
        }
    }
}
