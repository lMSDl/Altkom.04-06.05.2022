using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Adapter.II
{
    class DbPeopleServiceToPeopleServiceAdapter : IPeopleService
    {
        private DbPeopleService _service;

        public DbPeopleServiceToPeopleServiceAdapter(DbPeopleService service)
        {
            _service = service;
        }

        public IEnumerable<Person> GetPeople()
        {
            var people = _service.Get();

            return people.Select(x => Convert(x));
        }

        private static Person Convert(DbPerson x)
        {
            return new Person { Name = $"{x.LastName} {x.FirstName}", Age = DateTime.Now.Year - x.BirthDate.Year };
        }
    }
}
