using DesignPattern._01SimpleFactory;
using DesignPattern._01SimpleFactory._02IPayment;
using DesignPattern._02AbstractFactory._01Kfcfood;
using DesignPattern._03Builder;
using DesignPattern._04FactoryMethod;
using DesignPattern._05Prototype;
using DesignPattern._06Singleton;
using DesignPattern._07Adapter;
using DesignPattern._8Observer;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 简单工厂模式
            Console.WriteLine("===========简单工厂模式============");
            //Practical01:运算操作,计算时，不依赖具体的运算类，通过OperationFactory获取真正的运算类
            Product_Operation operation01 = Factory_OperationFactory.CreateOperate(OPE.PLUS);
            operation01._NumA = 10;
            operation01._NumB = 5;
            Console.WriteLine(operation01.GetResult());
            Product_Operation operation02 = Factory_OperationFactory.CreateOperate(OPE.DIVIDE);
            operation02._NumA = 10;
            operation02._NumB = 5;
            Console.WriteLine(operation02.GetResult());

            //Parctical01:银行支付
            var payment = PaymentFactory.CreatePayment("ABC");
            Console.WriteLine(payment.Payfor(1));
            #endregion
            #region 抽象工厂模式
            Console.WriteLine("===========抽象工厂模式============");
            //便宜套餐
            Factory_Abstract_IKFCFactory Cheap_Abstract = new Factory_CheapPackage();
            KFCFood Cheap_food = Cheap_Abstract.CreateFood();
            Cheap_food.Display();
            KFCDrink Cheap_Drink = Cheap_Abstract.CreateDrink();
            Cheap_Drink.Display();
            //豪华套餐
            Factory_Abstract_IKFCFactory Luxury_Abstract = new Factory_LuxuryPackage();
            KFCFood Luxury_food = Luxury_Abstract.CreateFood();
            Luxury_food.Display();
            KFCDrink Luxury_Drink = Luxury_Abstract.CreateDrink();
            Luxury_Drink.Display();
            #endregion
            #region 建造者模式
            Console.WriteLine("===========建造者模式============");
            _02Builder_VehicleBuilder builder;
            _04Director_Shop shop = new _04Director_Shop();

            //产品1：Scooter
            builder = new _03ConcreteBuilder_ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            //产品2：
            builder = new _03ConcreteBuilder_CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            #endregion
            #region 工厂方法模式
            Console.WriteLine("===========工厂方法模式============");
            _01Factory_IKFC IKFCFactory = new _01Factory_IKFC_ChickenFactory();
            //生产鸡腿
            _02KFCFood f_1 = IKFCFactory.CreateFood();
            f_1.Display();
            //+1
            _02KFCFood f_2 = IKFCFactory.CreateFood();
            f_2.Display();
            _02KFCFood f_3 = IKFCFactory.CreateFood();
            f_3.Display();
            #endregion
            #region 原型模式
            Console.WriteLine("===========原型模式============");
            _03ColorManager colormanager = new _03ColorManager();

            colormanager["red"] = new _02Color(255, 0, 0);
            // 个性化对象
            colormanager["peace"] = new _02Color(128, 211, 128);
            //浅clone
            _02Color color1 = colormanager["red"].Clone() as _02Color;
            _02Color color2 = colormanager["peace"].Clone() as _02Color;
            #endregion
            #region 单例模式
            Console.WriteLine("===========单例模式============");
            //单线程环境
            Singleton01 s1 = Singleton01.Instance();
            Singleton01 s2 = Singleton01.Instance();
            if (s1 == s2)
            {
                Console.WriteLine("s1 == s2，单例模式");
            }
            #endregion
            #region 适配器模式
            Console.WriteLine("===========适配器模式============");
            Console.WriteLine("手机：");
            _01ITarget t = new Adapter(new _02Power());
            t.GetPower();
            #endregion
            #region 观察者模式
            Console.WriteLine("===========观察者模式============");
            ConcreteSubject concreteSubject = new ConcreteSubject();
            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "X"));
            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "Y"));
            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "Z"));
            //Subject通过Attach()和Detach()方法添加或删除其所关联的观察者，
            //并通过Notify进行更新，让每个观察者都可以观察到最新的状态
            concreteSubject.SubjectState = "ABC";
            concreteSubject.Notify();
            #endregion
            Console.Read();
        }
    }
}
