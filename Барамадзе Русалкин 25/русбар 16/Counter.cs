using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR16
{
    public class Counter
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Counter(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public static Counter operator +(Counter counter, int increment)
        {
            return new Counter(counter.Name, counter.Value + increment);
        }

        public object this[string key]
        {
            get
            {
                if (key == "value")
                    return Value;
                else
                    throw new ArgumentException("Неизвестный ключ");
            }
            set
            {
                if (key == "value")
                    Value = (int)value;
                else
                    throw new ArgumentException("Неизвестный ключ");
            }
        }

        public override string ToString()
        {
            return $"{Name}: {Value}";
        }
    }
}
