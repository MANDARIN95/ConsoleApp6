using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Grafo
    {
        private Vertice inicioLista;
        private int[,] ma;

        public Grafo(int cantidad)
        {
            ma = new int[cantidad, cantidad];
        }

        public void AgregarVertice(string dato)
        {
            if (inicioLista == null)
            {
                inicioLista = new Vertice(dato);
            }
            else
            {
                Vertice actual = inicioLista;
                while (actual.VerticeSig != null)
                {
                    actual = actual.VerticeSig;
                }
                actual.VerticeSig = new Vertice(dato);
            }
        }

        public void CrearMatriz()
        {
            int n = 0;
            Vertice actual = inicioLista;
            while (actual != null)
            {
                n++;
                actual = actual.VerticeSig;
            }

            ma = new int[n, n];

            Console.WriteLine("\nIngrese 1 si existe conexión, 0 si no:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Vertice verticeOrigen = inicioLista;
                    Vertice verticeDestino = inicioLista;
                    for (int k = 0; k < i; k++) verticeOrigen = verticeOrigen.VerticeSig;
                    for (int k = 0; k < j; k++) verticeDestino = verticeDestino.VerticeSig;

                    Console.Write($"¿Hay conexión de {verticeOrigen.Dato} a {verticeDestino.Dato}? ");
                    int valor;
                    while (!int.TryParse(Console.ReadLine(), out valor) || (valor != 0 && valor != 1))
                    {
                        Console.Write("Ingrese solo 1 o 0: ");
                    }
                    ma[i, j] = valor;
                }
            }
        }

        public void MostrarMatriz()
        {
            int n = 0;
    Vertice actual = inicioLista;
    while (actual != null)
    {
        n++;
        actual = actual.VerticeSig;
    }

    
    string[] nombres = new string[n];
    actual = inicioLista;
    for (int i = 0; i < n; i++)
    {
        nombres[i] = actual.Dato;
        actual = actual.VerticeSig;
    }

    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("\t");
    Console.ResetColor();

   
    for (int j = 0; j < n; j++)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(nombres[j] + "\t");
        Console.ResetColor();
    }
    Console.WriteLine();

  
    for (int i = 0; i < n; i++)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(nombres[i] + "\t");
        Console.ResetColor();

        for (int j = 0; j < n; j++)
        {
            Console.Write(ma[i, j] + "\t");
        }
        Console.WriteLine();

            }
        }
    }
}
