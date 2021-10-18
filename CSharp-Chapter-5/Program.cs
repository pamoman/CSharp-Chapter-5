using System;

namespace CSharp_Chapter_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 5");

            string[] names = new string[3];

            Console.WriteLine($"Array length: { names.Length}");

            names[0] = "Paul";

            Console.WriteLine(names[0]);

            string[] places = { "Sweden", "China", "Spain", "England" };

            Console.WriteLine($"Places Array length: { places.Length}");

            Console.WriteLine($"The second country is {places[1]} with index 1");

            foreach (string place in places)
            {
                Console.WriteLine(place);
            }

            string[] cities = new string[3];

            Console.WriteLine($"Type {cities.Length} cities...");

            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write($"City {i + 1}: ");

                cities[i] = Console.ReadLine();
            }

            Console.WriteLine($"The cities are: {string.Join(", ", cities[0..(cities.Length - 1)])} and {cities[cities.Length - 1]}");

            Console.WriteLine("Array of numbers");

            int[] numbers = { 9, 34, 65, 92, 87, 435, 3, 54,
                    83, 23, 87, 67, 12, 19 };

            int sum = 0;

            foreach(int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine($"The sum of all the numbers is {sum}");

            Console.WriteLine("Last number in array");
            int last = numbers[numbers.Length - 1];

            Console.WriteLine(last);
        }
    }
}
