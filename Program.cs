using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
            Console.ReadKey();
        }
        public static void doApp()
        {
            int x = 10;

            if (x >= 10)
                Console.WriteLine("This is a conditional statement.");
            switch (x) 
            {
                case 9:
                    Console.WriteLine("This is a switch statement resulting in 9");
                    break;
                case 10:
                    Console.WriteLine("This is a switch statement resulting in 10");
                    break;

            } 
            while(x < 20)
            {
                x++;
                Console.WriteLine("Incrementing x in while loop: " + x);
            }

            do
            {
                x--;
                Console.WriteLine("Decrementing x in do-while loop: " + x);

            } while (x >= 10);

            for(int i = 0; i <= x; i++)
            {
                Console.WriteLine("For loop to assign a value: " + i);
            }

            string[] numbers = { "One", "Two", "Three", "Four", "Five" };
            foreach(string s in numbers)
            {
                Console.WriteLine("Foreach loop to iterate through an array: " + s);
            }

        }
    }
}
