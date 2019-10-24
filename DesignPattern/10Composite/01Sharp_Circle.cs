using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._10Composite
{
    class _01Sharp_Circle : _01Shape
    {
        private double _radius;

        public _01Sharp_Circle(string name, double radius) : base(name)
        {
            this._radius = radius;
        }

        public override double Area()
        {
            return Math.Round(Math.PI * _radius * _radius, 2);
        }

        public override void Display()
        {
            Console.WriteLine("{0} 半径：{1}，面积：{2}", _name, _radius, this.Area());
        }
    }
}
