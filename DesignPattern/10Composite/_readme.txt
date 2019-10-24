组合模式 Composite
组合模式主要用来处理一类具有“容器特征”的对象——即它们在充当对象的同时，又可以作为容器包含其他多个对象。

意义：
Component：
  声明组合对象的接口；
  实现全部类中公共接口的默认行为；
  声明访问和管理子类的接口；
Leaf：
 表示在组合对象中叶子节点对象；
 定义组合对象中的初始行为；
Composite：
 定义Component子类的行为；
 保存Component子类；
 实现Component接口的子类关联操作；

 Client：通过Component接口组合的多个对象；