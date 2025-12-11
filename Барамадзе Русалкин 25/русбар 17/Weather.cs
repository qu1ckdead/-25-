using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR17
{
    public struct Weather
    {
        public string City { get; set; }
        public double? Temperature { get; set; }

        public override string ToString()
        {
            if (Temperature.HasValue)
                return $"{City}: {Temperature}°C";
            else
                return $"{City}: Нет данных";
        }

        public double GetTemperatureOrDefault(double defaultValue)
        {
            return Temperature ?? defaultValue;
        }
    }
}
