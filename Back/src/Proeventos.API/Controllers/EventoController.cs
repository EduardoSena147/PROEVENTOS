using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proeventos.API.Models;

namespace Proeventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                    EventoID = 1,
                    Tema = "Teste Evento 1",
                    Local = "Fortaleza - CE",
                    Lote = "3° Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(34).ToString("dd/MM/yyy"),
                    ImagemURL = "foto.png"
                },

                new Evento(){
                    EventoID = 2,
                    Tema = "Teste Evento 2",
                    Local = "Maracanaú - CE",
                    Lote = "2° Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(12).ToString("dd/MM/yyy"),
                    ImagemURL = "foto.png"
                },

                new Evento(){
                    EventoID = 3,
                    Tema = "Teste Evento 3",
                    Local = "Pacatuba - CE",
                    Lote = "1° Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(421).ToString("dd/MM/yyy"),
                    ImagemURL = "foto.png"
                }

            };

        public EventoController()
        {
            
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoID == id);
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
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
