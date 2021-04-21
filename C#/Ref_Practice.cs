using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practice
{
    class Ref_Practice
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            Ref_Test(ref num);
            Console.WriteLine(num);
            Console.ReadKey();
        }

        static void Ref_Test(ref int a)
        {
            a += 10;
        }
    }
}
