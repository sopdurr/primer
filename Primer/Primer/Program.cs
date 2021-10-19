using System;
using System.Collections.Generic;
using System.Linq;


namespace Primer
{
    class Program
    {
        static void Main()
        {

            var numbersList = new List<string>();

            while (true)
            {
                Console.Write("Please enter number:");
                string numbers = Console.ReadLine();
                numbersList.Add(numbers);

                if (string.IsNullOrEmpty(numbers))
                {

                    int x = 0;
                    var result = numbersList.Where(str => int.TryParse(str, out x))
                                        .Select(str => x);
                    var max = result.Max();
                    var min = result.Min();

                    Console.WriteLine("This is the whole list:");

                    foreach (int ints in result)
                    {
                        Console.WriteLine(ints);

                    }
                    Console.WriteLine();
                    Console.WriteLine("The highest number from the list is:" + max);
                    Console.WriteLine("The lowest number from the list is:" + min);

                    break;
                }

            }
        }

    }
}
