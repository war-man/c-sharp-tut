using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace CSharpTut
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to Elementary School");
            } else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to Middle School");
            } else if ((age > 13) && (age < 19))
            {
                Console.WriteLine("Go to High School");
            } else
            {
                Console.WriteLine("Go to College");
            }

            if ((age < 14) || (age < 19))
            {
                Console.WriteLine("You shouldn't work");
            }

            Console.WriteLine("! true = " + (!true));

            bool canDrive = age >= 16 ? true : false;

            switch (age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to Day Care");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Go to Preschool");
                    break;
                case 5:
                    Console.WriteLine("Go to Kindergarten");
                    break;
                default:
                    Console.WriteLine("Go to another school");
                    goto OtherSchool;
            }

            OtherSchool:
                Console.WriteLine("Elementary, Middle, High School");

            string name = "Derek";

            string name2 = "Derek";

            if (name.Equals(name2, StringComparison.Ordinal))
            {
                Console.WriteLine("Names are Equal");
            }

            int i = 1;

            while (i <= 10)
            {
                if (i % 2 == 0) {
                    i++;
                    continue;
                }

                if (i == 9) break;

                Console.WriteLine(i);

                i++;
            }

            Random rnd = new Random();

            int secretNumber = rnd.Next(1, 11);

            int numberGuessed = 0;

            do
            {
                Console.WriteLine("Enter a number between 1 & 10");
                numberGuessed = Convert.ToInt32(Console.ReadLine());
            } while (secretNumber != numberGuessed);

            // Other Convert options: ToBoolean, ToByte,
            // ToChar, ToDecimal, ToDouble, ToInt64,
            // ToString, and they can convert from any
            // type to any other type

            double num1 = 5;

            double num2 = 0;

            try
            {
                Console.WriteLine("5 / 0 = {0}", DoDivision(num1, num2));
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero");

                Console.WriteLine(ex.GetType().Name);

                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Cleaning Up");
            }
        }

        static double DoDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }
    }
}
