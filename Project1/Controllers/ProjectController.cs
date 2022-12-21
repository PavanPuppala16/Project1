using Microsoft.AspNetCore.Mvc;
using System.Data;
using Project1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System.Configuration;
using Project1.BusinessLogic_bl;
using System.Data.SqlClient;
using System.Reflection;


namespace Project1.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult LOGIN()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LOGIN(AdminLogin OBJ)
        {
            if (ModelState.IsValid)
            {
                DataTable dt = new DataTable();
                dt = MainLogic.login(OBJ);

                if (dt.Rows.Count > 0)
                {

                    return RedirectToAction("Index");
                }

                else
                {
                    return View(OBJ);
                }
            }
            else
            {
                return View();
            }
        }
        [HttpGet]

        public IActionResult REGISTER()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult REGISTER(MainModel OBJ)
        {
            ViewBag.Message = "formsubmitted";
            if (ModelState.IsValid)
            {
                bool res = MainLogic.Insertdata(OBJ);

                if (res == true)
                {

                    return View("LOGIN");
                }
                else
                {
                    return View(OBJ);
                }
            }
            else
            {
                return View(OBJ);
            }
        }
       
        public IActionResult ADMINUSER()
        {
            return View();
        }
        
        [HttpGet]

        public IActionResult STUDENTADD()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult STUDENTADD(GenericInfo OBJ)
        {
            ViewBag.Message = "formsubmitted";
            if (ModelState.IsValid)
            {
                bool res = StudentADD.Insertdata(OBJ);

                if (res == true)
                {

                    return RedirectToAction("SSCDetails");
                }
                else
                {
                    return View(OBJ);
                }
            }
            else
            {
                return View(OBJ);
            }
        }


        
        [HttpGet]

        public IActionResult SSCDetails()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SSCDetails(Schooling OBJ)
        {
            ViewBag.Message = "formsubmitted";
            if (ModelState.IsValid)
            {
                bool res = StudentADD.InsertSsc(OBJ);

                if (res == true)
                {

                    return RedirectToAction("Intermediate");
                }
                else
                {
                    return View(OBJ);
                }
            }
            else
            {
                return View(OBJ);
            }
        }
        [HttpGet]

        public IActionResult Intermediate()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Intermediate(Intermediate OBJ)
        {
            ViewBag.Message = "formsubmitted";
            if (ModelState.IsValid)
            {
                bool res = StudentADD.InsertIntermediate(OBJ);

                if (res == true)
                {

                    return RedirectToAction("Graduation");
                }
                else
                {
                    return View(OBJ);
                }
            }
            else
            {
                return View(OBJ);
            }
        }

        [HttpGet]

        public IActionResult Graduation()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Graduation(Graduation OBJ)
        {
            ViewBag.Message = "formsubmitted";
            if (ModelState.IsValid)
            {
                bool res = StudentADD.InsertGraduation(OBJ);

                if (res == true)
                {

                    return RedirectToAction("Family");
                }
                else
                {
                    return View(OBJ);
                }
            }
            else
            {
                return View(OBJ);
            }
        }
        [HttpGet]
        public IActionResult Family()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Family(Family OBJ)
        {
            ViewBag.Message = "formsubmitted";
            if (ModelState.IsValid)
            {
                bool res = StudentADD.InsertFamily(OBJ);

                if (res == true)
                {

                    return RedirectToAction("Upload","File");
                }
                else
                {
                    return View(OBJ);
                }
            }
            else
            {
                return View(OBJ);
            }
        }
        
        public IActionResult condition()
        {
            
            return View();
        }
    }
}
