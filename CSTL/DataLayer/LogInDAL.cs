using CSTL.Models;
using CSTL.Web.DataManager;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CSTL.DataLayer
{
    public class LogInDAL
    {
        private DataAccessManager accessManager = new DataAccessManager();
        public List<RegistrationDAO> LoginInfoUSerPassDAL(string username, string password)
        {
            try
            {
                List<RegistrationDAO> aList = new List<RegistrationDAO>();
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                List<SqlParameter> aSqlParameterlist = new List<SqlParameter>();
                aSqlParameterlist.Add(new SqlParameter("@UserName", username));
                aSqlParameterlist.Add(new SqlParameter("@Password", password));
                SqlDataReader dr = accessManager.GetSqlDataReader("sp_Login_User", aSqlParameterlist);

                RegistrationDAO aDao;

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        aDao = new RegistrationDAO();
                        aDao.UserId = (int)dr["UserId"];
                        aDao.UserName = dr["UserName"].ToString();
                        aDao.FirstName = dr["FirstName"].ToString();
                        aDao.LastName = dr["LastName"].ToString();
                        aDao.Email = dr["Email"].ToString();
                        aDao.Password = dr["Password"].ToString();
                        aDao.ProfilePic = dr["ProfilePic"].ToString();
                        aDao.Designation = (int)dr["Designation"];
                        aDao.PhoneNumber = dr["PhoneNumber"].ToString();
                        aDao.ActiveAccount = dr["ActiveAccount"].ToString();
                        aDao.RoleId = (int)dr["RoleId"];
                        //aDao.IsActive = (bool)dr["IsActive"];

                        HttpContext.Current.Session["UserId"] = aDao.UserId;
                        HttpContext.Current.Session["UserName"] = aDao.UserName;
                        HttpContext.Current.Session["FullName"] = aDao.FirstName;
                        HttpContext.Current.Session["LastName"] = aDao.LastName;
                        HttpContext.Current.Session["Email"] = aDao.Email;
                        HttpContext.Current.Session["Password"] = aDao.Password;
                        HttpContext.Current.Session["ProfilePic"] = aDao.ProfilePic;
                        HttpContext.Current.Session["Designation"] = aDao.Designation;
                        HttpContext.Current.Session["PhoneNumber"] = aDao.PhoneNumber;
                        HttpContext.Current.Session["RoleId"] = aDao.RoleId;
                        HttpContext.Current.Session["ActiveAccount"] = aDao.ActiveAccount;
                        //HttpContext.Current.Session["IsActive"] = aDao.IsActive;

                        aList.Add(aDao);
                    }
                }
                return aList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                accessManager.SqlConnectionClose();
            }
        }
    }
}