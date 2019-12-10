using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace networkCommsServer
{
    public partial class CommsServer : Form
    {
        public CommsServer()
        {
            InitializeComponent();
        }

        //启动监听
        private void button1_Click(object sender, EventArgs e)
        {
            //IP地址和端口
            IPEndPoint thePoint = new IPEndPoint(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));
            //开始监听此IP和端口  使用TCP协议
            Connection.StartListening(ConnectionType.TCP, thePoint);

            //监听【固定】：GetName的消息的处理方法
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("GetName", (PacketHeader header, Connection connection, string msg) =>
                    {
                        string resMsg = "";

                        if (msg == "星期一")
                            resMsg = "Monday";
                        else if (msg == "星期二")
                            resMsg = "Tuesday";
                        else if (msg == "星期三")
                            resMsg = "Wednesday";
                        else if (msg == "星期四")
                            resMsg = "Thursday";
                        else if (msg == "星期五")
                            resMsg = "Friday";
                        else if (msg == "星期六")
                            resMsg = "Saturday";
                        else if (msg == "星期日")
                            resMsg = "Sunday";
                        connection.SendObject("ResName", resMsg);
                    });


            //监听【动态】：GetDetails
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("GetDetails", (PacketHeader header, Connection connection, string guid) =>
            {
                Task t = new Task(() =>
                {
                    var resMsg = "动态生成匹配str，防止串数据";
                    connection.SendObject("GetDetailsReturn" + guid, resMsg);
                });
                t.Start();
            });

            button1.Text = "已经开始监听";
        }
    }
}
