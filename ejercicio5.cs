using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] nombres = new string[5];
        string rutaArchivo = "nombres.txt";

        // Pedir al usuario los 5 nombres
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.Write($"Ingresa el nombre {i + 1}: ");
            nombres[i] = Console.ReadLine();
        }

        // Escribir los nombres en el archivo
        File.WriteAllLines(rutaArchivo, nombres);
        Console.WriteLine("\nLos nombres han sido guardados en el archivo.\n");

        // Leer y mostrar los nombres desde el archivo
        Console.WriteLine("Nombres guardados en el archivo:");
        string[] nombresLeidos = File.ReadAllLines(rutaArchivo);

        foreach (string nombre in nombresLeidos)
        {
            Console.WriteLine(nombre);
        }
    }
}
