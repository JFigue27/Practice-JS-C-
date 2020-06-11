using System;

namespace C_.practice1
{
    public class challenge7
    {
        public challenge7()
        {

        }

        public void Challenge7()
        {
            Console.WriteLine("Challenge 7");

            Console.WriteLine("User: Please enter your current age.");
            string currentAge = Console.ReadLine();

            int ageLastYear = int.Parse(currentAge) - 1;
            Console.WriteLine("User: This was your age last year = {0}", ageLastYear);
            int ageNextYear = int.Parse(currentAge) + 1;
            Console.WriteLine("User: This is your age for next year = {0}", ageNextYear);

        }
    }
}