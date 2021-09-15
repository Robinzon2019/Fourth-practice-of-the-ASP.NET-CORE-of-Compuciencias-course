using System;
using System.Collections.Generic;

namespace fourth_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaEnteros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 ,14 ,15 };
            List<int> listaPares = listaEnteros.Pares();

            Console.WriteLine("--------Lista de numeros pares--------\n");

            foreach (var item in listaPares)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
