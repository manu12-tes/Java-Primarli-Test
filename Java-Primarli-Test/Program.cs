using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_Primarli_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EScribe un numero");
            int n = Int32.Parse(Console.ReadLine());

            if (n%1==0 && n % n == 0) { Console.WriteLine("Primo"); }
            else { Console.WriteLine("No es Primo"); }
        }
    }
}
