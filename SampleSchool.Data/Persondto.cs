using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sampleschool.Model;

namespace SampleSchool.Data
{
   public  class Persondto
    {
        public IEnumerable<PersonModel> GetPersons()
        {
         using (var autoContext = new SchoolEntities())
            {
                var  persons = autoContext.People
                    .Select( x => new PersonModel
                    {
                        
                        Id = x.PersonID,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        Discriminator = x.Discriminator,
                        HireDate = x.HireDate
                    }).ToList();

                return persons;

            }
            
        }

    }
}
