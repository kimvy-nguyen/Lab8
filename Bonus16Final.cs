using System;
using System.Collections.Generic;
using System.Globalization;

namespace Bonus16
{
    class FormatException : SystemException
    {
        static void Main(string[] args)
        {
			

			Console.WriteLine("Welcome to the Grand Circus Motors admin console!");

            Cars k = new Cars();
            List<Cars> ncar = new List<Cars>();

            Console.WriteLine("How many cars are you entering:");
            int i = int.Parse(Console.ReadLine());
            for (int v = 1; v <= i; v++)
            {
                Cars userInput = new Cars();
                Console.WriteLine("Enter Car #" + v + " Make:");
                string modelInput = Console.ReadLine();
                userInput.SetModel(modelInput);

                Console.WriteLine("Enter Car #" + v + " Model:");
                string makeInput = Console.ReadLine();
                userInput.SetMake(makeInput);

                Console.WriteLine("Enter Car #" + v + " Year:");
                int yearInput = int.Parse(Console.ReadLine());
                userInput.SetYear(yearInput);

                Console.WriteLine("Enter Car #" + v + " Price:");
                double priceInput = double.Parse(Console.ReadLine());
                userInput.SetPrice(priceInput);

                ncar.Add(new Cars(modelInput, makeInput, yearInput, priceInput));
                Console.WriteLine();
            }

            Console.WriteLine("Current Inventory:");
            for (int i = 0; i < ncar.Count; i++)
            {
                int v = i + 1;
                Cars full = ncar[m];
                Console.WriteLine(full.Make + "\t" + full.Model + "\t" + full.Price.ToString("C2", CultureInfo.CurrentCulture) + "\t" + full.Year);
            }
        }
    }
}
