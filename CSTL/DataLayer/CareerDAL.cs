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
    public class CareerDAL
    {
        private DataAccessManager accessManager = new DataAccessManager();



        public JobApplicationDAO Save_Job_Application_Manually(JobApplicationDAO orderDAO)
        {
            int pk = 0;
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);

                List<SqlParameter> gSqlParameterList = new List<SqlParameter>();
                gSqlParameterList.Add(new SqlParameter("@First", orderDAO.First));
                gSqlParameterList.Add(new SqlParameter("@Last", orderDAO.Last));
                gSqlParameterList.Add(new SqlParameter("@Email", orderDAO.Email));
                gSqlParameterList.Add(new SqlParameter("@Address", orderDAO.Address));
                gSqlParameterList.Add(new SqlParameter("@Phone", orderDAO.Phone));
                gSqlParameterList.Add(new SqlParameter("@NID", orderDAO.NID));
                gSqlParameterList.Add(new SqlParameter("@SSCResult", orderDAO.SSCResult));
                gSqlParameterList.Add(new SqlParameter("@HSCResult", orderDAO.HSCResult));
                gSqlParameterList.Add(new SqlParameter("@UniversityResult", orderDAO.UniversityResult));
                gSqlParameterList.Add(new SqlParameter("@UniversityId", orderDAO.UniversityId));
                gSqlParameterList.Add(new SqlParameter("@MastarsResult", orderDAO.MastarsResult));
                gSqlParameterList.Add(new SqlParameter("@Picture", orderDAO.Picture));
                gSqlParameterList.Add(new SqlParameter("@SchoolName", orderDAO.SchoolName));
                gSqlParameterList.Add(new SqlParameter("@CollegeName", orderDAO.CollegeName));
                gSqlParameterList.Add(new SqlParameter("@UniversityName", orderDAO.UniversityName));
                gSqlParameterList.Add(new SqlParameter("@MUniversityName", orderDAO.MUniversityName));
                gSqlParameterList.Add(new SqlParameter("@SSCPassDate", orderDAO.SSCPassDate));
                gSqlParameterList.Add(new SqlParameter("@HSCPassDate", orderDAO.HSCPassDate));
                gSqlParameterList.Add(new SqlParameter("@UniversityPassDate", orderDAO.UniversityPassDate));
                gSqlParameterList.Add(new SqlParameter("@MastarsPassDate", orderDAO.MastarsPassDate));
                //gSqlParameterList.Add(new SqlParameter("@ExprienceId", orderDAO.ExprienceId));
                gSqlParameterList.Add(new SqlParameter("@MastarsId", orderDAO.MastarsId));
                gSqlParameterList.Add(new SqlParameter("@JobId", orderDAO.JobId));
                gSqlParameterList.Add(new SqlParameter("@AppliedDate", orderDAO.AppliedDate));

                //if (orderDAO.ServiceId > 0)
                //{
                //    gSqlParameterList.Add(new SqlParameter("@ServiceId", orderDAO.ServiceId));
                //    bool a = accessManager.UpdateData("sp_Update_HrmsList", gSqlParameterList);
                //}
                //else
                //{
                pk = accessManager.SaveDataReturnPrimaryKey("sp_Save_JobApplication", gSqlParameterList);
                orderDAO.ApplicantId = pk;
                //}
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
            return orderDAO;
        }
        public ApplyViaCVDAO Save_Job_Application_Resume(ApplyViaCVDAO orderDAO)
        {
            int pk = 0;
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);

                List<SqlParameter> gSqlParameterList = new List<SqlParameter>();
                gSqlParameterList.Add(new SqlParameter("@Resume", orderDAO.Resume));
                gSqlParameterList.Add(new SqlParameter("@JobId", orderDAO.JobId));
                gSqlParameterList.Add(new SqlParameter("@AppliedDate", orderDAO.AppliedDate));

                //if (orderDAO.ServiceId > 0)
                //{
                //    gSqlParameterList.Add(new SqlParameter("@ServiceId", orderDAO.ServiceId));
                //    bool a = accessManager.UpdateData("sp_Update_HrmsList", gSqlParameterList);
                //}
                //else
                //{
                pk = accessManager.SaveDataReturnPrimaryKey("sp_Save_Job_By_CV", gSqlParameterList);
                orderDAO.CVId = pk;
                //}
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
            return orderDAO;
        }
        public CareerDAO Get_Job_By_Id(int id)
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                CareerDAO master = new CareerDAO();
                List<SqlParameter> aSqlParameters = new List<SqlParameter>();
                aSqlParameters.Add(new SqlParameter("@JobId", id));
                SqlDataReader dr = accessManager.GetSqlDataReader("sp_Get_Job_Cer_By_id", aSqlParameters);
                while (dr.Read())
                {

                    master.JobId = (int)dr["JobId"];
                    master.JobName = dr["JobName"].ToString();
                    master.JobShortDescription = dr["JobShortDescription"].ToString();
                    master.JobFullDescription = dr["JobFullDescription"].ToString();
                    master.JobApplyLastDate = Convert.ToDateTime(dr["JobApplyLastDate"].ToString());



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
        public ExprienceDAO Save_Exprience(ExprienceDAO orderDAO)
        {
            int pk = 0;
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);

                List<SqlParameter> gSqlParameterList = new List<SqlParameter>();
                gSqlParameterList.Add(new SqlParameter("@ApplicantId", orderDAO.ApplicantId));
                gSqlParameterList.Add(new SqlParameter("@CompanyName", orderDAO.CompanyName));
                gSqlParameterList.Add(new SqlParameter("@Designation", orderDAO.Designation));
                gSqlParameterList.Add(new SqlParameter("@Duration", orderDAO.Duration));
                //if (orderDAO.ServiceId > 0)
                //{
                //    gSqlParameterList.Add(new SqlParameter("@ServiceId", orderDAO.ServiceId));
                //    bool a = accessManager.UpdateData("sp_Update_HrmsList", gSqlParameterList);
                //}
                //else
                //{
                pk = accessManager.SaveDataReturnPrimaryKey("sp_Save_Exprience", gSqlParameterList);
                orderDAO.ExprienceId = pk;
                //}
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
            return orderDAO;
        }




        public DataTable Get_Jobs()
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                List<SqlParameter> aSqlParameterlist = new List<SqlParameter>();
                DataTable dt = accessManager.GetDataTable("sp_Get_JobsAll");
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


        public DataTable Get_Bsc_Degree()
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                List<SqlParameter> aSqlParameterlist = new List<SqlParameter>();
                //aSqlParameterlist.Add(new SqlParameter("@param", param));
                DataTable dt = accessManager.GetDataTable("sp_Get_Bsc_Degree");
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
        

        public DataTable Get_Msc_Degree()
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                List<SqlParameter> aSqlParameterlist = new List<SqlParameter>();
                //aSqlParameterlist.Add(new SqlParameter("@param", param));
                DataTable dt = accessManager.GetDataTable("sp_Get_Msc_Degree");
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