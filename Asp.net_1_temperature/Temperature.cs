using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_1_temperature
{
    public class Temperature
    {
        DateTime now = DateTime.Now;
        public List<TemperatureObject> temperatureObjectValue = new List<TemperatureObject>();
        public void CreateTemperature(int temperature)
        {
            temperatureObjectValue.Add(new TemperatureObject(temperature, now.ToString("D")));
        }
    }

    public class TemperatureObject
    {
        public string Date { get; set; }

        public int TemperatureC { get; set; }

        public TemperatureObject(int temperatureC, string date) { TemperatureC = temperatureC; Date = date; }


    }
}
