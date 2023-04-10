using CSTL.DataLayer;
using CSTL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSTL.Controllers
{
    public class AdminDashboardController : Controller
    {
        private AdminDashDAL adminDashDAL = new AdminDashDAL();
        // GET: AdminDashboard
        public ActionResult Index(int id = 0)
        {
            
            if (Session["UserName"] == null)
            {
                return RedirectToAction("SignIn", "UserLogin");
            }
            else
            {
                if (Session["ActiveAccount"].ToString() == "No")
                {
                    return RedirectToAction("Error404", "Error");
                }
                else
                {
                    //int active = 0;
                    //if (active == 1)
                    if (Session["RoleId"].ToString() == "1" || Session["RoleId"].ToString() == "3" || 
                        Session["RoleId"].ToString() == "2" || Session["RoleId"].ToString() == "4")
                    {
                        ViewBag.Id = id;
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Error404", "Error");
                    }
                }

            }
        }
       
    }
}