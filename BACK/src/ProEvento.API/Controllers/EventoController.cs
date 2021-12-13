using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvento.API.Models;

namespace ProEvento.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return new Evento[] 
            {
                new Evento()
                {
                    EventoId = 1,
                    Tema = "sasasa",
                    Local = "aaaaaaaaaaaa",
                    Lote = "sssssssss",
                    QtdPessoa = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToShortDateString()
                },
                new Evento()
                {
                    EventoId = 1, 
                    Tema = "sasasa",
                    Local = "aaaaaaaaaaaa",
                    Lote = "sssssssss",
                    QtdPessoa = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToShortDateString()
                }
            };
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
