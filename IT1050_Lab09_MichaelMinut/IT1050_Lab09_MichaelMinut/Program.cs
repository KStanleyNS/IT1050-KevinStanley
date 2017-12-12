using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050_Lab09_MichaelMinut
{
    class Program
    {
        static void Main(string[] args)
        {
            // Outputting All the Elements using a ForEach Loop

            var fruits = new[] { "apple", "mango", "orange", "apricot", "cherry", "grape", "blueberry" };
            
            foreach (var element in fruits)
            {
                Console.Write($"{element}" + "\n");
            }

            //LINQ Query to Uppercase, selecting "A" fruit names

            var Uppercase = from elements in fruits
                            where elements.StartsWith("a")
                            select elements.ToUpper();

            foreach (var elements in Uppercase)
            {
                Console.Write($"{elements}" + "\n");
            }

            // 6 Element List<T> Count and Capacity

            //creates the List string

            var items = new List<string>();

            //Adding the Last 6 Months to List String

            items.Add("July");
            items.Add("August");
            items.Add("September");
            items.Add("October");
            items.Add("November");
            items.Add("December");

            //Display Count, Capacity and items

            Console.WriteLine("\n" + $"Count = {items.Count}; Capacity = {items.Capacity}");
            for (var i = 0; i < items.Count; i++)
            {
                Console.Write($"{items[i]}" + "\n");
            }


            // Insert First 6 Months in Right Sequence

            items.Insert(0, "June");
            items.Insert(0, "May");
            items.Insert(0, "April");
            items.Insert(0, "March");
            items.Insert(0, "February");
            items.Insert(0, "January");

            for (var i = 0; i < items.Count; i++)
            {
                Console.Write($"{items[i]}" + "\n");
            }


            //Remove Months, Display Count/Capacity, LINQ query Months ending in "ber" then display

            items.Remove("January");
            items.Remove("February");
            items.Remove("March");
            items.Remove("April");
            items.Remove("May");
            items.Remove("June");

            Console.WriteLine($"Count = {items.Count}; Capacity = {items.Capacity}");

            var EndBER = from elements in items
                         let Ber = elements
                         where elements.EndsWith("ber")
                         select Ber;

            foreach (var elements in EndBER)
            {
                Console.Write($"{elements}" + "\n");
            }
        }
    }
}
