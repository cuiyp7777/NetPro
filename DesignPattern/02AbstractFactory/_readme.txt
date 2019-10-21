抽象工厂模式：
可以向客户提供一个接口，客户在不必指定产品具体类型的情况下，创建多个产品家族中的产品对象；
它强调的是“系列对象”变化；【即多个产品对象】

#意义
1、AbstractProduct：声明一类产品对象接口
2、Product
  定义一个被相应具体工厂创建的产品对象
  实现AbstractProduct接口
3、AbstractFactory：声明一个创建抽象产品对象的操作接口
4、ConcreteFactory：实现创建具体产品对象的操作
5、Client：使用AbstractFactory和AbstractProduct类声明的接口

#实际意义
在抽象工厂模式中，产品的创建由ConcreteFactory来完成，
抽象工厂模式的ConcreteFactory不是负责一种具体Product的创建，而是负责一个Product族的创建。

#实例：
KFC的产品可以相互独立，也可以进行套餐出现；
例：
 食品Food（AbstractProduct）和饮料Drink（AbstractProduct）可以构成一个产品族（即一个系列相似对象的抽象）；
 1、经济型（ConcreteFactory）：鸡翅、可乐
 2、豪华型（ConcreteFactory）：鸡腿、咖啡
 用户client只需要套餐名即可获取相应的Food和Drink（即产品）；
