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
    public class AdminDashDAL
    {
        private DataAccessManager accessManager = new DataAccessManager();
        public DataTable Get_Orders()
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                List<SqlParameter> aSqlParameterlist = new List<SqlParameter>();
                //aSqlParameterlist.Add(new SqlParameter("@param", param));
                DataTable dt = accessManager.GetDataTable("sp_Get_OrderListDash");
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

        public DataTable Get_Monthly_Order()
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                List<SqlParameter> aSqlParameterlist = new List<SqlParameter>();
                //aSqlParameterlist.Add(new SqlParameter("@UploadBy", UserN));
                DataTable dt = accessManager.GetDataTable("sp_Count_Order");
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
        public DataTable Get_Monthly_Invoice()
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                List<SqlParameter> aSqlParameterlist = new List<SqlParameter>();
                //aSqlParameterlist.Add(new SqlParameter("@UploadBy", UserN));
                DataTable dt = accessManager.GetDataTable("sp_Count_Invoice");
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
        public DataTable Get_Monthly_Income()
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                List<SqlParameter> aSqlParameterlist = new List<SqlParameter>();
                //aSqlParameterlist.Add(new SqlParameter("@UploadBy", UserN));
                DataTable dt = accessManager.GetDataTable("sp_Sum_Monthly_Earning");
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
        

        public DataTable Get_Year_Amount(string currentyear)
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                List<SqlParameter> aSqlParameterlist = new List<SqlParameter>();
                aSqlParameterlist.Add(new SqlParameter("@Year", currentyear));
                DataTable dt = accessManager.GetDataTable("sp_Terget_Year_Amount", aSqlParameterlist);
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
        public DataTable Get_Month_Amount(string currentmonth)
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                List<SqlParameter> aSqlParameterlist = new List<SqlParameter>();
                aSqlParameterlist.Add(new SqlParameter("@Month", currentmonth));
                DataTable dt = accessManager.GetDataTable("sp_Terget_Month_Amount", aSqlParameterlist);
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
       
        public DataTable Get_Order_IdByList(int id)
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                List<SqlParameter> aSqlParameterlist = new List<SqlParameter>();
                aSqlParameterlist.Add(new SqlParameter("@OrderId", id));
                DataTable dt = accessManager.GetDataTable("sp_Get_Order_Dasboard", aSqlParameterlist);
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
        public RegistrationDAO Get_User_By_Id(int userid)
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                RegistrationDAO master = new RegistrationDAO();
                List<SqlParameter> aSqlParameters = new List<SqlParameter>();
                aSqlParameters.Add(new SqlParameter("@UserId", userid));
                SqlDataReader dr = accessManager.GetSqlDataReader("sp_Get_User_Details_By_Id", aSqlParameters);
                while (dr.Read())
                {

                    master.UserId = (int)dr["UserId"];

                    master.FirstName = dr["FirstName"].ToString();
                    master.LastName = dr["LastName"].ToString();
                    master.PhoneNumber = dr["PhoneNumber"].ToString();
                    master.Email = dr["Email"].ToString();
                    master.NID = dr["NID"].ToString();
                    master.Address = dr["Address"].ToString();
                    master.SalaryAccNO = dr["SalaryAccNO"].ToString();
                    master.ProfilePic = dr["ProfilePic"].ToString();


                }
                return master;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                accessManager.SqlConnectionClose();
            }

        }
    }
}