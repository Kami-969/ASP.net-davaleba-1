using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public string print(string name, int Age)
        {
            return $"Name : {name} Age = {Age}";
        }

        public string objprint(Users users)
        {
            return $"Age : {users.id} Name = {users.user}";
        }
        
        public ActionResult Anon ()
        {
            var student = new { First = "Kami", Last = "Yakimas" };

            return Json(student, JsonRequestBehavior.AllowGet);


        }

        
    }
   
  
}
