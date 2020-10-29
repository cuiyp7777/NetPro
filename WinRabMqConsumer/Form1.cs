﻿using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRabMqConsumer
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 路由名称
        /// </summary>
        const string ExchangeName = "howdy.exchange";
        //队列名称
        const string QueueName = "howdy.queue";
        /// <summary>
        /// 路由名称
        /// </summary>
        const string TopExchangeName = "topic.howdy.exchange";
        //队列名称
        const string TopQueueName = "topic.howdy.queue";
        /// <summary>
        /// 连接配置
        /// </summary>
        private static readonly ConnectionFactory rabbitMqFactory = new ConnectionFactory()
        {
            Uri = new Uri("amqp://arrcenmq:arrcen911@59.110.172.150:5672/")
        };
        /// <summary>
        /// 基于事件的，当消息到达时触发事件，获取数据
        /// </summary>
        public void DirectAcceptExchangeTask()
        {
            using (IConnection conn = rabbitMqFactory.CreateConnection())
            {
                using (IModel channel = conn.CreateModel())
                {
                    //channel.ExchangeDeclare(ExchangeName, "direct", durable: true, autoDelete: false, arguments: null);
                    channel.QueueDeclare(QueueName, durable: true, autoDelete: false, exclusive: false, arguments: null);
                    channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);//告诉broker同一时间只处理一个消息
                    //channel.QueueBind(QueueName, ExchangeName, routingKey: QueueName);
                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) =>
                    {
                        var msgBody = Encoding.UTF8.GetString(ea.Body.ToArray());
                        var ReceivedStr = string.Format("***接收时间:{0}，消息内容：{1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), msgBody);
                        this.listBox1.Items.Add(ReceivedStr);
                        //int dots = msgBody.Split('.').Length - 1;
                        //System.Threading.Thread.Sleep(dots * 1000);
                        ////处理完成，告诉Broker可以服务端可以删除消息，分配新的消息过来
                        //channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
                    };
                    //noAck设置false,告诉broker，发送消息之后，消息暂时不要删除，等消费者处理完成再说
                    channel.BasicConsume(QueueName, autoAck: false, consumer: consumer);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
        }
        //接收
        private void button1_Click(object sender, EventArgs e)
        {
            //DirectAcceptExchange();
            //DirectAcceptExchangeEvent();
            DirectAcceptExchangeTask();
            //TopicAcceptExchange();
        }
        /// <summary>
        /// 基于时间轮询的，每隔一段时间获取一次
        /// </summary>
        public  void DirectAcceptExchange()
        {
            using (IConnection conn = rabbitMqFactory.CreateConnection())
            {
                using (IModel channel = conn.CreateModel())
                {
                    channel.ExchangeDeclare(ExchangeName, ExchangeType.Direct, durable: true, autoDelete: false, arguments: null);
                    channel.QueueDeclare(QueueName, durable: true, autoDelete: false, exclusive: false, arguments: null);
                    channel.QueueBind(QueueName, ExchangeName, routingKey: QueueName);
                    while (true)
                    {
                        BasicGetResult msgResponse = channel.BasicGet(QueueName, true);
                        if (msgResponse != null)
                        {
                            var msgBody = Encoding.UTF8.GetString(msgResponse.Body.ToArray());

                            this.listBox1.Items.Add(string.Format("***接收时间:{0}，消息内容：{1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), msgBody));
                        }

                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }
                }
            }
        }
        /// <summary>
        /// 基于事件的，当消息到达时触发事件，获取数据
        /// </summary>
        public  void DirectAcceptExchangeEvent()
        {
            using (IConnection conn = rabbitMqFactory.CreateConnection())
            {
                using (IModel channel = conn.CreateModel())
                {
                    //channel.ExchangeDeclare(ExchangeName, "direct", durable: true, autoDelete: false, arguments: null);
                    channel.QueueDeclare(QueueName, durable: true, autoDelete: false, exclusive: false, arguments: null);
                    //channel.QueueBind(QueueName, ExchangeName, routingKey: QueueName);
                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) =>
                    {
                        var msgBody = Encoding.UTF8.GetString(ea.Body.ToArray());

                        this.listBox1.Items.Add(string.Format("***接收时间:{0}，消息内容：{1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), msgBody));
                    };
                    channel.BasicConsume(QueueName, true, consumer: consumer);
                }
            }
        }
       
        /// <summary>
        /// topic 模糊匹配模式，符号“#”匹配一个或多个词，符号“*”匹配不多不少一个词。因此“log.#”能够匹配到“log.info.oa”，但是“log.*” 只会匹配到“log.error”
        /// </summary>
        public void TopicAcceptExchange()
        {
            using (IConnection conn = rabbitMqFactory.CreateConnection())
            {
                using (IModel channel = conn.CreateModel())
                {
                    channel.ExchangeDeclare(TopExchangeName, ExchangeType.Topic, durable: false, autoDelete: false, arguments: null);
                    channel.QueueDeclare(TopQueueName, durable: false, autoDelete: false, exclusive: false, arguments: null);
                    channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);
                    channel.QueueBind(TopQueueName, TopExchangeName, routingKey: TopQueueName);
                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) =>
                    {
                        var msgBody = Encoding.UTF8.GetString(ea.Body.ToArray());
                        this.listBox1.Items.Add(string.Format("***接收时间:{0}，消息内容：{1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), msgBody));
                        int dots = msgBody.Split('.').Length - 1;
                        System.Threading.Thread.Sleep(dots * 1000);
                        this.listBox1.Items.Add(" [x] Done");
                        channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
                    };
                    channel.BasicConsume(TopQueueName, false, consumer: consumer);

                    this.listBox1.Items.Add("按任意值，退出程序");
                }
            }
        }
    }
}
