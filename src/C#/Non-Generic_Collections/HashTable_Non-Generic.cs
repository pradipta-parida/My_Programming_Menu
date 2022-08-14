using system;
using system.Collections;
namespace NonGenericHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            In Hashtable, insert the data on one above the other just like a stack
            */
            Hashtable menu = new Hashtable();
            menu.Add(1,"Soda");
            menu.Add(2,"Burger");
            menu.Add(3,"Fries");
            menu.Add(4,"Onion Rings");

            foreach (DictionaryEntry h in menu) // foreach loop starts
            {
                Console.WriteLine(h.key + "" + h.value); // 4 Onion rings --> 1 Soda
            }
        }
    }
}