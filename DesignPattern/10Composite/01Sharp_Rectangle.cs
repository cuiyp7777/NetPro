using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._10Composite
{
    class _01Sharp_Rectangle : _01Shape
    {
        private double _width;
        private double _height;

        public _01Sharp_Rectangle(string name, double width, double height) : base(name)
        {
            _width = width;
            _height = height;
        }

        public override double Area()
        {
            return _width * _height;
        }

        public override void Display()
        {
            Console.WriteLine("{0} 长：{1}，宽：{2}，面积：{3}", _name, _width, _height, this.Area());
        }
    }
}
