using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line Comparision Computation Program");
            double x1 , y1 , x2 , y2 ;      // inititate the varible type and varible

            Console.WriteLine("Please Enter x1 point Co-ordinate value: ");     // ask user to enter the value
            x1 = Convert.ToDouble(Console.ReadLine());   // Convert the string varible into double 

            Console.WriteLine("Please Enter y1 point Co-ordinate value: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter x2 point Co-ordinate value: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter y2 point Co-ordinate value: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            //formula for finding lenth of the line using Cartesian System
           double lengthOfTheLine = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Length of the line using 2 points: " + lengthOfTheLine);

        }
    }
}
