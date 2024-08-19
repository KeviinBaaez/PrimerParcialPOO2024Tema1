namespace Ejercicio04.Entidades
{
    public class NumeroArmstrong
    {

        int Valor { get; set; }

        public NumeroArmstrong(int valor)
        {
            this.Valor=valor;
        }
        public bool EsValido()
        {
            int suma = 0;
            int temp = Valor;
            int n = Valor.ToString().Length;
            while (temp > 0)
            {
                int digito = temp % 10;
                suma += (int)Math.Pow(digito, n);
                temp /= 10;
            }
            return suma == Valor;
        }

        public static bool operator ==(NumeroArmstrong n1, NumeroArmstrong n2)
        {
            if(n1 is null || n2 is null)return false;
            return n1.Valor== n2.Valor;
        }
        public static bool operator !=(NumeroArmstrong n1, NumeroArmstrong n2)
        {
            return !(n1==n2);
        }

        public override string ToString()
        {
            return $"{Valor}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is NumeroArmstrong n)) return false;
            return this == n;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                return hash += 23 * Valor.GetHashCode();
            }
        }
    }
}
