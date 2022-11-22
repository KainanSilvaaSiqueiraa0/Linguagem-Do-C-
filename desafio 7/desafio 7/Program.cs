using System;

namespace desafio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, valor3, valor4, soma, media;

            Console.WriteLine("digite o primeiro valor");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o segundo valor");
            valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o terceiro valor");
            valor3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o Quarto valor");
            valor4 = Convert.ToDouble(Console.ReadLine());

            soma = valor1 + valor2 + valor3 + valor4;

            Console.WriteLine("a soma é:", soma);
            Console.WriteLine(soma);

            media = valor1 + valor2 + valor3 + valor4;
            media = media / 4;

            Console.WriteLine("a media é:", media);
            Console.WriteLine(media);


        }
    }
}
