using Brive.Bootcamp2.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp2.API.Repositories
{
    public interface Ipersonrepository
    {
        List<Person> GetAllPersons();

        Person GetPersonById( int Id);

        Person SavePerson(Person person);

        Person EditedPerson(Person person);

        void DeletedPerson(Person person);


    }
}
