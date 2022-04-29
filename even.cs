//1) Write a c# code to show even numbers between 1 to 10:

using System;
namespace looping
{
    class Program
    {
        static void Main(string[] args)
            
        {
            int i = 1;
            for (i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
 
