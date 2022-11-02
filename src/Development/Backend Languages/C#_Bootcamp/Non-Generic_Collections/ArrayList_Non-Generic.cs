using system;
using system.Collections;
namespace NonGenericArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            To declare an ArrayList we use "ArrayList" keyword, then we give it the name "al" then we have "new" 
            keyword then ArrayList.
            Unlike, generic list we are not giving any kind of data type. so, basically allowing us to use
            different kind of data types       
            */
            ArrayList al = new ArrayList();
            string str =  "Like, Share, Subscribe";
            int x = 11;
            DateTime d = DateTime.Parse("30-Dec-1998");// parse is used to convert dec-->12
            al.Add(str);
            al.Add(x);
            al.Add(d);

            foreach (object o in al) // foreach loop starts
            {
                Console.WriteLine(o);
            }
        }
    }
}