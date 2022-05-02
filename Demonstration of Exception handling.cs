using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                int b = 0;
                int c = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine("Divide by 0 Exceptuion occure", e);
                Console.ReadLine();

            }
        }

    }
}
