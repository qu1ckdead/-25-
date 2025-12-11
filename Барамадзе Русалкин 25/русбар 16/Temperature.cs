using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR16
{
    public class Temperature
    {
        public double Celsius { get; set; }

        public Temperature(double celsius)
        {
            Celsius = celsius;
        }

        public static bool operator >(Temperature t1, Temperature t2)
        {
            return t1.Celsius > t2.Celsius;
        }

        public static bool operator <(Temperature t1, Temperature t2)
        {
            return t1.Celsius < t2.Celsius;
        }

        public static bool operator ==(Temperature t1, Temperature t2)
        {
            if (ReferenceEquals(t1, t2)) return true;
            if (t1 is null || t2 is null) return false;
            return t1.Celsius == t2.Celsius;
        }

        public static bool operator !=(Temperature t1, Temperature t2)
        {
            return !(t1 == t2);
        }

        public override bool Equals(object obj)
        {
            return obj is Temperature temp && this == temp;
        }

        public override int GetHashCode()
        {
            return Celsius.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Celsius}°C";
        }
    }
}
