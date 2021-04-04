using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_1_temperature.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TController : ControllerBase
    {
        private readonly WeatherForecastStorage _holder;

        public TController(WeatherForecastStorage holder)
        {
            _holder = holder;
        }

        [HttpPost("create/{temperature}/from/{fromDate}")]
        public IActionResult Create([FromQuery] int temperature, [FromQuery] DateTime dateTime)//Дата назначается автоматически в классе Temperature
        {
            _holder.CreateTemperature(temperature, dateTime);
            return Ok();
        }

        [HttpGet("read")]
        public IActionResult ReadTest()
        {
            return Ok();

        }
        [HttpGet("read/from/{fromDate}/to/{toDate}")]
        public IActionResult Read([FromRoute]DateTime fromDate, [FromRoute] DateTime toDate)
        {
            foreach (TemperatureObject temperatureO in _holder.temperatureObjectValue)
            {

                if (temperatureO.Time >= fromDate && temperatureO.Time <= toDate)
                {
                    return Ok(temperatureO);
                }
                else
                {
                }
                
            }
            return Ok();

        }

        [HttpPut("update")]
        public IActionResult Update([FromQuery] DateTime stringsTimeToUpdate, [FromQuery] int newTemp)
        {
            foreach(TemperatureObject temperatureO in _holder.temperatureObjectValue)
            {
                if (temperatureO.Time == stringsTimeToUpdate)
                    temperatureO.TemperatureC = newTemp;
            }

            return Ok();
        }

        [HttpDelete("delete/from/{fromDate}/to/{toDate}")]
        public IActionResult Delete([FromRoute] DateTime fromDate, [FromRoute] DateTime toDate)
        {
            List<int> numbers = new List<int>();
            int i = 0;

            foreach (TemperatureObject temperatureO in _holder.temperatureObjectValue)
            {

                if (temperatureO.Time >= fromDate && temperatureO.Time <= toDate)
                {
                    numbers.Add(i);
                    i++;
                }

            }
            foreach (int num in numbers)
            {

                    _holder.temperatureObjectValue.Remove(_holder.temperatureObjectValue[num]);

            }

            return Ok();
        }
    }
}
