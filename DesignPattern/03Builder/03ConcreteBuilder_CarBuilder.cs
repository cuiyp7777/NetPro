using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._03Builder
{
    /// <summary>
    /// 实现Builder的接口以构造和装配该产品的各个部件
    /// </summary>
    class _03ConcreteBuilder_CarBuilder : _02Builder_VehicleBuilder
    {
        public _03ConcreteBuilder_CarBuilder()
        {
            this._vehicle = new _01Product_Vehicle("建构汽车");
        }
        public override void BuildFrame()
        {
            _vehicle["frame"] = "Car Frame";
        }

        public override void BuildEngine()
        {
            _vehicle["engine"] = "2500 cc";
        }

        public override void BuildWheels()
        {
            _vehicle["wheels"] = "4";
        }

        public override void BuildDoors()
        {
            _vehicle["doors"] = "4";
        }
    }
}
