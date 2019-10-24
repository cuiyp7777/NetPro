using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._10Composite
{
    class Graphics : _01Shape
    {
        private List<_01Shape> _children = new List<_01Shape>();
        public Graphics(string name)
            : base(name)
        { }
        public void Add(_01Shape child)
        {
            _children.Add(child);
        }

        public void Remove(_01Shape child)
        {
            _children.Remove(child);
        }
        public override double Area()
        {
            double sum = 0;
            foreach (_01Shape child in _children)
            {
                sum += child.Area();
            }
            return sum;
        }

        public override void Display()
        {
            foreach (_01Shape child in _children)
            {
                child.Display();
            }

            Console.WriteLine("{0} 总面积：{1}", _name, this.Area());
        }
    }
}
