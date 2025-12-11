using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR16
{
    public class Vector
    {
        private double[] components;

        public Vector(params double[] values)
        {
            components = values;
        }

        public static double operator *(Vector v1, Vector v2)
        {
            if (v1.components.Length != v2.components.Length)
                throw new ArgumentException("Векторы должны иметь одинаковую размерность");

            double result = 0;
            for (int i = 0; i < v1.components.Length; i++)
            {
                result += v1.components[i] * v2.components[i];
            }
            return result;
        }

        public double this[int index]
        {
            get
            {
                if (index < 0 || index >= components.Length)
                    throw new IndexOutOfRangeException();
                return components[index];
            }
            set
            {
                if (index < 0 || index >= components.Length)
                    throw new IndexOutOfRangeException();
                components[index] = value;
            }
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", components)}]";
        }
    }
}
