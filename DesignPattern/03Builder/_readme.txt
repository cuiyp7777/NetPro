建造者模式
将复杂的构建与其表示相分离，使得同样的构建过程可以创建不同的表示；

#意义
Builder:为创建一个Product对象的各个部件指定抽象接口
ConcreteBuilder:实现Builder的接口以构造和装配该产品的各个部件
Director：构造一个使用Builder接口的对象，规定了创建一个对象所需要的步骤和次序
Product：表示被构造的复杂对象

#实例：
车辆（Product）由框架、引擎、车辆、门等_parts构成；
不同的种类（ConcreteBuilder）MotorCycle、Car、Scooter，由不同的_parts构造组成；【它们需要一个abstract class,Builder】
不同种类的车辆的建造方法一致（Shop）；

Product：Vehicle（车辆）
Builder：VehicleBuilder（构造车辆各个_Parts指定的接口）
ConcreteBuilder：不同产品MotorCycleBuilder、CarBuilder、ScooterBuilder实现Builder
Director：Shop，创建一个产品对象需要的步骤【所有产品共用的步骤（方法）】
