using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos vértices tendrá el grafo? ");
            int n = int.Parse(Console.ReadLine());
            Grafo grafo = new Grafo(n);

            // Agregar los vértices
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el nombre del vértice {i + 1}: ");
                string nombre = Console.ReadLine();
                grafo.AgregarVertice(nombre);
            }

            // Crear la matriz de adyacencia
            grafo.CrearMatriz();

            // Mostrar el resultado
            Console.WriteLine("\nMatriz de adyacencia del grafo:\n");
            grafo.MostrarMatriz();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
