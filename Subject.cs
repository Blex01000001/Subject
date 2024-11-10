using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject
{
    public class Subject<T>
    {
        private  List<Observer<T>> ObserverList = new List<Observer<T>>();
        
        public Subject()
        {
            
        }
        public  void Update(T content)
        {
            foreach (Observer<T> observer in ObserverList)
            {
                observer.Next(content);
            }
        }
        public Subscription<T> Add(string str, Action<T> callback)
        {
            Observer<T> observer = new Observer<T>(str, callback);
            Subscription<T> subscription = new Subscription<T>(observer, this);
            ObserverList.Add(observer);
            return subscription;
        }

        internal void Remove(Observer<T> observer)
        {
            ObserverList.Remove(observer);
        } 
        public  void Complete()
        {
            foreach (Observer<T> observer in ObserverList)
            {
                observer.Complete();
            }
            ObserverList.Clear();
        }
    }
}
