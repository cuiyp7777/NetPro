﻿适配器模式：
通过一个类的接口转换成客户希望的另外一个接口，使原本由于接口不兼容而不能一起工作的那些类可以一起工作。
两种方式：
（1）类适配器：Target只能是接口
（2）对象适配器：Target可以是抽象类，也可以是接口；

参与者
（1）Target:Client所使用的目标接口，可能是接口或抽象类；
（2）Adaptee：需要适配的类接口
（3）Adapter：适配器，负责Adaptee与Target接口进行适配；
（4）Client：与Target的接口的对象协调的类；