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
            string time = now.ToString("T");
            temperatureObjectValue.Add(new TemperatureObject(temperature, time));
        }
    }

}
