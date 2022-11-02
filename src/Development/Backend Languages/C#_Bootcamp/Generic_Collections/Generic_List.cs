using system;
using system.Collections.Generic;
namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            To initialize a list we use "List<int>" and name for the list "genlist" and "new" identifier to 
            start a new list.
            This is the basic syntax to create a list             
            */ 
            List<int> genlist = new List<int>();
            /*
            To add a list we use an add function 
            */
            genlist.Add(30);
            genlist.Add(60);
            genlist.Add(90);
            genlist.Add(120);  
            foreach (int x in genlist) // "foreach" is a loop
            {
                Console.WriteLine(x);
            }                                                
        }
    }
}
