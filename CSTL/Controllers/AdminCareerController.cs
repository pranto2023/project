using CSTL.DataLayer;
using CSTL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace CSTL.Controllers
{
    public class AdminCareerController : Controller
    {
        // GET: AdminCareer
        AdminCareerDAL adminCareerDAL = new AdminCareerDAL();
        public ActionResult JobEntry(int id = 0)
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
                    if (Session["RoleId"].ToString() == "1" || Session["RoleId"].ToString() == "3" || Session["RoleId"].ToString() == "2" || Session["RoleId"].ToString() == "4")
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
        public ActionResult JobCatagory(int id = 0)
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
                    int active = 0;
                    if (active == 1)
                    //if (Session["RoleId"].ToString() == "1" || Session["RoleId"].ToString() == "3" || Session["RoleId"].ToString() == "2" || Session["RoleId"].ToString() == "4")
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
        public ActionResult JobApplicationByEntry(int id = 0)
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
                 
                   
                    if (Session["RoleId"].ToString() == "1" || Session["RoleId"].ToString() == "3" || Session["RoleId"].ToString() == "2" || Session["RoleId"].ToString() == "4")
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
        public ActionResult JobApplicationByCV(int id = 0)
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
                    if (Session["RoleId"].ToString() == "1" || Session["RoleId"].ToString() == "3" || Session["RoleId"].ToString() == "2" || Session["RoleId"].ToString() == "4")
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
        public ActionResult MscBscDegree(int id = 0)
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
                    if (Session["RoleId"].ToString() == "1" || Session["RoleId"].ToString() == "3" || Session["RoleId"].ToString() == "2" || Session["RoleId"].ToString() == "4")
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

        public ActionResult Show_Job_Application()
        {
            DataTable dt = adminCareerDAL.Get_Job_Application();
            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(dt);
            return Json(JSONresult, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Show_Job_Application_CV()
        {
            DataTable dt = adminCareerDAL.Get_Job_Application_CV();
            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(dt);
            return Json(JSONresult, JsonRequestBehavior.AllowGet);
        }


        [ValidateInput(false)]
        public ActionResult Save_Admin_PCatagory(CareerDAO allDAO)
        {
            allDAO.JobEntryDate = DateTime.Now;
            allDAO.UploadBy = Session["UserId"].ToString();
            return Json(adminCareerDAL.Save_Admin_Post(allDAO), JsonRequestBehavior.AllowGet);
        }
        [ValidateInput(false)]
        public ActionResult Save_Admin_JobCat(JobCatDAO allDAO)
        {
            return Json(adminCareerDAL.Save_Admin_Post_JobCat(allDAO), JsonRequestBehavior.AllowGet);
        }
        [ValidateInput(false)]
        public ActionResult Save_BscDegree(BSCDEGREEDAO allDAO)
        {
            return Json(adminCareerDAL.Save_Admin_BscDegree(allDAO), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Save_Msc_Degree(MSCDEGREEDAO allDAO)
        {
            return Json(adminCareerDAL.Save_Admin_MscDegree(allDAO), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Show_Catagory()
        {

            DataTable dt = adminCareerDAL.Get_Catagory_List();
            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(dt);
            return Json(JSONresult, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Show_ApplicationEntry_Id(int id)
        {
            return Json(adminCareerDAL.Get_ApplicationEntry_Id(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult ShowEmail_Id(int id)
        {
            return Json(adminCareerDAL.GetEmail_Id(id), JsonRequestBehavior.AllowGet);
        }



        public ActionResult Show_ApplicationEntry_Expricen(int id)
        {
            DataTable dt = adminCareerDAL.Get_ApplicationEntry_Expricen(id);
            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(dt);
            return Json(JSONresult, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        [ValidateInput(false)]
        public ActionResult UploadFiles(HttpPostedFileBase file)
        {
            string path = base.Server.MapPath("~/Imagess/Career/");
            if (file != null)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                file.SaveAs(string.Concat(path, Path.GetFileName(file.FileName)));
            }
            string fullpath = string.Concat("/Imagess/Career/", Path.GetFileName(file.FileName));
            return base.Json(new { link = fullpath, name = file.FileName });
        }

        public ActionResult SendMail(string FName,string LName, string EmailId, string Subject, string Message,DateTime MeetDate)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(EmailId);
                mail.From = new MailAddress("clashofclanxw@gmail.com");
                mail.Subject = Subject;

                string userMessage = "";
                userMessage = "<br/>Name :" + FName + LName;
                userMessage = userMessage + "<br/>Email Id: " + EmailId;
                userMessage = userMessage + "<br/>Message: " + MeetDate;
                string Body = "Hi, <br/><br/> Thanks for contact us,our team will be contact you as soon as possible<br/><br/> " + userMessage + "<br/><br/>Thanks";


                mail.Body = Body;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                //SMTP Server Address of gmail
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("clashofclanxw@gmail.com", "walton113307");
                // Smtp Email ID and Password For authentication
                smtp.EnableSsl = true;
                smtp.Send(mail);
                ViewBag.Message = "<Script>alert('Thanks for contact us,our team will be contact you as soon as possible')</Script";
            }
            catch
            {
                ViewBag.Message = "Error............";
            }

            return View();
        }



    }
}