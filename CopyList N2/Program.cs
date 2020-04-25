using System;
using System.Collections.Generic;

namespace CopyList_N2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MyList> N1 = new List<MyList>();
            N1.Add(new MyList(1));
            N1.Add(new MyList(2));
            N1.Add(new MyList(3));

            List<MyList> N2 = new List<MyList>();
            foreach (var item in N1)
            {
                N2.Add(item);
            }

            foreach (var item in N2)
            {
                Console.WriteLine(item.number);
            }
                
        }
    }
}
