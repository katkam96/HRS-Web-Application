using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using BusinessEntities;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DataAccessLayer
{
    public class ProjectDAL
    {

        public bool CreateProjectDAL(ProjectInfo pInfo)
        {
            /*@projectName VARCHAR(50),	-- Project Name.
              @projectDesc VARCHAR(100),	-- Project description.
              @client VARCHAR(50),		-- Client Name.
              @startDate DATETIME,		-- Project start date.
              @endDate  DATETIME,		-- Project end date.
              @createdBy INT		-- User who creates the record.*/

            try
            {
                SqlParameter[] sqlparams = new SqlParameter[6];
                sqlparams[0] = new SqlParameter("@projectName", pInfo.ProjName);
                sqlparams[1] = new SqlParameter("@projectDesc", pInfo.ProjDescription);
                sqlparams[2] = new SqlParameter("@client", pInfo.Client);
                sqlparams[3] = new SqlParameter("@startDate", pInfo.StartDate);
                sqlparams[4] = new SqlParameter("@endDate", pInfo.EndDate);
                sqlparams[5] = new SqlParameter("@createdBy", pInfo.CreatedBy);

                int rowsAffected = SqlHelper.ExecuteNonQuery(Database.ConnectionString,
                                                             CommandType.StoredProcedure, "SP_CreateProject", sqlparams);
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


        public bool UpdateProjectDAL(ProjectInfo pInfo)
        {
            /*SET [Description] = @projectDesc,
		        Client = @client,
		        StartDate = @startDate,  
		        EndDate = @endDate,
		        LastModifiedBy = @LastModifiedBy,
		        LastModifiedDate = GETDATE()*/

            try
            {
                SqlParameter[] sqlparams = new SqlParameter[7];
                sqlparams[0] = new SqlParameter("@projectID", pInfo.ProjID);
                sqlparams[1] = new SqlParameter("@projectName", pInfo.ProjName);
                sqlparams[2] = new SqlParameter("@projectDesc", pInfo.ProjDescription);
                sqlparams[3] = new SqlParameter("@client", pInfo.Client);
                sqlparams[4] = new SqlParameter("@startDate", pInfo.StartDate);
                sqlparams[5] = new SqlParameter("@endDate", pInfo.EndDate);
                sqlparams[6] = new SqlParameter("@LastModifiedBy", pInfo.LastModifiedBy);

                int rowsAffected = SqlHelper.ExecuteNonQuery(Database.ConnectionString,
                                                              CommandType.StoredProcedure, "SP_UpdateProject", sqlparams);

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

        public DataTable ViewProjectDAL(int pID)
        {
            try
            {
                SqlParameter sqlparams = new SqlParameter("@projectID", pID);
                DataSet ds = SqlHelper.ExecuteDataset(Database.ConnectionString, CommandType.StoredProcedure, "SP_ViewProject", sqlparams);
                return ds.Tables[0];
            }
            catch (Exception ex3)
            {
                System.Diagnostics.Debug.WriteLine(ex3.Message);
                return null;
            }
        }

        public DataTable SearchProjectDAL(string pName)
        {
            try
            {
                SqlParameter sqlparams = new SqlParameter("@projectName", pName);
                DataSet ds = SqlHelper.ExecuteDataset(Database.ConnectionString, CommandType.StoredProcedure, "SP_SearchProject", sqlparams);
                return ds.Tables[0];
            }
            catch (Exception ex4)
            {
                System.Diagnostics.Debug.WriteLine(ex4.Message);
                return null;
            }
        }

    }
}
