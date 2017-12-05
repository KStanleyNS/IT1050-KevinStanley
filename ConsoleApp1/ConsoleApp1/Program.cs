
  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    string[] names = new string[6];
        //    names[0] = "Kevin";
        //    names[1] = "Dahlia";
        //    names[2] = "Junior";
        //    names[3] = "David";
        //    names[4] = "Josh";
        //    names[5] = "Alvin";

        //    string[] majors = new string[6];
        //    majors[0] = "Networking Software";
        //    majors[1] = "Computer Science";
        //    majors[2] = "Electrical Engineering";
        //    majors[3] = "Computer Science";
        //    majors[4] = "Programming and Maintenance";
        //    majors[5] = "Programming";

        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        Console.WriteLine(names[i] + ":" + majors[i]);
        //    }


        //}

        //{
        //    List<string> names = new List<string>();
        //    names.Add("Kevin");
        //    names.Add("Dahlia");
        //    names.Add("Junior");
        //    names.Add("David");
        //    names.Add("Alvin");
        //    names.Add("Josh");


        //    foreach(string name in names)
        //    {
        //        Console.WriteLine(name);
        //    }


        //    //for (int i = 0; i < names.Count; i++)

        //    //{ 
        //    //Console.WriteLine(names[i]);
        //    //}

        //}

        //Array Initializer List example

        //string[] names = { "Al Dente", "Tim Burr", "Will Wynn" };



        //string[] majors = new string[3];
        //majors[0] = "Computer Science";
        //majors[1] = "Programming";
        //majors[2] = "Networking";

      

      {
        
        string[,] array = new string[,]
        {
            {"Kevin", "Josh", "David", "Alvin", "Dahlia", "Junior"},
            {"1", "2", "3", "4", "5", "6"},
        };
        
        Console.WriteLine(array[0, 0]);
        Console.WriteLine(array[0, 1]);
        Console.WriteLine(array[0, 2]);
        Console.WriteLine(array[0, 3]);
        Console.WriteLine(array[0, 4]);
        Console.WriteLine(array[0, 5]);
            
            
        }

}
}
