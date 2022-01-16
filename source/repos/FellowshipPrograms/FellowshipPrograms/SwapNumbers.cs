using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowshipPrograms
{
    public class SwapNumbers
    {
        //Each word 1st letter has to start with Uppercase 
        //Pascal case
        //Pascal will follw for classroom and method name 
        public static void SwapingNumbers()
        {
            //came1 case for local variable and method parameters
            int firstNum, secondNum, temp = 0;
            Console.WriteLine("Enter First Number");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swaping: First Number is {0}, Second Number is {1}", firstNum, secondNum);
            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
            Console.WriteLine("Before swaing: First Number is {0}, Second Number is {1}", firstNum, secondNum);


        }
    }
}
