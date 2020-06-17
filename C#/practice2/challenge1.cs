using System;

namespace C_.practice2
{
    public class challenge1
    {
        public challenge1()
        {

        }

        public void Challenge_1()
        {
            Console.WriteLine("Challenge 1");
            Console.WriteLine("Enter a number please!");
            string num1 = Console.ReadLine();
            Console.WriteLine("Enter another number please!");
            string num2 = Console.ReadLine();

            double number1 = double.Parse(num1);
            double number2 = double.Parse(num2);

            if (number1 > number2)
            {

                var Total = number1 - number2;
                Console.WriteLine("This is the mayor number: {0} and this is the diference between them : {1}.", number1, Total);
            }
            else
            {
                var Total = number2 - number1;
                Console.WriteLine("This is the mayor number: {0} and this is the diference between them : {1}.", number2, Total);
            }
        }
    }
}