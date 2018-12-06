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
    public class SkillBC
    {
        SkillDAL sDAL = new SkillDAL();
        public bool CreateSkillBC(SkillInfo sInfo)
        {
            try
            {
                return sDAL.CreateSkillDAL(sInfo);
            }
            catch(Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
                return false;
            }
        }

        public bool UpdateSkillBC(SkillInfo sInfo)
        {
            try
            {
                return sDAL.UpdateSkillDAL(sInfo);
            }
            catch (Exception ex2)
            {
                System.Diagnostics.Debug.WriteLine(ex2.Message);
                return false;
            }
        }

        public DataTable SearchSkillBC(string sName)
        {
            try
            {
                return sDAL.SearchSkillDAL(sName);
            }
            catch (Exception ex3)
            {
                System.Diagnostics.Debug.WriteLine(ex3.Message);
                return null;
            }
        }

        public DataTable ViewSkillBC(int sID)
        {
            try
            {
                return sDAL.ViewSkillDAL(sID);
            }
            catch (Exception ex4)
            {
                System.Diagnostics.Debug.WriteLine(ex4.Message);
                return null;
            }
        }

        public DataTable GetCategoryListBC()
        {
            try
            {
                return sDAL.GetCategoryList();
            }
            catch(Exception ex5)
            {
                System.Diagnostics.Debug.WriteLine(ex5.Message);
                return null;
            }
        }

        

    }
}
