using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Takrorlash
{
    internal static class Working_with_numbers
    {
        public static int Pow(int a, int b)
        {
            int son=1;
            for (int i=0; i<b; i++)
            {
                son *= a;
            }
            return son;
        }
        public static bool Fibonachi(int a)
        {
            if (a == 0 || a==1)
            {
                return true;
            }
            int f1=0, f2=1;
            int f=f1+f2;
            while (f<a)
            {
                f1 = f2;
                f2 = f;
                f = f1 + f2;               
            }
            return a == f;
        }
        public static void Print(double a)
        {
            Console.WriteLine($"{a} is double");
        }
    }
}
