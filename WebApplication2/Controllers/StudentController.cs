using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        static IList<Student> studentList = new List<Student>{
                new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
            };
        // GET: Student
        public ActionResult Index()
        {
            //fetch students from the DB using Entity Framework here

            return View(studentList);
        }

        [HttpPost]
        public ActionResult PostAction() // handles POST requests by default
        {
            return View("Index");
        }


        [HttpPut]
        public ActionResult PutAction() // handles PUT requests by default
        {
            return View("Index");
        }

        [HttpDelete]
        public ActionResult DeleteAction() // handles DELETE requests by default
        {
            return View("Index");
        }

        [HttpHead]
        public ActionResult HeadAction() // handles HEAD requests by default
        {
            return View("Index");
        }

        [HttpOptions]
        public ActionResult OptionsAction() // handles OPTION requests by default
        {
            return View("Index");
        }

        [HttpPatch]
        public ActionResult PatchAction() // handles PATCH requests by default
        {
            return View("Index");
        }

        [AcceptVerbs(HttpVerbs.Post | HttpVerbs.Get)]
        public ActionResult GetAndPostAction()
        {
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            //here, get the student from the database in the real application

            //getting a student from collection for demo purpose
            var std = studentList.Where(s => s.StudentId == Id).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            //update student in DB using EntityFramework in real-life application

            //update list by removing old student and adding updated student for demo purpose
            var student = studentList.Where(s => s.StudentId == std.StudentId).FirstOrDefault();
            studentList.Remove(student);
            studentList.Add(std);

            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            //Ask TempData to keep the data until the next request. Otherwise, Tempdata will discard it.
            TempData.Keep();

            //Empty Student Object
            Student model = new Student();

            //Pass it to the View
            return View(model);

        }

        //[HttpPost]
        //public ActionResult Create()

        //{

        //    //parameter m is filled from the view using ModelBinder
        //    List<Student> Student;

        //    if (ModelState.IsValid)
        //    {
        //    }
        //}

        public ActionResult Details(int Id)
        {
            ////id of the Student to Edit

            //List<Student> Student;
            ////Get Student Collection

            //Student = (List<Student>)TempData["Datastore"];
            ////Get the customer with the selected id from the customers collection

            var student = studentList.Where(s => s.StudentId == Id).FirstOrDefault();
            TempData.Keep();

            //Send it to the view
            return View(student);
        }
    }
}