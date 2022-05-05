using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.DesignPatterns.Structural.Adapter.II
{
    public class DbPeopleService
    {
        public IEnumerable<DbPerson> _people = new List<DbPerson> { new DbPerson { FirstName = "Ewa", LastName = "Ewowska", BirthDate = DateTime.Now.AddYears(-25) } };

        public IEnumerable<DbPerson> Get()
        {
            return _people.ToList();
        }
    }
}