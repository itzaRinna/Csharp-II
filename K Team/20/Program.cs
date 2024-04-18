using System;

namespace _20thProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;

            // Console.WriteLine("Value before increased: {0}", value);
            
            IncreaseValue(out value);
            
            Console.WriteLine("Value after increased: {0}", value);

            Console.ReadKey();
        }

        static void IncreaseValue(out int value)
        {
            value = 0;
            value++;
        }
    }
}