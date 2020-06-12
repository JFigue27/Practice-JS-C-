using System;

namespace C_.practice1
{
    public class challenge8
    {
        public challenge8()
        {

        }

        public void Challenge_8()
        {
            Console.WriteLine("Challenge 8");
            Console.WriteLine("Waiter, the bill please.");
            string bill = Console.ReadLine();
            double Bill = double.Parse(bill);
            Console.WriteLine("How many are we are?");
            string persons = Console.ReadLine();
            int Persons = int.Parse(persons);
            Console.WriteLine("Guys, what's the percent for the tip?");
            string tipPercent = Console.ReadLine();
            double TipPercent = double.Parse(tipPercent);

            double taxesPercent = 0.16;
            Console.WriteLine("Taxes % {0}", taxesPercent);

            var totalTip = Bill * TipPercent;
            Console.WriteLine("Tip $ {0}", totalTip);
            var totalTaxes = Bill * taxesPercent;
            Console.WriteLine("Taxes $ {0}", totalTaxes);

            var TotalBill = Bill + totalTip + totalTaxes;
            Console.WriteLine("Account total, included tip and taxes: $ {0}", TotalBill);
            var TotalByPerson = TotalBill / Persons;
            Console.WriteLine("Account total by person, included tip and taxes: $ {0}", TotalByPerson);



        }
    }
}