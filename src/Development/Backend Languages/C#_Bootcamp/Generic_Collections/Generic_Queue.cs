using System;
using System.Collections.Generic;
namespace GenericQueue
{
    class Program
    {
        /*
        For Queue, it is also using one type of variable, so we are using string here  
        */
        static void Main(string[] args)
        {
            Queue<string> genq = new Queue<string>();
            genq.Enqueue("Mark"); // To add new data we add Enqueue()
            genq.Enqueue("Bill");
            genq.Enqueue("Xavier");
            genq.Enqueue("Michael");
            //In this case, "Mark" will be at start and "Michael" at last of the queue
            foreach (string s in genq) // "foreach" is a loop
            {
                Console.WriteLine(s);
            }
        }
    }

}