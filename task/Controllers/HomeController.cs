using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using task.Models;

namespace task.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult CreateDepartment()
        {
            return View();
        }
        public ActionResult CreateUser()
        {
            datacontroller temp = new datacontroller();
            List<Department> departments =temp.Departments.ToList<Department>();
            List<int> departmentid = new List<int>();
            if (departments.Count > 0)
            {

                departments.ForEach(e1 => departmentid.Add(e1.DepartmentId));
                SelectList listItems = new SelectList(departmentid);
                ViewBag.Departmentid =listItems;
                return View();
            }
            else
                return HttpNotFound("I did not find message goes here");

        }
        public void ADDUSER(User user)
        {
            datacontroller temp = new datacontroller();
            temp.Users.Add(user);
            temp.SaveChanges();
        }
        public ViewResult Editstudent()
        {

            return View();
        }
        public void ADDDEPARTMENt(Department department)
        {
            datacontroller temp = new datacontroller();
            temp.Departments.Add(department);
            temp.SaveChanges();
            RedirectToAction("Index");
        }
        public ActionResult GetListofregisteredusers()
        {
            datacontroller data = new datacontroller();
            var query = from r in data.Users
                        group r by r.DepartmentId into g
                        select new
                        {
                            DepartmentId = g.Key,
                            User = g.Count()
                        };
            
            return View(query.ToList());
        }
        public JsonResult UsersData()
        {
            return Json(User, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}