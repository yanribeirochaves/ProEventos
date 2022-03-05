using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvento.API.Data;
using ProEvento.API.Models;

namespace ProEvento.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] 
            {
                new Evento()
                {
                    EventoId = 1,
                    Tema = "sasasa",
                    Local = "aaaaaaaaaaaa",
                    Lote = "sssssssss",
                    QtdPessoa = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToShortDateString(),
                    ImagemURL = "foto.png"
                },
                new Evento()
                {
                    EventoId = 1, 
                    Tema = "sasasa",
                    Local = "aaaaaaaaaaaa",
                    Lote = "sssssssss",
                    QtdPessoa = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToShortDateString(),
                    ImagemURL = "foto.png"
                }
            };
        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            this._context = context;
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }
        
        [HttpPost]
        public string Post()
        {
            return "post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "put" + id;
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "delete" + id;
        }
    }
}
