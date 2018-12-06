using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using System.Data;
using BusinessLayer;
using BusinessLayer.BusinessServices;

namespace Controllers
{
    public class ProjectController
    {

        /*
         
        /*@projectName VARCHAR(50),	-- Project Name.
	@projectDesc VARCHAR(100),	-- Project description.
	@client VARCHAR(50),		-- Client Name.
	@startDate DATETIME,		-- Project start date.
	@endDate  DATETIME,		-- Project end date.
	@createdBy INT		-- User who creates the record.

    */
        HRManager hrm = new HRManager();
        public bool CreateProjectCont(string projName,string projDesc, string client,
                                      DateTime startDate,DateTime endDate,int createdBy)
        {
            try
            {
                ProjectInfo pInfo = new ProjectInfo()
                {
                    ProjName = projName, ProjDescription = projDesc, Client = client, StartDate = startDate, EndDate = endDate,
                    CreatedBy = createdBy
                };
                return hrm.CreateProjectHR(pInfo);
            }
            catch(Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
                return false;
            }
        }

        public bool UpdateProjectCont(int projID, string projName, string projDesc, string client,
                                      DateTime startDate, DateTime endDate,int lastModifiedBy)
        {
            try
            {
                ProjectInfo pInfo = new ProjectInfo()
                {
                    ProjID = projID,
                    ProjName = projName, ProjDescription = projDesc, Client = client, StartDate = startDate,
                    EndDate = endDate, LastModifiedBy = lastModifiedBy
                };
                return hrm.UpdateProjectHR(pInfo);
            }
            catch(Exception ex2)
            {
                System.Diagnostics.Debug.WriteLine(ex2.Message);
                return false;
            }
        }

        public DataTable SearchProjectCont(string pName)
        {
            try
            {
                return hrm.SearchProjectHR(pName);
            }
            catch(Exception ex3)
            {
                System.Diagnostics.Debug.WriteLine(ex3.Message);
                return null;
            }
        }

        public DataTable ViewProjectCont(int pID)
        {
            try
            {
                return hrm.ViewProjectHR(pID);
            }
            catch(Exception ex4)
            {
                System.Diagnostics.Debug.WriteLine(ex4.Message);
                return null;
            }
        }


    }
}
