using System;

namespace desafio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inteiro ou real");

            try
            {

                Console.WriteLine("digite um valor");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("inteiro");

            }
            catch (FormatException)
            {

                Console.WriteLine("real");
            }




        }
    }
}
