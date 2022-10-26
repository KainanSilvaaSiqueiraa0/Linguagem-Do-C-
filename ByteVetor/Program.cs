using System;

namespace ByteVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] vbytes = { 2, 4, 8, 10 };



            Console.WriteLine("Lista de valores do vetor");

            Console.WriteLine("valor1: {0}", vbytes[0]);
            Console.WriteLine("valor1: {0}", vbytes[1]);
            Console.WriteLine("valor1: {0}", vbytes[2]);
            Console.WriteLine("valor1: {0}", vbytes[3]);
            Console.WriteLine("Total de elemento no vetor é {0}", vbytes.Length);

            for (int i = 0; i < vbytes.Length; i++)
            {
                Console.WriteLine("valor na posição {0} é igual a {1}", i, vbytes[i]);
            
            }

               
            
            byte[] vbytesB = new byte[3];
            Console.WriteLine("Novs valores");
            for (int i = 0; i < vbytesB.Length; i++)
            {   Console.WriteLine("digite o {0} valor: ", i);
                   vbytesB[i] = Convert.ToByte (Console.ReadLine());
        



             
            
        
        
        
        
        
        }
    }
}
