using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BusinessEntities;
using DataAccessLayer;

namespace BusinessLayer
{
    public class CategoryBC
    {
        CategoryDAL catDAL = new CategoryDAL();
        public bool CreateCategoryBC(CategoryInfo catInfo)
        {
            try
            {
                return catDAL.CreateCategoryDAL(catInfo);
            }
            catch(Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
                return false;
            }
        }

        public bool UpdateCategoryBC(CategoryInfo catInfo)
        {
            try
            {
                return catDAL.UpdateCategoryDAL(catInfo);
            }
            catch (Exception ex2)
            {
                System.Diagnostics.Debug.WriteLine(ex2.Message);
                return false;
            }
        }

        public DataTable SearchCategoryBC(string catName)
        {
            try
            {
                return catDAL.SearchCategoryDAL(catName);
                    
            }
            catch(Exception ex3)
            {
                System.Diagnostics.Debug.WriteLine(ex3.Message);
                return null;
            }
        }

        public DataTable ViewCategoryBC(int catID)
        {
            try
            {
                return catDAL.ViewCategoryDAL(catID);

            }
            catch (Exception ex4)
            {
                System.Diagnostics.Debug.WriteLine(ex4.Message);
                return null;
            }
        }


        public DataTable ValidateUserBC(string userName,string passWord)
        {
            try
            {
                return catDAL.ValidateUserDAL(userName, passWord);
            }
            catch(Exception ex5)
            {
                System.Diagnostics.Debug.WriteLine(ex5.Message);
                return null;
            }
        }
    }
}
