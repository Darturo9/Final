using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese una lista de números separados por comas
        Console.WriteLine("Ingrese una lista de números separados por comas:");
        string inputNumeros = Console.ReadLine();
        List<int> numeros = inputNumeros.Split(',').Select(int.Parse).ToList();

        // Ejemplo de expresión lambda: Filtrar una lista de números para obtener solo los números pares
        List<int> numerosPares = numeros.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Números pares: " + string.Join(", ", numerosPares));

        // Solicitar al usuario que ingrese una lista de palabras separadas por comas
        Console.WriteLine("Ingrese una lista de palabras separadas por comas:");
        string inputPalabras = Console.ReadLine();
        List<string> palabras = inputPalabras.Split(',').Select(p => p.Trim()).ToList();

        // Ejemplo de expresión lambda: Ordenar una lista de cadenas por su longitud
        List<string> palabrasOrdenadas = palabras.OrderBy(p => p.Length).ToList();
        Console.WriteLine("Palabras ordenadas por longitud: " + string.Join(", ", palabrasOrdenadas));

        // Ejemplo de expresión lambda: Seleccionar solo los nombres que empiezan con la letra 'A'
        List<string> nombresConA = palabras.Where(n => n.StartsWith("A")).ToList();
        Console.WriteLine("Nombres que empiezan con 'A': " + string.Join(", ", nombresConA));

        // Ejemplo de consulta LINQ: Filtrar y ordenar una lista de números
        var numerosFiltradosYOrdenados = from n in numeros
                                         where n > 5
                                         orderby n
                                         select n;
        Console.WriteLine("Números mayores a 5 y ordenados: " + string.Join(", ", numerosFiltradosYOrdenados));

        // Ejemplo de consulta LINQ: Seleccionar nombres y convertirlos a mayúsculas
        var nombresEnMayusculas = from n in palabras
                                  select n.ToUpper();
        Console.WriteLine("Nombres en mayúsculas: " + string.Join(", ", nombresEnMayusculas));

        // Ejemplo de consulta LINQ: Agrupar una lista de palabras por su longitud
        var palabrasAgrupadas = from p in palabras
                                group p by p.Length into g
                                select new { Longitud = g.Key, Palabras = g };

        foreach (var grupo in palabrasAgrupadas)
        {
            Console.WriteLine($"Longitud: {grupo.Longitud}");
            foreach (var palabra in grupo.Palabras)
            {
                Console.WriteLine($"  {palabra}");
            }
        }
    }
}
