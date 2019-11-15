using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuickChef1._0.Models;

namespace QuickChef1._0.Controllers
{
    public class adminsController : Controller
    {
        //private AdminContext db = new AdminContext();

        // GET: /UserLogin/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UserLogin()
        {
            return View();
        }
        //nombre de mis campos en la tabla adminID passwordAdmin

        //This the Login method. It passes a object of my Model Class named "User".
        [HttpPost]
        public ActionResult UserLogin(admin users)
        {
            if (ModelState.IsValid)
            {
                //message will collect the String value from the model method.
                String message = users.LoginProcess(users.adminID, users.passwordAdmin);
                //RedirectToAction("actionName/ViewName_ActionResultMethodName", "ControllerName");
                if (message.Equals("1"))
                {
                    //this will add cookies for the username.
                    Response.Cookies.Add(new HttpCookie("Users1", users.UserName));
                    //This is a different Controller for the User Homepage. Redirecting after successful process.
                    return RedirectToAction("Index", "AdminHub");
                }
                else
                    ViewBag.ErrorMessage = message;
            }
            return View(users);
        }

    }
}
