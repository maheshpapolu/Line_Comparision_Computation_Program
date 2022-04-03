using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Equality_of_Two_Lines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line Comparision Computation Program");
            double x1 , y1 , x2 , y2;  // inititate the varible type and varible
            double a1, a2, b1, b2;

            Console.WriteLine("Please Enter x1 point Co-ordinate value: ");     // ask user to enter the value
            x1 = Convert.ToDouble(Console.ReadLine());   // Convert the string varible into double 

            Console.WriteLine("Please Enter y1 point Co-ordinate value: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter x2 point Co-ordinate value: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter y2 point Co-ordinate value: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            //formula for finding lenth of the line using Cartesian System
           double lengthOfTheLine_1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Length of the line using 2 points: " + lengthOfTheLine_1);

           

            Console.WriteLine("Please Enter a1 point Co-ordinate value: ");     
            a1 = Convert.ToDouble(Console.ReadLine());  

            Console.WriteLine("Please Enter b1 point Co-ordinate value: ");
            b1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter a2 point Co-ordinate value: ");
            a2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter b2 point Co-ordinate value: ");
            b2 = Convert.ToDouble(Console.ReadLine());

            //formula for finding lenth of the line using Cartesian System
            double lengthOfTheLine_2 = Math.Sqrt((a2 - a1) * (a2 - a1) + (b2 - b1) * (b2 - b1));
            Console.WriteLine("Length of the line using 2 points: " + lengthOfTheLine_2);
            Console.WriteLine("\nComparing Two Lines\n");
            int result = lengthOfTheLine_1.CompareTo(lengthOfTheLine_2);
            if (result > 0) 
            {
                Console.WriteLine("First line is greater than second line");
            }
            else if (result < 0) 
            {
                Console.WriteLine("First line is Smaller than second line");
            }
            else
            {
                Console.WriteLine("Both lines are equal");
            }
        

        }
    }
}
