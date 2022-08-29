using system;
using system.Collections;
namespace NonGenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            In SortedList, we can have different datatypes.
            */
            Stack staek = new Stack();
            steak.Push("Rare");
            steak.Push("Medium Rare");
            steak.Push("Medium");
            steak.Push("Well done");
 
            foreach (object o in steak) // foreach loop starts
            {
                Console.WriteLine(o); // Well done --> Rare
            }
        }
    }
}