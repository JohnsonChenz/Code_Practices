using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practice
{
    class Delegate_Simple
    {
        public delegate int Delegate_Test(string Number);

        public static int ReturnNumbers(string number)
        {
            int a = Int32.Parse(number);
            return a;
        }
        public static int ReturnNumbers_2(string number)
        {
            int a = Int32.Parse(number);
            return a * 2;
        }
        static void Main(string[] args)
        {
            Delegate_Test DT = WHATEVER =>
            {
                return -1;
            };
            string Condition = Console.ReadLine();
            switch(Condition)
            {
                case "C1":
                    DT = ReturnNumbers;
                    break;
                case "C2":
                    DT = ReturnNumbers_2;
                    break;
            }
            Console.WriteLine(DT("10"));
            Console.ReadKey();
        }

    }
}
