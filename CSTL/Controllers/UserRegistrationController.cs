using CSTL.DataLayer;
using CSTL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSTL.Controllers
{
    public class UserRegistrationController : Controller
    {
        private RegistrationDAL registrationDAL = new RegistrationDAL();
        // GET: UserRegistration
        public ActionResult SignUp()
        {
            return View();
        }
        
        public ActionResult Save_User(RegistrationDAO registrationDAO)
        {
            return Json(registrationDAL.SaveUserForm(registrationDAO), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Show_Designation()
        {

            DataTable dt = registrationDAL.Get_Designation_List();
            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(dt);
            return Json(JSONresult, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult UploadFiles(HttpPostedFileBase file)
        {
            string path = base.Server.MapPath("~/Imagess/User/");
            if (file != null)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                file.SaveAs(string.Concat(path, Path.GetFileName(file.FileName)));
            }
            string fullpath = string.Concat("/Imagess/User/", Path.GetFileName(file.FileName));
            return base.Json(new { link = fullpath, name = file.FileName });
        }
        

    }
}