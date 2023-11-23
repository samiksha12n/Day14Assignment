using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLibDay14Assignment;

namespace Day14assignmentLinkedSharedLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the shape of object to find its Area");
            Console.WriteLine("1.Square 2.Rectangle 3.Triangle 4.Circle");
            int op=int.Parse(Console.ReadLine());
            SharedLib area=new SharedLib();
            switch(op)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the side length of the square");
                        double len=double.Parse(Console.ReadLine());
                        Console.WriteLine($"Area of Square for entered length {len} is: {area.Square(len)} ");
                        break;
                    } 
                case 2:
                    {
                        Console.WriteLine("Enter the length of the rectangle");
                        double len = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter width of rectangle");
                        double wid=double.Parse(Console.ReadLine());
                        Console.WriteLine($"Area of rectangle for entered length {len} and width {wid} is: {area.Rectangle(len, wid)}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter the base of the triangle");
                        double ba = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter heigth of triangle");
                        double ht = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Area of triangle for entered base {ba} and height {ht} is: {area.Triangle(ba, ht)}");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter the radius of the circle");
                        double re = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Area of rectangle for entered radius {re} is: {area.Circle(re)}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid choice!!!");
                        break;
                    }

            }
            Console.ReadKey();
        }
    }
}
