using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Proeventos.API.Data;
using Proeventos.API.Models;

namespace Proeventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;
        public EventoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoID == id);
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
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
