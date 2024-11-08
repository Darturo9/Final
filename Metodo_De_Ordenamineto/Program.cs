using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese palabras separadas por espacios:");
        string input = Console.ReadLine();

        // Dividir el texto en palabras usando espacios como separadores
        string[] palabras = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Imprimir el listado proporcionado por el usuario
        Console.WriteLine("Listado proporcionado:");
        ImprimirListado(palabras);

        // Ordenar usando el método de burbuja
        string[] palabrasOrdenadasBurbuja = (string[])palabras.Clone();
        OrdenarBurbuja(palabrasOrdenadasBurbuja);
        Console.WriteLine("Listado ordenado por método de burbuja:");
        ImprimirListado(palabrasOrdenadasBurbuja);

        // Ordenar usando el método Sort
        string[] palabrasOrdenadasSort = (string[])palabras.Clone();
        Array.Sort(palabrasOrdenadasSort);
        Console.WriteLine("Listado ordenado por método Sort:");
        ImprimirListado(palabrasOrdenadasSort);
    }

    // Función para imprimir un listado de palabras
    static void ImprimirListado(string[] palabras)
    {
        foreach (var palabra in palabras)
        {
            Console.WriteLine(palabra);
        }
    }

    // Función para ordenar un array de palabras usando el método de burbuja
    static void OrdenarBurbuja(string[] palabras)
    {
        int n = palabras.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (palabras[j].Length > palabras[j + 1].Length)
                {
                    // Intercambiar palabras[j] y palabras[j + 1]
                    string temp = palabras[j];
                    palabras[j] = palabras[j + 1];
                    palabras[j + 1] = temp;
                }
            }
        }
    }
}