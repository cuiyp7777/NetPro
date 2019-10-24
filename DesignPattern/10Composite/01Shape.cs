using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._10Composite
{
    abstract class _01Shape
    {
        protected string _name;

        public _01Shape(string name)
        {
            this._name = name;
        }

        /// <summary>
        /// 面积
        /// </summary>
        /// <returns></returns>
        public abstract double Area();

        /// <summary>
        /// 显示
        /// </summary>
        public abstract void Display();
    }
}
