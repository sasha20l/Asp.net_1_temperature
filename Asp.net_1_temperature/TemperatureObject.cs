using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_1_temperature
{
    public class TemperatureObject
    {
        public DateTime Time { get; set; }

        public int TemperatureC { get; set; }
        public TemperatureObject() { }
        public TemperatureObject(int temperatureC, DateTime date) { TemperatureC = temperatureC; Time = date; }
    }
}
