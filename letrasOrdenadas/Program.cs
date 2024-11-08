using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese letras separadas por espacios:");
        string input = Console.ReadLine();

        // Dividir el texto en letras usando espacios como separadores
        char[] letras = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(c => c[0]).ToArray();

        // Imprimir el listado proporcionado por el usuario
        Console.WriteLine("Listado proporcionado:");
        ImprimirListado(letras);

        // Ordenar usando el método de burbuja
        char[] letrasOrdenadasBurbuja = (char[])letras.Clone();
        OrdenarBurbuja(letrasOrdenadasBurbuja);
        Console.WriteLine("Listado ordenado por método de burbuja:");
        ImprimirListado(letrasOrdenadasBurbuja);

        // Ordenar usando el método Sort
        char[] letrasOrdenadasSort = (char[])letras.Clone();
        Array.Sort(letrasOrdenadasSort);
        Console.WriteLine("Listado ordenado por método Sort:");
        ImprimirListado(letrasOrdenadasSort);
    }

    // Función para imprimir un listado de letras
    static void ImprimirListado(char[] letras)
    {
        foreach (var letra in letras)
        {
            Console.Write(letra + " ");
        }
        Console.WriteLine();
    }

    // Función para ordenar un array de letras usando el método de burbuja
    static void OrdenarBurbuja(char[] letras)
    {
        int n = letras.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (letras[j] > letras[j + 1])
                {
                    // Intercambiar letras[j] y letras[j + 1]
                    char temp = letras[j];
                    letras[j] = letras[j + 1];
                    letras[j + 1] = temp;
                }
            }
        }
    }
}
