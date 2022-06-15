using System;
using System.Collections.Generic;

namespace Arreglo3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] valores = new int[5];
            int i;
            int suma=0;
            for(i = 0; i <valores.Length; i++)
            {
                //Console.WriteLine("Posicion " + i);
                Console.WriteLine("Ingrese valores en la posición: "+i);
                string N = Console.ReadLine();
                //int M = Convert.ToInt32(N);
                valores[i] = Convert.ToInt32(N);
                
                suma=suma+valores[i];
            }
            for (i=0;i<valores.Length;i++)
            {
                Console.WriteLine("Valores ingresado es " + valores[i]);
            }
            Console.WriteLine("Suma total es: " + suma);
            Console.ReadKey();
            
        }
       
    }
}
