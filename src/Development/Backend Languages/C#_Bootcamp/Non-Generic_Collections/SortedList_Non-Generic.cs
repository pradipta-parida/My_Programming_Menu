using system;
using system.Collections;
namespace NonGenericSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            In SortedList, we can have different datatypes.
            */
            SortedList ngslist = new SortedList();
            ngslist.Add("American","Soda");
            ngslist.Add("Lime","Soda");
            ngslist.Add("French","Fries");
            ngslist.Add("Onion", "Rings");
 
            foreach (DictionaryEntry d in ngslist) // foreach loop starts
            {
                Console.WriteLine(d.key + "" + d.value); // American Soda --> Onion Rings
            }
        }
    }
}