using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int No1 = 0, No2 = 0, Res = 0;
            Console.Write("\n Enter First No => ");
            No1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter Second No => ");
            No2 = Convert.ToInt32(Console.ReadLine());

            Res = No1 - No2;

            Console.Write("\n Substraction is " + No1 + " & " + No2 + " is " + Res);

            Console.ReadKey();
        }
    }
}
