using _03_RestInASP_NET5Udemy_UsingDifferentVerbs.Model;
using _03_RestInASP_NET5Udemy_UsingDifferentVerbs.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_RestInASP_NET5Udemy_UsingDifferentVerbs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            Person person = _personService.FindById(id);

            return person != null ? Ok(person) : NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            return person != null ? Ok(_personService.Create(person)) : BadRequest();
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            return person != null ? Ok(_personService.Update(person)) : BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personService.Delete(id);

            return NoContent();
        }
    }
}
