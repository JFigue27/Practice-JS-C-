using System;

namespace C_.practice1
{
    public class retos6_11
    {
        public retos6_11()
        {

        }

        public void reto6()
        {
            Console.WriteLine("Tell me how many slices of pizza do we have");
            string Xslices = Console.ReadLine();
            Console.WriteLine("After some time ago, how mamy pizza do we consume?");
            string Yslices = Console.ReadLine();

            decimal Zslices = decimal.Parse(Xslices) - decimal.Parse(Yslices);

            Console.WriteLine("This is the total of silces pizzas: {0}", Zslices);



        }

    }
}