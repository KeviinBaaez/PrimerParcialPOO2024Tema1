namespace Ejercicio03.Entidades
{
    public class Celsius
    {
        private float grados;

        public float GetGrados() => grados;

        public Celsius(float Grados)
        {
            grados = Grados > 0 ? Grados : 5;
        }

        public static implicit operator float(Celsius c)
        {
            return (float)c;
        }

        public static bool operator ==(Celsius c1,Celsius c2)
        {
            if (c1 is null || c2 is null) return false;
            return c1.GetGrados() == c2.GetGrados();
        }
        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
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

        public static Celsius operator +(Celsius c1, Celsius c2)
        {
            return new Celsius(c1.GetGrados()+c2.GetGrados());
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Celsius celsius)) return false;

            return this == celsius;
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
