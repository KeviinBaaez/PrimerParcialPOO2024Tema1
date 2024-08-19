using Ejercicio01.Entidades;
using MiDLL;

namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Crear Piramide Cuadrada");
            int lado = ConsoleExtensions.ReadInt("Ingrese el valor del  lado: ");
            int altura = ConsoleExtensions.ReadInt("Ingrese el valor de la  Altura");
            CrearPiramide(lado, altura);
            PiramideCuadrada pc = CrearPiramide(lado, altura);
            Console.WriteLine(pc.MostrarDatos().ToString());
        }



        private static PiramideCuadrada CrearPiramide(int lado, int altura)
        {
            return new PiramideCuadrada(lado, altura);
        }
    }
}
