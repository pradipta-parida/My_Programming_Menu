using system;
using system.Collections;
namespace NonGenericQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            In SortedList, we can have different datatypes.
            */
            Queue ngenq = new Queue();
            ngenq.Enqueue("Mark");
            ngenq.Enqueue("Bill");
            ngenq.Enqueue("Xavier");
            ngenq.Enqueue("Michael");
 
            foreach (object o in ngenq) // foreach loop starts
            {
                Console.WriteLine(o); // Mark --> Michael
            }
        }
    }
}