using System;

namespace Delgates
{
    class Program
    {
        public static void subtotal(int subtotal)
        {
            Console.WriteLine($"Hello World! {subtotal}");
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            myClass holder = new myClass();
            int value = holder.GenerateTotal(subtotal);

        }

    }
}
