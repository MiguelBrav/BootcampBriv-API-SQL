using Brive.Bootcamp2.API.Models;
using Brive.Bootcamp2.API.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp2.API.Controllers
{
    [EnableCors("Bootcamp")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        //apiBase/controlador/endpoint
        [HttpGet]
        [Route("all")]
        public ActionResult<List<Person>> GetAllPersons()
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _personService.GetAllPersons());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Person> GetPersonById(int id)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _personService.GetPersonById(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [Route("savePerson")]
        public ActionResult<bool> SavePerson([FromBody] Person person)
        {
            try
            {
                person.CreatedDate = DateTime.Now;
                return StatusCode(StatusCodes.Status200OK, _personService.SavePerson(person));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut]
        [Route("editPerson")]
        public ActionResult<Person> EditedPerson([FromBody] Person person)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _personService.EditedPerson(person));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<bool> DeletedPerson(int id)
        {
            try
            {
                Person person = _personService.GetPersonById(id);

                if (person == null)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, null);
                }
                return StatusCode(StatusCodes.Status200OK, _personService.DeletedPerson(person));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete]
        public ActionResult<List<Person>> DeletedPerson2([FromBody] int id)
        {
            try
            {
                Person person = _personService.GetPersonById(id);

                if (person == null)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, null);
                }
                return StatusCode(StatusCodes.Status200OK, _personService.DeletedPerson2(person));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
