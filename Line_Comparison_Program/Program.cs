using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4_Compare_Two_lines_Using_OOP 
{
    abstract class Comparision  // Creating Abstract Class
    {
        public abstract void lineComparision(double a , double b);  // Create Method for Abstract Class
    }
    class Line : Comparision    //inherite Comparison class
    {
        public double x1, y1, x2, y2 ;
        public void Input() 
        {
            Console.WriteLine("Please Enter x1 point Co-ordinate value: ");     // ask user to enter the value
            x1 = Convert.ToDouble(Console.ReadLine());   // Convert the string varible into double 
             Console.WriteLine("Please Enter y1 point Co-ordinate value: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter x2 point Co-ordinate value: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter y2 point Co-ordinate value: ");
            y2 = Convert.ToDouble(Console.ReadLine());
        }
        public double LineLengthComputation(double x1, double y1, double x2, double y2)     //Class method
        {
            double lengthOfTheLine= Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return lengthOfTheLine;
        }
        public override void lineComparision(double lineLength_1, double lineLength_2)  //Override Method for inherit class
        {
            Console.WriteLine("\n Comparision between two lines ");
            int result;
            Console.WriteLine("\nFirst line is Equal to Second line :");
            Console.WriteLine(lineLength_1.Equals(lineLength_2));
            result = lineLength_1.CompareTo(lineLength_2);
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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line Comparision Computation Program");
            Console.WriteLine("For First Line ");
            Line line_1 = new Line();     // object for line-1
            line_1.Input();
            double lineLength_1 = line_1.LineLengthComputation(line_1.x1, line_1.x2, line_1.y1, line_1.y2);
            Console.WriteLine(lineLength_1);
            Console.WriteLine("For Second Line");
            Line line_2 = new Line();
            line_2.Input();
            double lineLenth_2 = line_2.LineLengthComputation(line_2.x1, line_2.x2, line_2.y1, line_2.y2);
            Console.WriteLine(lineLenth_2);
            line_2.lineComparision(lineLength_1, lineLenth_2);
            Console.ReadLine();
        }
    }
}
