using System;
using System.Collections.Generic;
namespace GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            To initialize a dictionary we use keyword "Dictionary<int, string>" and in angular bracket 
            we define both the parts of dictionary-one is key and one is value , then we have dictionary 
            name "dict", then we agin use "new" keyword to finally start this dictionary.

            This is the basic syntax to create a dictionary.                        
            */ 
            Dictionary<int, string> dict =  new Dictionary<int, string>();
            dict.Add(1,"Soda");
            dict.Add(2,"Burger");
            dict.Add(3,"Fries");
            dict.Add(4,"Onion Rings");
            /*
            we are asking key value pair and naming as "kvp".
            */
            foreach(KeyValuePair<int, string> kvp in dict) // "foreach" is a loop
            {
                console.writeline(kvp.key+ ""+kvp.value);
            }
        }
    }
}