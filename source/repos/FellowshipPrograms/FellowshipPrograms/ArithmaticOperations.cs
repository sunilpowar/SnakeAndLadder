using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowshipPrograms
{
    public class ArithmaticOperations
    {
        public static void PerformArithmaticOpearations()
        {
            double addition, subtraction, multiplication, division, average;
            Console.WriteLine("Please Enter First Number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            addition = num1 + num2;
            subtraction = num1 - num2;
            multiplication = num1 * num2;
            division = num1 / num2;
            average = (num1 + num2) / 2;


            Console.WriteLine("Addition: {0}{1}{2}", num1 + "+", num2, "=" + addition);
            Console.WriteLine("Subration: {0}{1}{2}", num1 + "-", num2, "=" + subtraction);
            Console.WriteLine("Multiplication: {0}{1}{2}", num1 + "*", num2, "=" + multiplication);
            Console.WriteLine("Division: {0}{1}{2}", num1 + "*", num2, "/" + division);
            Console.WriteLine("Average: " + average);

        
        }
    }
}
