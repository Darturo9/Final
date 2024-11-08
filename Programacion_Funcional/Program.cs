using System;
using System.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Ingrese un texto:");
        string texto = Console.ReadLine();

        // Llamada a la función para contar palabras
        int totalPalabras = ContarPalabras(texto);
        Console.WriteLine($"Cantidad total de palabras: {totalPalabras}");

        // Llamada a la función para encontrar las palabras más largas
        var palabrasMasLargas = EncontrarPalabrasMasLargas(texto);
        Console.WriteLine("Las 3 palabras más largas son:");
        foreach (var palabra in palabrasMasLargas)
        {
            Console.WriteLine(palabra);
        }

        // Llamada a la función para convertir a mayúsculas
        string textoEnMayusculas = ConvertirAMayusculas(texto);
        Console.WriteLine("Texto en mayúsculas:");
        Console.WriteLine(textoEnMayusculas);
    }

    // Función que cuenta las palabras en el texto
    static int ContarPalabras(string texto)
    {
        if (string.IsNullOrWhiteSpace(texto))
        {
            return 0;
        }

        // Dividir el texto en palabras usando espacios como separadores
        string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return palabras.Length;
    }

    // Función que encuentra las 3 palabras más largas
    static string[] EncontrarPalabrasMasLargas(string texto)
    {
        if (string.IsNullOrWhiteSpace(texto))
        {
            return new string[0];
        }

        // Dividir el texto en palabras usando espacios como separadores
        string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Ordenar las palabras por longitud en orden descendente y tomar las 3 primeras
        return palabras.OrderByDescending(p => p.Length).Take(3).ToArray();
    }

    // Función que convierte todas las palabras a mayúsculas
    static string ConvertirAMayusculas(string texto)
    {
        if (string.IsNullOrWhiteSpace(texto))
        {
            return string.Empty;
        }

        // Convertir todo el texto a mayúsculas
        return texto.ToUpper();
    }
}
