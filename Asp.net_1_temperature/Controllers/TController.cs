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
            return Ok(holder.temperatureObject);
        }

        //[HttpPut("update")]
        //public IActionResult Update([FromQuery] string stringsToUpdate, [FromQuery] string newValue)
        //{
        //    //for (int i = 0; i < holder.Values.Count; i++)
        //    //{
        //    //    if (holder.Values[i] == stringsToUpdate)
        //    //        holder.Values[i] = newValue;
        //    //}

        //    //return Ok();
        //}

        //[HttpDelete("delete")]
        //public IActionResult Delete([FromQuery] string stringsToDelete)
        //{
        //    //holder.Values = holder.Values.Where(w => w != stringsToDelete).ToList();
        //    //return Ok();
        //}




    }
}
