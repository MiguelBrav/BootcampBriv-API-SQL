using Brive.Bootcamp2.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp2.API.Services
{
    public interface IPersonService
    {
        List<Person> GetAllPersons();

        Person GetPersonById(int Id);

        Person SavePerson(Person person);

        Person EditedPerson(Person person);

        bool DeletedPerson(Person person);

        List<Person> DeletedPerson2(Person person);

    }
}
