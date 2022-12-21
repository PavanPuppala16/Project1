using Microsoft.AspNetCore.Mvc;
using Project1.BusinessLogic_bl;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Project1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System.Configuration;

using System.Data.SqlClient;
using System.Reflection;

namespace Project1.Controllers
{

    public class LEVEL1Controller : Controller
    {
        [HttpGet]
        public IActionResult Backlog()
        {
            return View(level.GetData());
        }
        [HttpGet]
        public IActionResult Condition()
        {
            return View(student.checking());
        }
        [HttpGet]
        public IActionResult Totaldata()
        {
            return View(student.GetData1());
        }
    }
}
