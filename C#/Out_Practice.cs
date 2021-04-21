using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practice
{

    class Out_Practice
    {
        class Str
        {
            public string str = "";
        }

        /// <summary>
        /// Out方法
        /// </summary>
        /// <param name="a"></param>
        static void Out_Test_1(string x ,out Str obj)
        {
            obj = new Str();
            obj.str = x + "OUT";
        }

        static void Out_Test_2(int x,out int Num)
        {
            Num = x * 2;
        }
        static void Main()
        {
            string test_str = Console.ReadLine();
            Str a;
            Out_Test_1(test_str, out a);
            Console.WriteLine(a.str);

            int num;
            int test_num = Int32.Parse(Console.ReadLine());
            Out_Test_2(test_num, out num);
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
