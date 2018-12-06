using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BusinessEntities;
using BusinessLayer.BusinessServices;
using BusinessLayer;

namespace Controllers
{
    public class CategoryController
    {
        HRManager hrm = new HRManager();

        public bool CreateCategoryCont(string catName, string catDesc, int createdBy)
        {
            /*@categoryName 
            @categoryDesc 
            @createdBy  */
            try
            {
                CategoryInfo catInfo = new CategoryInfo()
                {
                    CategoryName = catName,
                    CategoryDescription = catDesc,
                    CreatedBy = createdBy
                };

                return hrm.CreateCategoryHR(catInfo);
            }
            catch (Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
                return false;
            }
        }

        public bool UpdateCategoryCont(int catID, string catname, string catDesc, int modifiedBy)
        {
            try
            {
                CategoryInfo catInfo = new CategoryInfo()
                {
                    CategoryID = catID,
                    CategoryName = catname,
                    CategoryDescription = catDesc,
                    LastModifiedBy = modifiedBy
                };
                return hrm.UpdateCategoryHR(catInfo);
            }
            catch (Exception ex2)
            {
                System.Diagnostics.Debug.WriteLine(ex2.Message);
                return false;
            }
        }

        public DataTable SearchCategoryCont(string catName)
        {
           try
            {
                return hrm.SearchCategoryHR(catName);
            }
            catch(Exception ex3)
            {
                System.Diagnostics.Debug.WriteLine(ex3.Message);
                return null;
            }
        }

        public DataTable ViewCategoryCont(int catID)
        {
            try
            {
                return hrm.ViewCategoryHR(catID);
            }
            catch(Exception ex4)
            {
                System.Diagnostics.Debug.WriteLine(ex4.Message);
                return null;
            }
        }


        public DataTable ValidateUserCont(string userName,string passWord)
        {
            try
            {
                return hrm.ValidateUserHR(userName, passWord);

            }
            catch(Exception ex5)
            {
                System.Diagnostics.Debug.WriteLine(ex5.Message);
                return null;
            }
                
            
        }
    }
}
