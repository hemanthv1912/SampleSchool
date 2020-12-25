using Sampleschool.Model;
using SampleSchool.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleSchool.Controllers
{
    public class PersonsController : Controller
    {
        // GET: Persons
        public ActionResult Index()
        {
            Persondto Persondata = new Persondto();
            IEnumerable<PersonModel> persons = Persondata.GetPersons();

            return View(persons);
            
        }
    }
}