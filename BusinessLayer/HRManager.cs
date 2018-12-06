using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using System.Data;
using BusinessLayer.BusinessServices;

namespace BusinessLayer
{
    public class HRManager
    {
        EmployeeBC empBC = new EmployeeBC();
        ProjectBC projBC = new ProjectBC();
        CategoryBC catBC = new CategoryBC();
        SkillBC skiBC = new SkillBC();
        Service1Client serClient1 = new Service1Client();
        public bool CreateEmployeeHR(EmployeeInfo eInfo)
        {
            try
            {
                return empBC.CreateEmployeeBC(eInfo);
            }
            catch(Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
                return false;
            }
        }
        public bool UpdateEmployeeHR(EmployeeInfo eInfo)
        {
            return empBC.UpdateEmployeeBC(eInfo);
        }
        public DataTable ViewEmployeeHR(int eID)
        {
            return empBC.ViewEmployeeBC(eID);
        }
        public DataTable SearchEmployeeByNameHR(string fName, string lName)
        {
            return serClient1.SearchEmployeeByNameBS(fName, lName);
        }
        public DataTable GetStatusDetailsHR()
        {
            return empBC.GetStatusDetailstBC();

        }
        public DataTable GetLevelDetailsHR()
        {
            return empBC.GetLevelDetailsBC();

        }
        public DataTable GetSpecialityDetailsHR()
        {
            return empBC.GetSpecialityDetailsBC();
        }

        /* Project*/

        public bool CreateProjectHR(ProjectInfo pInfo)
        {
            return projBC.CreateProjectBC(pInfo);
        }
        public bool UpdateProjectHR(ProjectInfo pInfo)
        {
            return projBC.UpdateProjectBC(pInfo);
        }
        public DataTable SearchProjectHR(string pName)
        {
            return serClient1.SearchProjectBS(pName);
        }

        public DataTable ViewProjectHR(int pID)
        {
            return projBC.ViewProjectBC(pID);
        }


        /* Category*/

        public bool CreateCategoryHR(CategoryInfo catInfo)
        {
            return catBC.CreateCategoryBC(catInfo);
        }

        public bool UpdateCategoryHR(CategoryInfo catInfo)
        {
            return catBC.UpdateCategoryBC(catInfo);
        }

        public DataTable SearchCategoryHR(string catName)
        {
            return serClient1.SearchCategoryBS(catName);
        }
        public DataTable ViewCategoryHR(int catID)
        {
            return catBC.ViewCategoryBC(catID);
        }
        public DataTable ValidateUserHR(string userName,string passWord)
        {
            return catBC.ValidateUserBC(userName, passWord);
        }


        /* Skill*/

        public bool CreateSkillHR(SkillInfo sInfo)
        {
            return skiBC.CreateSkillBC(sInfo);
        }

        public bool UpdateSkillHR(SkillInfo sInfo)
        {
            return skiBC.UpdateSkillBC(sInfo);
        }

        public DataTable SearchSkillHR(string sName)
        {
            return serClient1.SearchSkillBS(sName);
        }

        public DataTable ViewSkillHR(int sID)
        {
            return skiBC.ViewSkillBC(sID);
        }

        public DataTable GetCategoryListHR()
        {
            return skiBC.GetCategoryListBC();
        }


    }
}
