using CSTL.Models;
using CSTL.Web.DataManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CSTL.DataLayer
{
    public class RegistrationDAL
    {
        private DataAccessManager accessManager = new DataAccessManager();

        public RegistrationDAO SaveUserForm(RegistrationDAO registrationDAO)
        {
            int pk = 0;


            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);

                List<SqlParameter> gSqlParameterList = new List<SqlParameter>();
                gSqlParameterList.Add(new SqlParameter("@FirstName", registrationDAO.FirstName));
                gSqlParameterList.Add(new SqlParameter("@LastName", registrationDAO.LastName));
                gSqlParameterList.Add(new SqlParameter("@Email", registrationDAO.Email));
                gSqlParameterList.Add(new SqlParameter("@Password", registrationDAO.Password));
                gSqlParameterList.Add(new SqlParameter("@Designation", registrationDAO.Designation));
                gSqlParameterList.Add(new SqlParameter("@UserName", registrationDAO.UserName));
                gSqlParameterList.Add(new SqlParameter("@RoleId", registrationDAO.RoleId));
                gSqlParameterList.Add(new SqlParameter("@PhoneNumber", registrationDAO.PhoneNumber));
                //gSqlParameterList.Add(new SqlParameter("@IsActive", registrationDAO.IsActive));
                gSqlParameterList.Add(new SqlParameter("@ProfilePic", registrationDAO.ProfilePic));
                gSqlParameterList.Add(new SqlParameter("@ActiveAccount", registrationDAO.ActiveAccount));

                if (registrationDAO.UserId > 0)
                {
                    gSqlParameterList.Add(new SqlParameter("@UserId", registrationDAO.UserId));
                    bool a = accessManager.UpdateData("sp_AssignUser_Role", gSqlParameterList);
                }
                else
                {
                    pk = accessManager.SaveDataReturnPrimaryKey("sp_Save_Registration", gSqlParameterList);
                    registrationDAO.UserId = pk;
                }

            }
            catch (Exception exception)
            {
                accessManager.SqlConnectionClose(true);


                throw exception;

            }
            finally
            {
                accessManager.SqlConnectionClose();
            }

            return registrationDAO;
        }

        internal List<RegistrationDAO> LoginInfoUSerPassDAL(string userName, string password)
        {
            throw new NotImplementedException();
        }
        public DataTable Get_Designation_List()
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                List<SqlParameter> aSqlParameterlist = new List<SqlParameter>();
                //aSqlParameterlist.Add(new SqlParameter("@CompanyId", comp));
                DataTable dt = accessManager.GetDataTable("sp_Get_Designation");
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                accessManager.SqlConnectionClose();
            }
        }
    }
}