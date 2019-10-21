using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._03Builder
{
    /// <summary>
    /// 为创建一个Product对象的各个部件指定抽象接口:构造车辆各个_Parts指定的接口
    /// </summary>
    abstract class _02Builder_VehicleBuilder
    {
        //创建对象
        protected _01Product_Vehicle _vehicle;

        public _01Product_Vehicle Vehicle
        {
            get { return _vehicle; }
        }

        // 抽象Build方法
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
