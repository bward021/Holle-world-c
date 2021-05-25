using System;

namespace Hello_world_c
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 10;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.537;
            double sumDouble = d1 + d2;

            float f1 = 3.5f;
            float f2 = 1.537f;

            string myName = "Brandon";

            string lowerCaseName = myName.ToUpper();

            string boom = "BOOOOOOOOM";

            string lower = boom.ToLower();


            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is equal to " + sum);
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is equal to " + sumDouble);
            Console.WriteLine("My name is " + lowerCaseName);

        }
    }
}
