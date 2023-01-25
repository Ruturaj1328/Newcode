using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcode
{
    public class Referance
    {
        static void swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b=temp;
        }

        static void Main(string[] args)
        {
            int a = 10, b = 20;
            swap(ref a,ref b);
            Console.WriteLine( $"value of a ={a} and value of b={b}");
        }
    }
}
