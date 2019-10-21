using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._8Observer
{
    class _02Subject
    {
        public List<_01Observer> _observers = new List<_01Observer>();

        public void Attach(_01Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(_01Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (_01Observer o in _observers)
            {
                o.Update();
            }
        }

    }
}
