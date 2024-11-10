using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Channel , User , News
            Subject<string> SubjectT = new Subject<string>("");
            var subscription = SubjectT.Add("A", x => Console.WriteLine($"callback Action {x}"));
            SubjectT.Add("B", x => Console.WriteLine("callback Action 6666"));
            SubjectT.Add("C", x => Console.WriteLine("callback Action end"));

            SubjectT.Update("NEWS");
            SubjectT.Add("D", x => Console.WriteLine("callback Action DDDD"));
            SubjectT.Update("2");
            SubjectT.Add("E", x => Console.WriteLine("callback Action EEEE"));

            SubjectT.Update("YT");

            SubjectT.Complete();




            subscription.UnSubscribe();




            Console.ReadLine();
        }
    }
}
