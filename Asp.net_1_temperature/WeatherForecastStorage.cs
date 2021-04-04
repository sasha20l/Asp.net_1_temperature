using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_1_temperature
{
    public class WeatherForecastStorage
    {

        public List<TemperatureObject> temperatureObjectValue = new List<TemperatureObject>();
        public void CreateTemperature(int temperature, DateTime dateTime)
        {

            temperatureObjectValue.Add(new TemperatureObject(temperature, dateTime));
        }
    }
}
