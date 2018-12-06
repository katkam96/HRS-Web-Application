using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using DataAccessLayer;
using System.Data;

namespace BusinessLayer
{
    public class ProjectBC
    {
        ProjectDAL pDAL = new ProjectDAL();
        public bool CreateProjectBC(ProjectInfo pInfo)
        {
            try
            {
                return pDAL.CreateProjectDAL(pInfo);
            }
            catch(Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
                return false;
            }
        }
        public bool UpdateProjectBC(ProjectInfo pInfo)
        {
            try
            {
                return pDAL.UpdateProjectDAL(pInfo);
            }
            catch (Exception ex2)
            {
                System.Diagnostics.Debug.WriteLine(ex2.Message);
                return false;
            }
        }

        public DataTable SearchProjectBC(string pName)
        {
            try
            {
                return pDAL.SearchProjectDAL(pName);
            }
            catch(Exception ex3)
            {
                System.Diagnostics.Debug.WriteLine(ex3.Message);
                return null;
            }
        }

        public DataTable ViewProjectBC(int pID)
        {
            try
            {
                return pDAL.ViewProjectDAL(pID);
            }
            catch (Exception ex4)
            {
                System.Diagnostics.Debug.WriteLine(ex4.Message);
                return null;
            }
        }


    }
}
