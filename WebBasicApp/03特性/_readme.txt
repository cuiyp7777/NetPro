定义一个特性的本质就是定义一个继承自System.Attribute类的类型
申明式编程方式。
所谓申明式编程方式就是指程序员只需要申明某个模块会有怎样的特性，而无需关心如何去实现。

特性在被编译器编译时，和传统的命令式代码不同，
  它会被以二进制数据的方式写入模块文件的元数据之中，而在运行时再被解读使用。
特性也是经常被反射机制应用的元素，因为它本身是以元数据的形式存放的。

一般情况下，自定义特性都会被限制适用范围，我们也应该养成这样的习惯，为自己设计的特性加上AttributeUsage特性，
  很少会出现使用在所有元素上的特性。
即便是可以使用在所有元素上，也应该显式地申明[AttributeUsage(AttributesTargets.All)]来提高代码的可读性。

自定义特性被申明为sealed表示不可继承，
  这是因为在特性被检查时，无法分别制定特性和其派生特性，这一点需要我们注意。

    /// <summary>
    /// 一个自定义特性MyCustomAttribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]

	当一个特性申明了AttributeUsage特性并且显式地将AllowMultiple属性设置为true时，
	                                              该特性就可以在同一元素上多次申明，否则的话编译器将报错。