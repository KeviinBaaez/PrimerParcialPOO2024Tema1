using Ejercicio04.Entidades;
namespace Ejercicio04.Datos
{
    public class RepositorioNumerosArmstrong
    {
        private int cantidad;
        private NumeroArmstrong[]? NumerosPerfectos;
        public int GetCantidad() => cantidad;

        public RepositorioNumerosArmstrong(int Cantidad)
        {
            cantidad = Cantidad;
            NumerosPerfectos = new NumeroArmstrong[Cantidad];
        }

        public RepositorioNumerosArmstrong():this(5)
        {
            
        }

        public bool EstaCompleto()
        {
            if (NumerosPerfectos == null) return false;
            if(cantidad == NumerosPerfectos.Length - 1)
            {
                return true;
            }
            return false;
        }

        public bool Estavacio()
        {
            if(NumerosPerfectos == null || NumerosPerfectos.Any())
            {
                return true;
            }
            return false;
        }
    }
}


