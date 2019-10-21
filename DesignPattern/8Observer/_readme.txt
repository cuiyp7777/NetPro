观察者模式 Observer
 需要为某些对象建立一种“通知依赖关系”，即一个对象的状态发生改变，所有的依赖对象都需要得到通知。
 定义对象间的一种一对多的依赖关系，当一个对象的状态发生改变时，所有依赖于它的对象都得到通知并被自动更新。

◊ Subject

　　　　° 抽象的主题，被观察的对象

　　　　° 提供Attach和Detach Observer对象的接口

　　◊ ConcreteSubject

　　　　° 具体的被观察对象，维持ConcreteSubject状态。

　　　　° 当状态发生变化时，发送消息通知它的观察者。

　　◊ Observer：抽象的观察者，定义一个发送变化通知更新的接口。

　　◊ ConcreteObserver

　　　　° 维持一个对ConcreteSubject对象的引用

　　　　° 保存subjects状态

　　　　° 实现当Observer接口发生变动时，subjects状态同步更新。

 　　在观察者模式中，Subject通过Attach()和Detach()方法添加或删除其所关联的观察者，
       并通过Notify进行更新，让每个观察者都可以观察到最新的状态。