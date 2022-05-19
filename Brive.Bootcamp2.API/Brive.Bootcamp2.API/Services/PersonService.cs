using Brive.Bootcamp2.API.Models;
using Brive.Bootcamp2.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp2.API.Services
{
    public class PersonService : IPersonService
    {
        private Ipersonrepository  _personRepository;
        public PersonService(Ipersonrepository personRepository)
        {
            _personRepository = personRepository;

        }
        public bool deletedPerson2(Person person)
        {
            try
            {
                _personRepository.DeletedPerson(person);
                return true;
            }
            catch
            {
                return false;
            }

                }

        public List<Person> DeletedPerson2(Person person)
        {
            throw new NotImplementedException();
        }

        public Person EditedPerson(Person person)
        {
            return _personRepository.EditedPerson(person);
        }

        public List<Person> GetAllPersons()
        {
            return _personRepository.GetAllPersons();
        }

        public Person GetPersonById(int Id)
        {
            return _personRepository.GetPersonById(Id);
        }

        public Person SavePerson(Person person)
        {
            return _personRepository.SavePerson(person);
        }

        public bool DeletedPerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
