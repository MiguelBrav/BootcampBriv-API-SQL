using Brive.Bootcamp2.API.Contexts;
using Brive.Bootcamp2.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp2.API.Repositories
{
    public class PersonRepository : Ipersonrepository



    {
        private readonly BootcampContext _context;
        public PersonRepository(BootcampContext context)
        {
            _context = context;
        }
        public void DeletedPerson(Person person)
        {
            _context.Person.Remove(person);
            _context.SaveChanges();
        }

        public Person EditedPerson(Person person)
        {
            Person editedPerson = _context.Person.Find(person.Id);
            if (editedPerson == null)
                return null;

            editedPerson.Name = person.Name;
            editedPerson.Age = person.Age;
            editedPerson.Email = person.Email;
            _context.Person.Update(editedPerson);
            _context.SaveChanges();

            return editedPerson;
        }

        public List<Person> GetAllPersons()
        {
            return _context.Person.ToList();
        }

        public Person GetPersonById(int Id)
        {
            return _context.Person.Find(Id);
        }

        public Person SavePerson(Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();
            return person;

        }
    }
}
