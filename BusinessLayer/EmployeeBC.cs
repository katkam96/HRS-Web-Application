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
    public class EmployeeBC
    {

        EmployeeDAL employeeDAL = new EmployeeDAL();
        public bool CreateEmployeeBC(EmployeeInfo employeeInfo)
        {
            return employeeDAL.CreateEmployeeDAL(employeeInfo);
        }
        public bool UpdateEmployeeBC(EmployeeInfo employeeInfo)
        {
            return employeeDAL.UpdateEmployeeDAL(employeeInfo);
        }
        public DataTable ViewEmployeeBC(int employeeInfo)
        {
            return employeeDAL.ViewEmployeeDAL(employeeInfo);
        }
        public DataTable SearchEmployeeByNameBC(string fName, string lName)
        {
            return employeeDAL.SearchEmployeeByNameDAL(fName, lName);
        }
        public DataTable GetStatusDetailstBC()
        {
            return employeeDAL.GetStatusDetailsDAL();
        }
        public DataTable GetLevelDetailsBC()
        {
            return employeeDAL.GetLevelDetailsDAL();
        }
        public DataTable GetSpecialityDetailsBC()
        {
            return employeeDAL.GetSpecialityDetailsDAL();
        }

    }
}
