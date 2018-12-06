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
    public class EmployeeDAL
    {
        public bool CreateEmployeeDAL(EmployeeInfo eInfo)
        {
            /*
@FirstName VARCHAR (50),		-- First Name of Employee.
@MiddleName VARCHAR (50),		-- Middle Name of Employee.
@LastName VARCHAR (50),		-- Last Name of Employee.
@BirthDate DATETIME,			-- Birth Date of Employee.
@Gender VARCHAR (1), 		-- Gender of Employee.
@CivilStatus INT, 			-- Civil Status of Employee.
@SSNo VARCHAR (15), 		-- Social Security number of Employee.
@TinNo VARCHAR (15), 		-- Tin number of Employee.
@Citizenship VARCHAR (15), 		-- Citizenship of Employee.
@MobileNo VARCHAR (15), 		-- Mobile number of Employee.
@HomePhoneNo VARCHAR (15), 	-- Home phone number of Employee.
@Street1 VARCHAR (100), 		-- Street address 1 where the Employee resides.
@Street2 VARCHAR (100), 		-- Street address 2 where the Employee resides.
@City VARCHAR (100), 			-- City where the Employee resides.
@State VARCHAR (100), 		-- State where the Employee resides.
@Country VARCHAR (100), 		-- Country where the Employee resides.
@EducBackGround VARCHAR (500),  	-- Educational background of Employee.
@Recognitions VARCHAR (500), 	-- Certifications/Awards received by the Employee.
@Email VARCHAR (50), 			-- Email address of Employee.
@EnterpriseId VARCHAR (50), 		-- Enterprise Id of Employee.
@Level INT, 				-- Level of Employee.
@LMU VARCHAR (5), 			-- LMU of Employee.
@GMU VARCHAR (5), 			-- GMU of Employee.
@DateHired DATETIME, 		-- Hire Date of Employee.
@WorkGroup VARCHAR (30), 		-- Work group of Employee.
@Specialty INT, 			-- Specialty of Employee.
@ServiceLine VARCHAR (50), 		-- Service line of Employee.
@Status VARCHAR (20),		-- Status of Employee.
@CreatedBy INT			-- User who creates the record.*/
            try
            {


                SqlParameter[] sqlparams = new SqlParameter[29];
                sqlparams[0] = new SqlParameter("@FirstName", eInfo.FirstName);
                sqlparams[1] = new SqlParameter("@MiddleName", eInfo.MiddleName);
                sqlparams[2] = new SqlParameter("@LastName", eInfo.LastName);
                sqlparams[3] = new SqlParameter("@DateOfBirth", eInfo.DateOfBirth);
                sqlparams[4] = new SqlParameter("@Gender", eInfo.Gender);
                sqlparams[5] = new SqlParameter("@CivilStatus", eInfo.CivilStatus);
                sqlparams[6] = new SqlParameter("@SSNNo", eInfo.SSNNo);
                sqlparams[7] = new SqlParameter("@TINNo", eInfo.TINNo);
                sqlparams[8] = new SqlParameter("@CitizenShip", eInfo.CitizenShip);
                sqlparams[9] = new SqlParameter("@MobNo", eInfo.MobNo);
                sqlparams[10] = new SqlParameter("@HomeNo", eInfo.HomeNo);
                sqlparams[11] = new SqlParameter("@Street1", eInfo.Street1);
                sqlparams[12] = new SqlParameter("@Street2", eInfo.Street2);
                sqlparams[13] = new SqlParameter("@City", eInfo.City);
                sqlparams[14] = new SqlParameter("@States", eInfo.State);
                sqlparams[15] = new SqlParameter("@Country", eInfo.Country);
                sqlparams[16] = new SqlParameter("@EduBackGround", eInfo.EduBackGround);
                sqlparams[17] = new SqlParameter("@Recognitions", eInfo.Recognitions);
                sqlparams[18] = new SqlParameter("@Email", eInfo.Email);
                sqlparams[19] = new SqlParameter("@EnterpriseID", eInfo.EnterpriseID);
                sqlparams[20] = new SqlParameter("@LevelNo", eInfo.Level);
                sqlparams[21] = new SqlParameter("@LMU", eInfo.LMU);
                sqlparams[22] = new SqlParameter("@GMU", eInfo.GMU);
                sqlparams[23] = new SqlParameter("@DateHired", eInfo.DateHired);
                sqlparams[24] = new SqlParameter("@WorkGroup", eInfo.WorkGroup);
                sqlparams[25] = new SqlParameter("@Speciality", eInfo.Speciality);
                sqlparams[26] = new SqlParameter("@ServiceLine", eInfo.ServieLine);
                sqlparams[27] = new SqlParameter("@Statuss", eInfo.Status);
                sqlparams[28] = new SqlParameter("@CreatedBy", eInfo.CreatedBy);

                int rowsAffected = SqlHelper.ExecuteNonQuery(Database.ConnectionString, CommandType.StoredProcedure,
                                                           "SP_CreateEmployee", sqlparams);
                if (rowsAffected > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
                return false;
            }
        }



        public bool UpdateEmployeeDAL(EmployeeInfo eInfo)
        {
            try
            {
                SqlParameter[] sqlparams = new SqlParameter[30];
                sqlparams[0] = new SqlParameter("@EmpID", eInfo.EmpID);
                sqlparams[1] = new SqlParameter("@FirstName", eInfo.FirstName);
                sqlparams[2] = new SqlParameter("@MiddleName", eInfo.MiddleName);
                sqlparams[3] = new SqlParameter("@LastName", eInfo.LastName);
                sqlparams[4] = new SqlParameter("@DateOfBirth", eInfo.DateOfBirth);
                sqlparams[5] = new SqlParameter("@Gender", eInfo.Gender);
                sqlparams[6] = new SqlParameter("@CivilStatus", eInfo.CivilStatus);
                sqlparams[7] = new SqlParameter("@SSNNo", eInfo.SSNNo);
                sqlparams[8] = new SqlParameter("@TINNo", eInfo.TINNo);
                sqlparams[9] = new SqlParameter("@CitizenShip", eInfo.CitizenShip);
                sqlparams[10] = new SqlParameter("@MobNo", eInfo.MobNo);
                sqlparams[11] = new SqlParameter("@HomeNo", eInfo.HomeNo);
                sqlparams[12] = new SqlParameter("@Street1", eInfo.Street1);
                sqlparams[13] = new SqlParameter("@Street2", eInfo.Street2);
                sqlparams[14] = new SqlParameter("@City", eInfo.City);
                sqlparams[15] = new SqlParameter("@States", eInfo.State);
                sqlparams[16] = new SqlParameter("@Country", eInfo.Country);
                sqlparams[17] = new SqlParameter("@EduBackGround", eInfo.EduBackGround);
                sqlparams[18] = new SqlParameter("@Recognitions", eInfo.Recognitions);
                sqlparams[19] = new SqlParameter("@Email", eInfo.Email);
                sqlparams[20] = new SqlParameter("@EnterpriseID", eInfo.EnterpriseID);
                sqlparams[21] = new SqlParameter("@LevelNo", eInfo.Level);
                sqlparams[22] = new SqlParameter("@LMU", eInfo.LMU);
                sqlparams[23] = new SqlParameter("@GMU", eInfo.GMU);
                sqlparams[24] = new SqlParameter("@DateHired", eInfo.DateHired);
                sqlparams[25] = new SqlParameter("@WorkGroup", eInfo.WorkGroup);
                sqlparams[26] = new SqlParameter("@Speciality", eInfo.Speciality);
                sqlparams[27] = new SqlParameter("@ServiceLine", eInfo.ServieLine);
                sqlparams[28] = new SqlParameter("@Statuss", eInfo.Status);
                sqlparams[29] = new SqlParameter("@LastModifiedBy", eInfo.LastModifiedBy);

                int rowsAffected = SqlHelper.ExecuteNonQuery(Database.ConnectionString, CommandType.StoredProcedure,
                                                           "SP_UpdateEmployee", sqlparams);
                if (rowsAffected > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception ex2)
            {
                System.Diagnostics.Debug.WriteLine(ex2.Message);
                return false;
            }


        }


        public DataTable ViewEmployeeDAL(int eID)
        {
            try
            {
                SqlParameter sqlparams = new SqlParameter("@EmpID", eID);
                DataSet ds = SqlHelper.ExecuteDataset(Database.ConnectionString, CommandType.StoredProcedure,
                                                    "SP_ViewEmployee", sqlparams);
                return ds.Tables[0];
            }
            catch (Exception ex3)
            {
                System.Diagnostics.Debug.WriteLine(ex3.Message);
                return null;
            }
        }

        public DataTable SearchEmployeeByNameDAL(string fName, string lName)
        {
            try
            {
                SqlParameter[] sqlparams = new SqlParameter[2];
                sqlparams[0] = new SqlParameter("@FirstName", fName);
                sqlparams[1] = new SqlParameter("@LastName", lName);
                DataSet ds = SqlHelper.ExecuteDataset(Database.ConnectionString, CommandType.StoredProcedure,
                                                    "SP_SearchEmployeeByName", sqlparams);

                return ds.Tables[0];
            }
            catch (Exception ex4)
            {
                System.Diagnostics.Debug.WriteLine(ex4.Message);
                return null;
            }
        }
        public DataTable GetStatusDetailsDAL()
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(Database.ConnectionString, CommandType.StoredProcedure, "SP_GetStatusList");
                return ds.Tables[0];
            }
            catch (Exception ex5)
            {
                System.Diagnostics.Debug.WriteLine(ex5.Message);
                return null;

            }
        }
        public DataTable GetLevelDetailsDAL()
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(Database.ConnectionString, CommandType.StoredProcedure, "SP_GetLevelList");
                return ds.Tables[0];
            }
            catch (Exception ex6)
            {
                System.Diagnostics.Debug.WriteLine(ex6.Message);
                return null;
            }
        }
        public DataTable GetSpecialityDetailsDAL()
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(Database.ConnectionString, CommandType.StoredProcedure, "SP_GetSpecialityList");
                return ds.Tables[0];
            }
            catch (Exception ex7)
            {
                System.Diagnostics.Debug.WriteLine(ex7.Message);
                return null;
            }
        }

    }
}
