using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BusinessEntities;
using BusinessLayer;

namespace Controllers
{
    public class SkillController
    {
        HRManager hrm = new HRManager();
        /*
                 @skillName
                 @skillDesc
                 @categoryID
                 @createdBy
                 */
        public bool CreateSkillCont(string skiName,string skiDesc,int catID, int createdBy)
        {
            try
            {


                SkillInfo sInfo = new SkillInfo()
                {
                    SkillName = skiName,
                    SkillDescription = skiDesc,
                    CategoryID = catID,
                    CreatedBy = createdBy
                };
                return hrm.CreateSkillHR(sInfo);
            }
            catch(Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
                return false;
            }
        }

        public bool UpdateSkillCont(int skiID,string skiName,string skiDesc,int modifiedBy)
        {
            try
            {
                SkillInfo sInfo = new SkillInfo()
                {
                    SkillID = skiID,
                    SkillName = skiName,
                    SkillDescription = skiDesc,
                    LastModifiedBy = modifiedBy
                };
                return hrm.UpdateSkillHR(sInfo);

            }
            catch(Exception ex2)
            {
                System.Diagnostics.Debug.WriteLine(ex2.Message);
                return false;
            }
        }

        public DataTable SearchSkillCont(string sName)
        {
            try
            {
                return hrm.SearchSkillHR(sName);
            }
            catch(Exception ex3)
            {
                System.Diagnostics.Debug.WriteLine(ex3.Message);
                return null;
            }
        }

        public DataTable ViewSkillCont(int sID)
        {
            try
            {
                return hrm.ViewSkillHR(sID);
            }
            catch(Exception ex4)
            {
                System.Diagnostics.Debug.WriteLine(ex4.Message);
                return null;
            }
        }

        public DataTable GetCategoryListCont()
        {
            try
            {
                return hrm.GetCategoryListHR();
            }
            catch(Exception ex5)
            {
                System.Diagnostics.Debug.WriteLine(ex5.Message);
                return null;
            }
        }
    }
}
