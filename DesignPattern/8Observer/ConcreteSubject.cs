using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._8Observer
{
    /// <summary>
    /// 具体的被观察对象，维持ConcreteSubject状态，当状态发生变化时，发送消息通知它的观察者
    /// </summary>
    class ConcreteSubject : _02Subject
    {
        private string _subjectState;

        public string SubjectState
        {
            get { return _subjectState; }
            set { _subjectState = value; }
        }
    }
}
