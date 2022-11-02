using System;
using System.Collections.Generic;
namespace GenericSortedList
{
    class Program
    {
        /*
        For sorted_list we have key-value pair. To make it look different we have added both strings.
        */
        static void Main(string[] args)
        {
            SortedList<string, string> slist = new SortedList<string, string>();
            slist.Add("American","Burger");
            slist.Add("Lime","Soda");
            slist.Add("French","Fries");
            slist.Add("Onion","Rings");
            foreach(KeyValuePair<string, string> kvp in slist) // "foreach" is a loop
            {
                console.writeline(kvp.key+ ""+kvp.value);
            }
        }
    }
}