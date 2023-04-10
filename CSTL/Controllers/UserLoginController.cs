using CSTL.DataLayer;
using CSTL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSTL.Controllers
{
    public class UserLoginController : Controller
    {
        // GET: UserLogin
        public ActionResult SignIn()
        {
            return View();
        }
        //protected void Application_BeginRequest()
        //{
        //    Response.Cache.SetCacheability(HttpCacheability.NoCache);
        //    Response.Cache.SetExpires(DateTime.UtcNow.AddHours(24));
        //    Response.Cache.SetNoStore();
        //}

        
        [AllowAnonymous]
        public ActionResult   SignOut()
        {
            Session["UserId"] = null;
            Session["UserName"] = null;
            Session["RoleId"] = null;
            return RedirectToAction("SignIn");
        }
        public JsonResult GetLoginInfo(string username, string password)
        {


            LogInDAL logInDAL = new LogInDAL();

            List<RegistrationDAO> lst = logInDAL.LoginInfoUSerPassDAL(username, password);

            string result = "fail";
            if (lst.Count() > 0)
            {
                result = "Success";
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}