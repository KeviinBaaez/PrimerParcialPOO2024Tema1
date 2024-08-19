using Ejercicio03.Entidades;

namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius celsius = new Celsius(25);
            Fahrenheit fahrenheit = new Fahrenheit(77);

            Console.WriteLine($"Celsius: {celsius.Grados}°C");
            Console.WriteLine($"Fahrenheit: {fahrenheit.Grados}°F");

            // Conversión explícita entre tipos
            Celsius celsiusConverted = (Celsius)fahrenheit;
            Fahrenheit fahrenheitConverted = (Fahrenheit)celsius;

            Console.WriteLine(
                $"Fahrenheit convertido a Celsius: {celsiusConverted.Grados}°C");
            Console.WriteLine(
                $"Celsius convertido a Fahrenheit: {fahrenheitConverted.Grados}°F");

            // Operaciones aritméticas
            Celsius sumaCelsius = celsius + celsiusConverted;
            Fahrenheit sumaFahrenheit = fahrenheit + fahrenheitConverted;

            Console.WriteLine($"Suma de Celsius: {sumaCelsius.Grados}°C");
            Console.WriteLine($"Suma de Fahrenheit: {sumaFahrenheit.Grados}°F");

            // Comparaciones
            Console.WriteLine(
                celsius == celsiusConverted 
                ? "Las temperaturas en Celsius son iguales." 
                : "Las temperaturas en Celsius no son iguales.");
            Console.WriteLine(
                fahrenheit == fahrenheitConverted
                ? "Las temperaturas en Fahrenheit son iguales." 
                : "Las temperaturas en Fahrenheit no son iguales.");
        }
    }
}
