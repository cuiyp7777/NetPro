using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._12Flyweight
{
    class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable();

        public FlyweightFactory()
        {
            flyweights.Add("X", new _01FlyweightConcrete());
            flyweights.Add("Y", new _01FlyweightConcrete());
            flyweights.Add("Z", new _01FlyweightConcrete());
        }

        public _01Flyweight GetFlyweight(string key)
        {
            return (_01Flyweight)flyweights[key];
        }
    }
}
