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
        private readonly Temperature holder;

        public TController(Temperature holder)
        {
            this.holder = holder;
        }

        [HttpPost("create")]
        public IActionResult Create([FromQuery] int input)
        {
            holder.CreateTemperature(input);
            return Ok();
        }

        [HttpGet("read")]
        public IActionResult Read()
        {
            string info = "";

            for (int i = 0; i < holder.temperatureObjectValue.Count; i++)
            {

                info += holder.temperatureObjectValue[i].Date + " температура:" + holder.temperatureObjectValue[i].TemperatureC + "\r\n";
               
            }
            return Ok(info);
        }

        [HttpPut("update")]
        public IActionResult Update([FromQuery] string stringsDateToUpdate, [FromQuery] int newTemp)
        {
            for (int i = 0; i < holder.temperatureObjectValue.Count; i++)
            {
                if (holder.temperatureObjectValue[i].Date == stringsDateToUpdate)
                    holder.temperatureObjectValue[i].TemperatureC = newTemp;
            }

            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] string stringsToDelete)
        {
            for (int i = 0; i < holder.temperatureObjectValue.Count; i++)
            {
                if (holder.temperatureObjectValue[i].Date == stringsToDelete)
                    holder.temperatureObjectValue.Remove(holder.temperatureObjectValue[i]);
            }

            return Ok();
        }




    }
}
