using System;

namespace desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("primeiro desafio");

            try
            {

                Console.WriteLine("imforme um valor");

                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("numero");
            }
            catch (FormatException)
            {

                Console.WriteLine("texto");
            }



        }
    }
}
