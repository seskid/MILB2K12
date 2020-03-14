using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILB2K12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mlbFinal = new List<string>();
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\seski\Desktop\milb\schedule_minors.txt");

            foreach (var line in lines)
            {
                var newLine = line.Remove(0, 1);
                mlbFinal.Add(newLine);




            }

            System.IO.File.WriteAllLines(@"C:\Users\seski\Desktop\milb\mlbFinal.txt", mlbFinal.ToArray());
            Console.WriteLine("done");

            Console.ReadKey();
        }
    }
}
