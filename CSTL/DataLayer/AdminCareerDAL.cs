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
    public class AdminCareerDAL
    {
        private DataAccessManager accessManager = new DataAccessManager();

        public MSCDEGREEDAO Save_Admin_MscDegree(MSCDEGREEDAO careerDAO)
        {
            int pk = 0;


            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);

                List<SqlParameter> gSqlParameterList = new List<SqlParameter>();
                //gSqlParameterList.Add(new SqlParameter("@Id", crtxRegDAO.Id));
                gSqlParameterList.Add(new SqlParameter("@MscDegree", careerDAO.MscDegree));

                if (careerDAO.MastarsId > 0)
                {
                    gSqlParameterList.Add(new SqlParameter("@MastarsId", careerDAO.MastarsId));
                    bool a = accessManager.UpdateData("sp_Update_JobCatagory", gSqlParameterList);
                }
                else
                {

                    pk = accessManager.SaveDataReturnPrimaryKey("sp_Save_Mastars_Degree", gSqlParameterList);
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

            return careerDAO;
        }
        public BSCDEGREEDAO Save_Admin_BscDegree(BSCDEGREEDAO careerDAO)
        {
            int pk = 0;


            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);

                List<SqlParameter> gSqlParameterList = new List<SqlParameter>();
                //gSqlParameterList.Add(new SqlParameter("@Id", crtxRegDAO.Id));
                gSqlParameterList.Add(new SqlParameter("@DegreeName", careerDAO.DegreeName));

                if (careerDAO.UniversityId > 0)
                {
                    gSqlParameterList.Add(new SqlParameter("@UniversityId", careerDAO.UniversityId));
                    bool a = accessManager.UpdateData("sp_Update_JobCatagory", gSqlParameterList);
                }
                else
                {

                    pk = accessManager.SaveDataReturnPrimaryKey("sp_Save_Bechelor_Degree", gSqlParameterList);
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

            return careerDAO;
        }



        public JobCatDAO Save_Admin_Post_JobCat(JobCatDAO careerDAO)
        {
            int pk = 0;


            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);

                List<SqlParameter> gSqlParameterList = new List<SqlParameter>();
                //gSqlParameterList.Add(new SqlParameter("@Id", crtxRegDAO.Id));
                gSqlParameterList.Add(new SqlParameter("@JobCatName", careerDAO.JobCatName));

                if (careerDAO.JobCatId > 0)
                {
                    gSqlParameterList.Add(new SqlParameter("@JobCatName", careerDAO.JobCatId));
                    bool a = accessManager.UpdateData("sp_Update_JobCatagory", gSqlParameterList);
                }
                else
                {

                    pk = accessManager.SaveDataReturnPrimaryKey("sp_Save_JobCatagory", gSqlParameterList);
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

            return careerDAO;
        }

        public DataTable Get_ApplicationEntry_Expricen(int id)
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                List<SqlParameter> aSqlParameterlist = new List<SqlParameter>();
                aSqlParameterlist.Add(new SqlParameter("@ApplicantId", id));
                DataTable dt = accessManager.GetDataTable("sp_Get_Get_ApplicationEntry_Expricen", aSqlParameterlist);
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

        public JobApplicationDAO GetEmail_Id(int id)
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                JobApplicationDAO master = new JobApplicationDAO();
                List<SqlParameter> aSqlParameters = new List<SqlParameter>();
                aSqlParameters.Add(new SqlParameter("@ApplicantId", id));
                SqlDataReader dr = accessManager.GetSqlDataReader("sp_Get_ApplicationEntry_Id", aSqlParameters);
                while (dr.Read())
                {

                    master.ApplicantId = (int)dr["ApplicantId"];
                    master.First = dr["First"].ToString();
                    master.Last = dr["Last"].ToString();
                    master.Email = dr["Email"].ToString();                    
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
        public JobApplicationDAO Get_ApplicationEntry_Id(int id)
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                JobApplicationDAO master = new JobApplicationDAO();
                List<SqlParameter> aSqlParameters = new List<SqlParameter>();
                aSqlParameters.Add(new SqlParameter("@ApplicantId", id));
                SqlDataReader dr = accessManager.GetSqlDataReader("sp_Get_ApplicationEntry_Id", aSqlParameters);
                while (dr.Read())
                {

                    master.ApplicantId = (int)dr["ApplicantId"];
                    master.First = dr["First"].ToString();
                    master.Last = dr["Last"].ToString();
                    master.Email = dr["Email"].ToString();
                    master.Address = dr["Address"].ToString();
                    master.Phone = dr["Phone"].ToString();

                    master.SSCResult = dr["SSCResult"].ToString();
                    master.HSCResult = dr["HSCResult"].ToString();
                    master.UniversityResult = dr["UniversityResult"].ToString();
                    master.MastarsResult = dr["MastarsResult"].ToString();

                    master.SchoolName = dr["SchoolName"].ToString();
                    master.CollegeName = dr["CollegeName"].ToString();
                    master.UniversityName = dr["UniversityName"].ToString();
                    master.MUniversityName = dr["MUniversityName"].ToString();
                    master.MscDegree = dr["MscDegree"].ToString();
                    master.DegreeName = dr["DegreeName"].ToString();

                    master.SSCPassDate = Convert.ToDateTime(dr["SSCPassDate"].ToString());
                    master.HSCPassDate = Convert.ToDateTime(dr["HSCPassDate"].ToString());
                    master.UniversityPassDate = Convert.ToDateTime(dr["UniversityPassDate"].ToString());
                    master.MastarsPassDate = Convert.ToDateTime(dr["MastarsPassDate"].ToString());

                    master.AppliedDate = Convert.ToDateTime(dr["AppliedDate"].ToString());

                    master.NID = dr["NID"].ToString();
                    //master.ExprienceId = (int)dr["ExprienceId"];

                    master.MastarsId = (int)dr["MastarsId"];
                    master.UniversityId = (int)dr["UniversityId"];

                    master.Picture = dr["Picture"].ToString();



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
        public DataTable Get_Job_Application()
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                List<SqlParameter> aSqlParameterlist = new List<SqlParameter>();
                //aSqlParameterlist.Add(new SqlParameter("@param", param));
                DataTable dt = accessManager.GetDataTable("sp_Get_ApplyJob_by_Entry");
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
        public DataTable Get_Job_Application_CV()
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                List<SqlParameter> aSqlParameterlist = new List<SqlParameter>();
                //aSqlParameterlist.Add(new SqlParameter("@param", param));
                DataTable dt = accessManager.GetDataTable("sp_Get_ApplyJob_by_CV");
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


        public CareerDAO Save_Admin_Post(CareerDAO careerDAO)
        {
            int pk = 0;


            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);

                List<SqlParameter> gSqlParameterList = new List<SqlParameter>();
                //gSqlParameterList.Add(new SqlParameter("@Id", crtxRegDAO.Id));
                gSqlParameterList.Add(new SqlParameter("@JobName", careerDAO.JobName));
                //gSqlParameterList.Add(new SqlParameter("@JobFeaturedImage", careerDAO.JobFeaturedImage));
                gSqlParameterList.Add(new SqlParameter("@JobFullDescription", careerDAO.JobFullDescription));
                gSqlParameterList.Add(new SqlParameter("@JobShortDescription", careerDAO.JobShortDescription));
                gSqlParameterList.Add(new SqlParameter("@UploadBy", careerDAO.UploadBy));
                gSqlParameterList.Add(new SqlParameter("@JobEntryDate", careerDAO.JobEntryDate));
                gSqlParameterList.Add(new SqlParameter("@HotJob", careerDAO.HotJob));
                gSqlParameterList.Add(new SqlParameter("@JobCatId", careerDAO.JobCatId));
                gSqlParameterList.Add(new SqlParameter("@JobApplyLastDate", careerDAO.JobApplyLastDate));

                if (careerDAO.JobId > 0)
                {
                    gSqlParameterList.Add(new SqlParameter("@JobId", careerDAO.JobId));
                    bool a = accessManager.UpdateData("sp_Update_Job", gSqlParameterList);
                }
                else
                {

                    pk = accessManager.SaveDataReturnPrimaryKey("sp_Save_Job", gSqlParameterList);
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

            return careerDAO;
        }
        public DataTable Get_Catagory_List()
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.INNDB);
                List<SqlParameter> aSqlParameterlist = new List<SqlParameter>();
                //aSqlParameterlist.Add(new SqlParameter("@CatagoryId",id));
                DataTable dt = accessManager.GetDataTable("sp_Get_JobCatagory");
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