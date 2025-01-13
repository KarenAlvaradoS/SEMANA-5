using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = Enumerable.Range(1, 10).ToArray();
        Array.Reverse(numeros);

        Console.WriteLine(string.Join(", ", numeros));
    }
}
