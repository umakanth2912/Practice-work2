using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverload
{

    public class Addition
    {
        public void Total(double A, double b)
        {


            double e = A + b;
            Console.WriteLine("The Addition of {0} and {1}:{2}",A,b,e);
        }
    }

    public class Multiplication
    {
        public void Total(double c, double d)
        {

            double e = c * d;
            Console.WriteLine("The Multiplication of {0} and {1}:{2}", c, d, e);
        }
    }
    public class Division
    {
        public void Total(double f, double g)
        {

            double e = f / g;
            Console.WriteLine("The Division of {0} and {1}:{2}", f, g, e);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            bool _continue = true;
            while (_continue)
            {
                Console.WriteLine("Please select the options below to which you would like to find out Total:\n 1.Addition \n 2.Multiplication \n 3.Division");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Addition Add = new Addition();
                        Console.WriteLine("You have selected Addition of Two numbers");
                        Console.WriteLine("Please enter the Value 1");
                        double value1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the Value 2");
                        double value2 = Convert.ToDouble(Console.ReadLine());
                        Add.Total(value1, value2);
                        _continue = false;
                        break;
                    case 2:
                        Multiplication mul = new Multiplication();
                        Console.WriteLine("You have selected Multiplication of Two numbers");
                        Console.WriteLine("Please enter the Value 1");
                        double value3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the Value 2");
                        double value4 = Convert.ToDouble(Console.ReadLine());
                        mul.Total(value3, value4);

                        _continue = false;
                        break;
                    case 3:
                        Division div = new Division();
                        Console.WriteLine("You have selected Division of Two numbers");
                        Console.WriteLine("Please enter the Value 1");
                        double value5 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the Value 2");
                        double value6 = Convert.ToDouble(Console.ReadLine());
                        div.Total(value5, value6);
                        _continue = false;
                        break;
                    default:
                        Console.WriteLine("Please enter the correct option");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
