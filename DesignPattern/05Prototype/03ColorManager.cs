using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._05Prototype
{
    class _03ColorManager
    {
        private Dictionary<string, _01ColorPrototype> _colors = new Dictionary<string, _01ColorPrototype>();

        public _01ColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}
