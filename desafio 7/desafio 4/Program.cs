using System;

namespace desafio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int contador = 0; contador < 10; contador++) ;
            {

                int valor = Convert.ToInt32(Console.ReadLine());
                if (valor % 2 == 0) ;
                {
                    Console.WriteLine("par");
                
                }
                  else
                  {
                    Console.WriteLine("impar");
                  }   

            }
        }
    }
}
