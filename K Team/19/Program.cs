using System;

namespace _19thProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 5;

            Console.WriteLine("Value before increased: {0}", value);
            
            IncreaseValue(ref value);
            
            Console.WriteLine("Value after increased: {0}", value);

            Console.ReadKey();
        }

        static void IncreaseValue(ref int value)
        {
            value++;
        }
    }
}