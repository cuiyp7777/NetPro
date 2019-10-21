工厂方法模式：FactoryMethod
工厂模式定义一个用于创建对接的接口，让子类决定实例化哪一个类；
用于不指定等创建对象的具体类的情况下创建对象；
Client通常不指定要创建的具体类，Client将面向接口或抽象类进行编码，让Factory类负责创建具体的类型。通常Factory类有一个返回抽象类或者接口的静态方法

#意义：
Product:定义工厂方法所创建的对象的接口；
ConcreteProduct:具体Product角色；
Factory：抽象的工厂角色，声明工厂方法，返回【Product】类型的对象；
ConcreteFactory：创建具体的Product的子工厂；

#实例：
KFC提供各种产品（Product），比如鸡翅、鸡腿等（ConcreteProduct）；
顾客每要求一种食品，都可以快速的生产；

好处：
1、客户在创建产品时只需指定一下子工厂，无需了解子工厂具体创建什么产品；
2、需求变动时，如：f_1/2/3均改为“鸡翅”时，只需要将
   _04FactoryMethod.IKFCFactory IKFCFactory = new _04FactoryMethod.ChickenFactory();
   修改为 
   _04FactoryMethod.IKFCFactory IKFCFactory = new _04FactoryMethod.WingsFactory();
3、核心的工厂类不是负责所有产品的创建，而是将具体的创建工作交给子类ConcreteFactory去做

   【如现在要增加一种新的产品“薯条”，则无需修改原有代码，只需增加一个“薯条”产品类和一个相应的“薯条”子工厂即可。】
   在工厂方法模式中，子工厂与产品类往往具有平行的等级结构，它们之间一一对应。

