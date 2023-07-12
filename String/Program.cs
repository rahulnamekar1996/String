using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("hello all");
            Console.WriteLine(sb);
            Console.WriteLine(sb.GetHashCode());

            sb.Append("good evenning");
            Console.WriteLine(sb);
            Console.WriteLine(sb.GetHashCode());

            sb.Insert(5, "TEST DATA");
            sb.Remove(5, 4);

            sb.Replace("DATA", "NEW DATA");
            Console.WriteLine(sb);

            StringBuilder sb3 = new StringBuilder("you amount is");
            sb.AppendFormat("{0:C}", 25000);
            Console.WriteLine(sb3);


        }
    }
}
