using System;
using System.Collections.Generic;
namespace GenericStack
{
    class Program
    {
        /*
        For stacks, we give only one value since stack has only one value one type of data in one time.
        so, we are giving string values to the stack  
        */
        static void Main(string[] args)
        {
            Stack<string> stk = new Stack<string>();
            stk.push("Rare");
            stk.push("Medium Rare");
            stk.push("Medium");
            stk.push("Well Done");
            //In this case, "Rare" will be at bottom and "Well Done" at top of the stack
            foreach(string s in stk) // "foreach" is a loop
            {
                console.writeline(s);
            }
        }
    }
}