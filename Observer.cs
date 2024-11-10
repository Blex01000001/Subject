using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject
{
    public class Observer<T>
    {
        public string name;
        public T content;
        public Action<T> _callback;
        public Observer(string str, Action<T> callback)
        {
            this.name = str;
            this._callback = callback;
        }
        public void Next(T content)
        {
            //Console.WriteLine($"{name} num: {content}");
            _callback.Invoke(content);
        }
        public void Error(string ErrorMessage)
        {
            Console.WriteLine($"An error: {ErrorMessage}");
        }
        public void Complete()
        {

            Console.WriteLine($"{name} complete");
        }
    }
}
