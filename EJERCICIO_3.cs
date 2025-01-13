using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        Dictionary<string, string> notas = new Dictionary<string, string>();

        foreach (string asignatura in asignaturas)
        {
            Console.Write($"¿Qué nota has sacado en {asignatura}? ");
            string nota = Console.ReadLine();
            notas[asignatura] = nota;
        }

        Console.WriteLine("\nTus notas:");
        foreach (var item in notas)
        {
            Console.WriteLine($"En {item.Key} has sacado {item.Value}");
        }
    }
}
