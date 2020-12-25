using SampleSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sampleschool.Model;
using SampleSchool.Data;

namespace SampleSchool.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            Persondto Persondata = new Persondto();
            IEnumerable<PersonModel> persons = Persondata.GetPersons();

            return View(persons);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ClassA()
        {
            List<ClassA> classAs = GetClassA();

            ViewBag.Message = "Info of ClassA";
            return View(classAs);
        }
        
        public ActionResult ClassB()
        {
            List<ClassB> classBs = GetClassB();
            ViewBag.Message = "Info related to Class B";

            return View(classBs);
        }

        public ActionResult ClassC()
        {
            List<ClassB> classBs = GetClassB();
            return View(classBs);
        }
        public ActionResult ClassD()
        {
            List<ClassB> classCs = GetClassB();
            return View(classCs);
        }

        private List<ClassA> GetClassA()
        {
           List<ClassA> classAs = new List<ClassA>();

            ClassA objstu = new ClassA();
            objstu.studentId = 1;
            objstu.studentName = "john";
            objstu.sub1 = "Telugu";
            objstu.sub2 = "Hindi";
            objstu.sub3 = "English";

            ClassA objstu2 = new ClassA();
            objstu2.studentId = 2;
            objstu2.studentName = "Mike";
            objstu2.sub1 = "Telugu";
            objstu2.sub2 = "Hindi";
            objstu2.sub3 = "English";

            classAs.Add(objstu);
            classAs.Add(objstu2);

            return classAs;
        }

        private List<ClassB> GetClassB()
        {
            List<ClassB> classBs = new List<ClassB>();

            ClassB objstu = new ClassB();
            objstu.studentId = 1;
            objstu.studentName = "Paul";
            objstu.sub1 = "Computers";
            objstu.sub2 = "Maths";
            objstu.sub3 = "Commerce";

            ClassB objstu2 = new ClassB();
            objstu2.studentId = 2;
            objstu2.studentName = "Steve";
            objstu2.sub1 = "Science";
            objstu2.sub2 = "English";
            objstu2.sub3 = "Computers";

            classBs.Add(objstu);
            classBs.Add(objstu2);

            return classBs;

        }
    }
}