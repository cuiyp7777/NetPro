using Polly;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPolly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //重试
        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add("启动...");



            Policy
            // 1. 指定要处理什么异常
            .Handle<HttpRequestException>()
            //    或者指定需要处理什么样的错误返回
            .OrResult<HttpResponseMessage>(r => r.StatusCode == HttpStatusCode.BadGateway)
            // 2. 指定重试次数和重试策略
            .Retry(3, (exception, retryCount, context) =>
            {
                this.listBox1.Items.Add("注：_开始第[" + retryCount + "]次重试→");
            })
            // 3. 执行具体任务
            .Execute(ExecuteMockRequest);

            this.listBox1.Items.Add("程序结束..");
        }
        public HttpResponseMessage ExecuteMockRequest()
        {
            // 模拟网络请求
            this.listBox1.Items.Add("__执行方法...");
            this.listBox1.Items.Add("____模拟网络请求出现故障...");
            Thread.Sleep(500);
            // 模拟网络错误
            return new HttpResponseMessage(HttpStatusCode.BadGateway);
        }
        //无限重试
        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add("启动...");

            var retryForever = Policy.Handle<Exception>()
            //    或者指定需要处理什么样的错误返回
            .OrResult<Exception>(r => r.Message == "200")
            // 2. 指定重试次数和重试策略
            .WaitAndRetryForever(retryAttempt => TimeSpan.FromSeconds(1), (exception, timespan) =>
            {
                this.listBox1.Items.Add("注：_重试[" + timespan + "]→");
            });
            retryForever.Execute(ConnectToServer);

            this.listBox1.Items.Add("程序结束..");
        }
        private Exception ConnectToServer()
        {
            this.listBox1.Items.Add("执行方法..");
            //模拟异常
            return new Exception("200");
        }

        //超时
        private void button3_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add("启动...");

            Policy.Timeout(10, onTimeout: (context, timespan, task) =>
            {
                this.listBox1.Items.Add("执行...");
            });

        }
    }

}
