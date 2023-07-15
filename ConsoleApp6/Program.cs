using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int result = 0;
            int rem;

            Console.Write("enter number for reverse: ");
            num = Int32.Parse(Console.ReadLine());

            while (num!=0)
            {
                rem = num % 10;
                result = result * 10 + rem;
                num = num / 10;

            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
