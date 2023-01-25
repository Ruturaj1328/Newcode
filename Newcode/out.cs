using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcode
{
    internal class Out
    {
        static void swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b=temp;
        }
        static void Calculation(int a,int b,out int sum,out int sub,out int mul)
        {
            sum = a + b;
            sub = a - b;
            mul = a * b;
        }

        static void Main(string[] args)
        {
            int a = 10, b = 20;
            swap(ref a,ref b);
            Console.WriteLine($"a={a}and b={b}");
            Calculation(a, b, out int sum, out int sub, out int mul);
            Console.WriteLine($"sum ={sum} sub = {sub} and mul={mul}");

        }
    }
}
