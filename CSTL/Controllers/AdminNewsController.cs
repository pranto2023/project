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
    public class AdminNewsController : Controller
    {
        private AdminNewsDAL adminNewsDAL = new AdminNewsDAL();
        // GET: NewsAdmin
        [ValidateInput(false)]
        public ActionResult NewsEntry(int id = 0)
        {
            ViewBag.Id = id;
            return View();
        }
        [ValidateInput(false)]
        public ActionResult NewsList(int id = 0)
        {
            ViewBag.Id = id;
            return View();
        }
        [ValidateInput(false)]
        public ActionResult Save_Admin_Data(NewsDAO newsDAO)
        {
            newsDAO.EntryDate = DateTime.Now;
            return Json(adminNewsDAL.Save_Admin_Post(newsDAO), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Show_Catagory()
        {

            DataTable dt = adminNewsDAL.Get_Catagory_List();
            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(dt);
            return Json(JSONresult, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        [ValidateInput(false)]
        public ActionResult UploadFiles(HttpPostedFileBase file, string psdetails, string pfdetails,
           string avl, string latestp, string featuredP, string pname, string pquantity, int catagory)
        {
            string path = base.Server.MapPath("~/Imagess/Blog/");
            if (file != null)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                file.SaveAs(string.Concat(path, Path.GetFileName(file.FileName)));
            }
            string fullpath = string.Concat("/Imagess/Blog/", Path.GetFileName(file.FileName));
            return base.Json(new
            {
                link = fullpath,
                psdetails = psdetails,
                pquantity = pquantity,
                pname = pname,
                pfdetails = pfdetails,
                catagory = catagory,
                avl = avl,
                latestp = latestp,
                featuredP = featuredP,
                name = file.FileName
            });
        }
        public ActionResult Show_Product()
        {
            DataTable dt = adminNewsDAL.Get_News_List();
            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(dt);
            return Json(JSONresult, JsonRequestBehavior.AllowGet);
        }
    }
}