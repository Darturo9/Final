using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Ejemplo 1: Llamada a la función síncrona
        RealizarTareaSincrona();

        // Ejemplo 2: Llamada a la función asíncrona
        await RealizarTareaAsincrona();

        // Ejemplo 3: Llamada a la función que combina tareas síncronas y asíncronas
        await RealizarTareasCombinadas();
    }

    // Método que realiza una tarea de manera síncrona
    static void RealizarTareaSincrona()
    {
        Console.WriteLine("Inicio de tarea síncrona");
        // Simulación de una tarea que toma tiempo
        System.Threading.Thread.Sleep(2000); // Pausa de 2 segundos
        Console.WriteLine("Fin de tarea síncrona");
    }

    // Método que realiza una tarea de manera asíncrona
    static async Task RealizarTareaAsincrona()
    {
        Console.WriteLine("Inicio de tarea asíncrona");
        // Simulación de una tarea que toma tiempo de manera asíncrona
        await Task.Delay(2000); // Pausa de 2 segundos
        Console.WriteLine("Fin de tarea asíncrona");
    }

    // Método que combina tareas síncronas y asíncronas
    static async Task RealizarTareasCombinadas()
    {
        Console.WriteLine("Inicio de tarea combinada");

        // Tarea síncrona
        RealizarTareaSincrona();

        // Tarea asíncrona
        await RealizarTareaAsincrona();

        Console.WriteLine("Fin de tarea combinada");
    }
}