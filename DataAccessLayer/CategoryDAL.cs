using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Common;
using BusinessEntities;
using Microsoft.ApplicationBlocks.Data;

namespace DataAccessLayer
{
    public class CategoryDAL
    {

        public bool CreateCategoryDAL(CategoryInfo cInfo)
        {



            /*@categoryName 
            @categoryDesc 
            @createdBy  */
            try
            {

                SqlParameter[] sqlparams = new SqlParameter[3];
                sqlparams[0] = new SqlParameter("@CategoryName", cInfo.CategoryName);
                sqlparams[1] = new SqlParameter("@CategoryDesc", cInfo.CategoryDescription);
                sqlparams[2] = new SqlParameter("@CreatedBy", cInfo.CreatedBy);

                int rowsAffected = SqlHelper.ExecuteNonQuery(Database.ConnectionString, CommandType.StoredProcedure, "SP_CreateCategory", sqlparams);

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
                return false;
            }
        }

        public bool UpdateCategoryDAL(CategoryInfo catInfo)
        {
            /*@categoryId INT,
	@categoryName VARCHAR (50),
	@categoryDesc VARCHAR (100),
	@modifiedBy INT*/
            try
            {
                SqlParameter[] sqlparams = new SqlParameter[4];
                sqlparams[0] = new SqlParameter("@categoryID", catInfo.CategoryID);
                sqlparams[1] = new SqlParameter("@categoryName", catInfo.CategoryName);
                sqlparams[2] = new SqlParameter("@categoryDesc", catInfo.CategoryDescription);
                sqlparams[3] = new SqlParameter("@lastModifiedBy", catInfo.LastModifiedBy);

                int rowsAffected = SqlHelper.ExecuteNonQuery(Database.ConnectionString, CommandType.StoredProcedure,
                                                             "SP_UpdateCategory", sqlparams);

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex2)
            {
                System.Diagnostics.Debug.WriteLine(ex2.Message);
                return false;
            }

        }


        public DataTable SearchCategoryDAL(string catName)
        {
            try
            {
                SqlParameter sqlparams = new SqlParameter("@categoryName", catName);
                DataSet ds = SqlHelper.ExecuteDataset(Database.ConnectionString, CommandType.StoredProcedure,
                                                    "SP_SearchCategory", sqlparams);
                return ds.Tables[0];
            }
            catch(Exception ex3)
            {
                System.Diagnostics.Debug.WriteLine(ex3.Message);
                return null;
            }


        }

        public DataTable ViewCategoryDAL(int catID)
        {
            try
            {
                SqlParameter sqlparams = new SqlParameter("@catID", catID);
                DataSet ds = SqlHelper.ExecuteDataset(Database.ConnectionString, CommandType.StoredProcedure,
                                                    "SP_ViewCategory", sqlparams);
                return ds.Tables[0];
            }
            catch(Exception ex4)
            {
                System.Diagnostics.Debug.WriteLine(ex4.Message);
                return null;
            }
        }

        
        public DataTable ValidateUserDAL(string userName, string password)
        {
            try
            {
                SqlParameter[] sqlparams = new SqlParameter[2];
                sqlparams[0] = new SqlParameter("@UserName", userName);
                sqlparams[1] = new SqlParameter("@PassWord1", password);
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(Database.ConnectionString, CommandType.StoredProcedure, "SP_ValidateUser", sqlparams);

                return ds.Tables[0];
            }
            catch(Exception ex5)
            {
                System.Diagnostics.Debug.WriteLine(ex5.Message);
                return null;
            }
        }



    }
}
