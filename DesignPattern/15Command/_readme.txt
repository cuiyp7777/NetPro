命令模式 Command
 目的解除命令发出者和接收者之间的紧密耦合关系。
 将请求封装为一个对象，将其作为命令的发起者和接收者的中介，
 而抽象出来的命令对象又使得能够对一系列请求进行操作，
 如对请求进行排队，记录请求日志以及支持可撤销的操作等。

 #参与者
 Command：命令抽象类，声明一个执行操作的接口Execute，
          该抽象类并不实现这个接口，所有的具体命令都继承自命令抽象类。
ConcreteCommand：定义一个接收者对象与动作之间的请求绑定，定义一个接收者对象与动作之间的请求绑定。
Invoker：命令的接收者，将命令请求传递给相应的命令对象，每个ConcreteCommand都是一个Invoker的成员。
Receiver：命令的接收者，知道如何实施与执行一个请求相关的操作
Client：客户端程序，创建一个具体命令对象并设定它的接收者

Command对象作为Invoker的一个属性，
  当点击事件发生时，Invoker调用方法Invoke()将请求发送给ConcreteCommand，
     再由ConcreteCommand调用Execute()将请求发送给Receiver，
  Client负责创建所有的角色，并设定Command与Invoker和Receiver之间的绑定关系。