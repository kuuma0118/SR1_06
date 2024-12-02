using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int randomValue = rand.Next(-5, 6);
                numbers.Add(randomValue);
            }

            Console.WriteLine("格納した値:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}