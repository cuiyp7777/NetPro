享元模式 Flyweight
 避免大量拥有相同内容的小类的开销（如内存开销），使大家共享一个类

 参与者：
 Flyweight：声明一个接口，通过这个接口flyweight可以直接接收并作用于外部状态。
 ConcreteFlyweight：实现Flyweight接口，并为内部状态增加存储空间。
                    ConcreteFlyweight对象必须是可以共享的，
					它所存储的状态必须是内部的，即它必须独立于ConcreteFlyweight对象的场景。
UnsharedConcreteFlyweight：并非所有的Flyweight子类都需要被共享。
FlyweightFactory：
 创建和管理flyweight对象。
 确保flyweight对象被合理共享。当Client请求一个flyweight对象时，
 FlyweightFactory需要可以进行分配，若flyweight对象不存在时，则先创建一个。

 #
 在享元模式中，Client调用Flyweight下的ConcreteFlyweight，
 如果ConcreteFlyweight存在则调用成功；
 否则就调用FlyweightFactory生产所需要的继承Flyweight接口的ConcreteFlyweight，以供调用。