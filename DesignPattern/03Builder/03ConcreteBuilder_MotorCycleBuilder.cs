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
    class _03ConcreteBuilder_MotorCycleBuilder : _02Builder_VehicleBuilder
    {
        public _03ConcreteBuilder_MotorCycleBuilder()
        {
            this._vehicle = new _01Product_Vehicle("MotorCycle");
        }
        public override void BuildFrame()
        {
            _vehicle["frame"] = "MotorCycle Frame";
        }

        public override void BuildEngine()
        {
            _vehicle["engine"] = "500 cc";
        }

        public override void BuildWheels()
        {
            _vehicle["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            _vehicle["doors"] = "0";
        }
    }
}
