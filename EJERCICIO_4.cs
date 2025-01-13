using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numerosGanadores = new List<int>();

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Ingrese el número ganador {i + 1}: ");
            int numero = int.Parse(Console.ReadLine());
            numerosGanadores.Add(numero);
        }

        numerosGanadores.Sort();

        Console.WriteLine("\nNúmeros ganadores ordenados:");
        foreach (int numero in numerosGanadores)
        {
            Console.WriteLine(numero);
        }
    }
}
