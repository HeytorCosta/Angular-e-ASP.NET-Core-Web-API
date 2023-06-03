using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController()
        {
            
        }

        [HttpGet]
        public string Get()
        {
            return "exemplo de get";
        }

        [HttpPost]

        public string Post()
        {
            return "exemplo de post";
        }

        [HttpPut("{id}")]

        public string Put(int id)
        {
            return $"exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]

        public string Delete(int id)
        {
            return $"exemplo de Delete com id = {id}";
        }
    }
}
