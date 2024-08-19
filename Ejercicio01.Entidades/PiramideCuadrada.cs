using System.Text;

namespace Ejercicio01.Entidades
{
    public class PiramideCuadrada
    {
        private readonly int lado;
        private readonly int altura;
        private double apotema;
        //Math.Sqrt(Math.Pow(lado / 2), 2 + Math.Pow(altura, 2))

        public PiramideCuadrada(int Lado, int Altura)
        {
            if(Lado > 0 && Altura > 0)
            {
                lado = Lado;
                altura = Altura;
                
            }
            
        }

        public double GetArea()
        {
            double AreaBase = lado * lado;
            double AreaLateral = 2 * lado * GetApotema();

            double Area = AreaBase + AreaLateral;

            return Area;
        }
        public double GetVolumen()
        {
            double Volumen = Math.Pow(lado, 2) * altura / 3;
            return Volumen;
        }

        public double GetApotema()
        {
            double Apotema = Math.Sqrt(Math.Pow(lado / 2, 2) + Math.Pow(altura, 2));
            return Apotema;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El area es: {GetArea()}");
            sb.AppendLine($"El volumen es: {GetVolumen()}");
            sb.AppendLine($"El apotema es: {GetApotema}");

            return sb.ToString();
        }

    }
}
