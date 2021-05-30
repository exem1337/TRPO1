using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO1
{
    class Program
    {
        static void Main(string[] args)
        {
            funk();
        }
        static void funk()
        {
            Console.WriteLine("Введите число: "); int a;
            try
            {
                 a = Convert.ToInt32(Console.ReadLine());
                if (a < 1000000)
                {
                    Console.WriteLine(a.ToString("X"));
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели не число! / Вы ввели слишком большое число!");
                funk();
            }

            
        }
    }
}
