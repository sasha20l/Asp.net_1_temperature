using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_1_temperature
{
    public class Temperature
    {
        public List<TemperatureObject> temperatureObject = new List<TemperatureObject>();
        public void CreateTemperature(int temperature)
        {
            temperatureObject.Add(new TemperatureObject(temperature, DateTime.Now));
        }
    }

    public class TemperatureObject
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public TemperatureObject(int temperatureC, DateTime date) { TemperatureC = temperatureC; Date = date; }


    }
}
