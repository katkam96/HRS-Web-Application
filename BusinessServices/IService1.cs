using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BusinessServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        DataTable SearchEmployeeByNameBS(string fName, string lName);

        [OperationContract]
        DataTable SearchProjectBS(string projName);

        [OperationContract]
        DataTable SearchCategoryBS(string categoryName);

        [OperationContract]
        DataTable SearchSkillBS(string skillName);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
}