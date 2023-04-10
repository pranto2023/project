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
    public class CareerController : Controller
    {
        // GET: Career
        CareerDAL careerDAL = new CareerDAL();
        public ActionResult JobCercular()
        {
            List<CareerDAO> careerDAOs = GetJobAll();
            ViewBag.careerDAO = careerDAOs;
            return View();
        }
        public List<CareerDAO> GetJobAll()
        {
            List<CareerDAO> careerDAOs = new List<CareerDAO>();
            DataTable dataTable = new DataTable();
            dataTable = careerDAL.Get_Jobs();

            foreach (DataRow row in dataTable.Rows)
            {
                CareerDAO career = new CareerDAO();
                career.JobId = (int)row["JobId"];
                career.JobName = row["JobName"].ToString();
                career.JobShortDescription = row["JobShortDescription"].ToString();
                
                careerDAOs.Add(career);
            }
            return careerDAOs;
        }
        public ActionResult ApplyWith(int id =0)
        {
            ViewBag.Id = id;
            return View();
        }
        public ActionResult ApplyJob(int id =0)
        {
            ViewBag.Id = id;
            return View();
        }

        public ActionResult ApplyJobConfirm(int id =0)
        {
            ViewBag.Id = id;
            return View();
        }

        [ValidateInput(false)]
        public ActionResult Save_Job_Application(JobApplicationDAO allDAO)
        {
            allDAO.AppliedDate = DateTime.Now;
            return Json(careerDAL.Save_Job_Application_Manually(allDAO), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Save_Job_CV(ApplyViaCVDAO allDAO)
        {
            allDAO.AppliedDate = DateTime.Now;
            return Json(careerDAL.Save_Job_Application_Resume(allDAO), JsonRequestBehavior.AllowGet);
        }

        [ValidateInput(false)]
        public ActionResult Save_Job_Exp(ExprienceDAO allDAO)
        {
            //allDAO.EntryBy = Session["UserName"].ToString();
            return Json(careerDAL.Save_Exprience(allDAO), JsonRequestBehavior.AllowGet);
        }


        public ActionResult Show_Bsc_Degree()
        {
            DataTable dt = careerDAL.Get_Bsc_Degree();
            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(dt);
            return Json(JSONresult, JsonRequestBehavior.AllowGet);
        }
        

        public ActionResult Show_Job_By_Id(int id)
        {
            return Json(careerDAL.Get_Job_By_Id(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Show_Msc_Degree()
        {
            DataTable dt = careerDAL.Get_Msc_Degree();
            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(dt);
            return Json(JSONresult, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult UploadFiles(HttpPostedFileBase file)
        {
            string path = base.Server.MapPath("~/Files/CV/");
            if (file != null)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                file.SaveAs(string.Concat(path, Path.GetFileName(file.FileName)));
            }
            string fullpath = string.Concat("/Files/CV/", Path.GetFileName(file.FileName));
            return base.Json(new { link = fullpath, name = file.FileName });
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult UploadFilesx(HttpPostedFileBase file)
        {
            string path = base.Server.MapPath("~/Files/ApplicantImages/");
            if (file != null)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                file.SaveAs(string.Concat(path, Path.GetFileName(file.FileName)));
            }
            string fullpath = string.Concat("/Files/ApplicantImages/", Path.GetFileName(file.FileName));
            return base.Json(new { link = fullpath, name = file.FileName });
        }

            public ActionResult ContactUs()
            {
               
                return View();
            }

        
}
}