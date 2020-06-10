using System;


namespace C.practice1
{
    public class retos1_5
    {
        public retos1_5()
        {

        }

        public void Resto1_5()
        {
            Console.WriteLine("Hello, plase enter your first name. ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Hello, plase enter your last name. ");
            string lastName = Console.ReadLine();
            // Console.WriteLine(firstName);
            // Console.WriteLine(lastName);
            // Console.WriteLine("Hello World!");
            Console.WriteLine("Hello " + firstName + " " + lastName);

            Console.WriteLine("===========================");
            Console.WriteLine("Platzi cuenta con cursos de:");

            string[] categories = new string[7]
                    {
                        "Comedy","Drama","Action|Comedy|Drama",
                        "Action|Comedy|Horror|Musical","Animation|Children",
                        "Action|Adventure|Thriller|War","Action|Fantasy|Sci-Fi"
                    };
            foreach (var item in categories)
            {
                Console.WriteLine("Categoría " + item);
            }

            Console.WriteLine("============================");
            Console.WriteLine("Suma de enteros:");
            Console.WriteLine("Please enter your first number:");
            string num1 = Console.ReadLine();
            double numero1 = double.Parse(num1);
            Console.WriteLine("Please enter your second number:");
            string num2 = Console.ReadLine();
            double numero2 = double.Parse(num2);
            // Console.ReadLine();

            var result = numero1 + numero2;
            Console.WriteLine(result);

            Console.WriteLine("============================");
            Console.WriteLine("Please enter first number to sum:");
            string n1 = Console.ReadLine();
            decimal nu1 = decimal.Parse(n1);
            Console.WriteLine("Please enter second number to sum:");
            string n2 = Console.ReadLine();
            decimal nu2 = decimal.Parse(n2);
            Console.WriteLine("Please enter third number to multiplicated:");
            string n3 = Console.ReadLine();
            decimal nu3 = decimal.Parse(n3);
            decimal resultSum = nu1 + nu2;
            decimal resultMulti = Math.Round((resultSum * nu3), 2);

            Console.WriteLine("This is the result of the multiplication: " + resultMulti);



            Console.WriteLine("-");
        }
    }
}