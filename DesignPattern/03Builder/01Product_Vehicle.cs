using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._03Builder
{
    /// <summary>
    /// 表示被构造的复杂对象:车辆
    /// </summary>
    class _01Product_Vehicle
    {
        //车辆车辆
        public string _vehicleType;
        public _01Product_Vehicle(string vehicleType)
        {
            this._vehicleType = vehicleType;
        }
        //车辆组件
        public Dictionary<string, string> _parts = new Dictionary<string, string>();

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine(" Frame : {0}", _parts["frame"]);
            Console.WriteLine(" Engine : {0}", _parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", _parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", _parts["doors"]);
        }
    }
}
