namespace Ejercicio03.Entidades
{
    public class Fahrenheit
    {
        private float grados;

        public float GetGrados() => grados;

        public Fahrenheit(float Grados)
        {
            grados = Grados > 0 ? Grados : 5;
        }

        public static implicit operator float(Fahrenheit f)
        {
            return (float)f;
        }

        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            if (f1 is null || f2 is null) return false;
            return f1.GetGrados() == f2.GetGrados();
        }

        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            if (f is null || c is null) return false;
            return f.GetGrados() == c.GetGrados();
        }

        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(c ==f);
        }

        public static Fahrenheit operator +(Fahrenheit f1, Fahrenheit f2)
        {
            return new Fahrenheit(f1.GetGrados() + f2.GetGrados());
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Fahrenheit fahrenheit)) return false;

            return this == fahrenheit;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash += 23 * GetGrados().GetHashCode();

                return hash;
            }
        }
    }
}
