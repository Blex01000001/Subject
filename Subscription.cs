using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject
{
    public class Subscription<T>
    {
        Observer<T> observer = null;
        Subject<T> subject = null;
        public Subscription(Observer<T> observer, Subject<T> subject) { 
            this.observer = observer;
            this.subject = subject;
        }
        public void UnSubscribe()
        {
            this.subject.Remove(observer);
        }
    }
}
