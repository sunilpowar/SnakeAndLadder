using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowshipPrograms
{
    public class ReverseNumbaer
    {
        public static void FindReverseNumber()
        {

            int remainder, reverse = 0;
            Console.WriteLine("Please Enter Number to reverse");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number /= 10;
            }
            Console.WriteLine("After reverse: + reverse");
            Console.ReadLine();
        }
    }
}
