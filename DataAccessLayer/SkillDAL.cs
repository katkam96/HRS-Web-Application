using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Common;
using BusinessEntities;
using Microsoft.ApplicationBlocks.Data;
using System.Data;


namespace DataAccessLayer
{
    public class SkillDAL
    {
        public bool CreateSkillDAL(SkillInfo sInfo)
        {
            try
            {

                /*
                 @skillName
                 @skillDesc
                 @categoryID
                 @createdBy
                 */

                SqlParameter[] sqlparams = new SqlParameter[4];
                sqlparams[0] = new SqlParameter("@skillName", sInfo.SkillName);
                sqlparams[1] = new SqlParameter("@skillDesc", sInfo.SkillDescription);
                sqlparams[2] = new SqlParameter("@categoryID", sInfo.CategoryID);
                sqlparams[3] = new SqlParameter("@createdBy", sInfo.CreatedBy);

                int rowsAffected = SqlHelper.ExecuteNonQuery(Database.ConnectionString, System.Data.CommandType.StoredProcedure,
                                                           "SP_CreateSkill", sqlparams);
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch (Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
                return false;
            }
        }


        public bool UpdateSkillDAL(SkillInfo sInfo)
        {
            /*@skillID
              @skillName
              @skillDesc
              @lastModifiedBy
              */

            try
            {
                SqlParameter[] sqlparams = new SqlParameter[4];
                sqlparams[0] = new SqlParameter("@skillID", sInfo.SkillID);
                sqlparams[1] = new SqlParameter("@skillName", sInfo.SkillName);
                sqlparams[2] = new SqlParameter("@skillDesc", sInfo.SkillDescription);
                sqlparams[3] = new SqlParameter("@lastModifiedBy", sInfo.LastModifiedBy);

                int rowsAffected = SqlHelper.ExecuteNonQuery(Database.ConnectionString, CommandType.StoredProcedure,
                                                           "SP_UpdateSkill", sqlparams);
                if (rowsAffected > 0)
                {
                    return true;

                }
                else
                {
                    return false;

                }
            }

            catch (Exception ex2)
            {
                System.Diagnostics.Debug.WriteLine(ex2.Message);
                return false;
            }
        }



        public DataTable SearchSkillDAL(string sName)
        {
            try
            {
                SqlParameter sqlparams = new SqlParameter("@skillName", sName);
                DataSet ds = SqlHelper.ExecuteDataset(Database.ConnectionString, CommandType.StoredProcedure, "SP_SearchSkill", sqlparams);

                return ds.Tables[0];
            }
            catch (Exception ex3)
            {
                System.Diagnostics.Debug.WriteLine(ex3.Message);
                return null;
            }
        }

        public DataTable ViewSkillDAL(int sID)
        {
            try
            {
                SqlParameter sqlparams = new SqlParameter("@skillID", sID);
                DataSet ds = SqlHelper.ExecuteDataset(Database.ConnectionString, CommandType.StoredProcedure, "SP_ViewSkill", sqlparams);

                return ds.Tables[0];
            }
            catch (Exception ex4)
            {
                System.Diagnostics.Debug.WriteLine(ex4.Message);
                return null;
            }
        }

        public DataTable GetCategoryList()
        {
            try
            {

                DataSet ds = SqlHelper.ExecuteDataset(Database.ConnectionString, CommandType.StoredProcedure, "SP_GetCategoryList");
                return ds.Tables[0];
            }
            catch (Exception ex5)
            {
                System.Diagnostics.Debug.WriteLine(ex5.Message);
                return null;
            }
        }
    }
}
