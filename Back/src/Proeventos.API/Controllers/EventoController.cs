using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Proeventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public EventoController()
        {
            
        }

        [HttpGet]
        public string Get()
        {
            return "Retorno do Get";
        }

        [HttpPost]
        public string Post(){
            return "Retorno do Post";
        }

        [HttpPut("{id}")]
        public string Put(int id){
            return $"Retorno do Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id){
            return $"Retorno do Delete com id = {id}";
        }
    }
}
