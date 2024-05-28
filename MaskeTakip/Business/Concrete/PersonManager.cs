using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager
    {
        public void ApplyForMask(Person person)
        {
            Console.WriteLine("Added!");
        }

        public List<Person> GetList()
        {
            return null;
        }
    }
}
