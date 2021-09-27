using FootballPLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class HttpController : Controller
    {
        private readonly Manager manager = new Manager();

        // Get All
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return manager.GetAll();
        }

        // Get by id
        [HttpGet("{id}")]
        public FootballPlayer GetById(int id)
        {
            return manager.GetByID(id);
        }


        // POST
        [HttpPost]
        public FootballPlayer Post([FromBody] FootballPlayer value)
        {
            return manager.Add(value);
        }

        // PUT
        [HttpPut("{id}")]
        public FootballPlayer Put(int id, [FromBody] FootballPlayer value)
        {
            return manager.Update(id, value);
        }

        // DELETE 
        [HttpDelete("{id}")]
        public FootballPlayer Delete(int id)
        {
            return manager.Delete(id);
        }
    }
}

