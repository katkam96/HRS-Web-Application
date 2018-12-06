using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using BusinessLayer;

namespace Controllers
{
    public class EmployeeController
    {
        /*
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
@CreatedBy INT			-- User who creates the record.
        */
        HRManager hrm = new HRManager();
        public bool CreateEmployeeCont(string fName, string mName, string lName, DateTime dob,
                                    string gender, int civStatus, string ssnNo,
                                    string tinNo, string citizenShip, string mobNo,
                                    string homeNo, string street1, string street2,
                                    string city, string state, string country,
                                    string eduBackGround, string recognitions, string email
                                    , string enterpriseID, int level, string lmu, string gmu,
                                    DateTime dateHired, string workGroup, int speciality,
                                    string serviceLine, string status, int createdBy)

        /*
          
         */

        {
            try
            {
                EmployeeInfo eInfo = new EmployeeInfo()
                {
                    FirstName = fName,
                    MiddleName = mName,
                    LastName = lName,
                    DateOfBirth = dob,
                    Gender = gender,
                    CivilStatus = civStatus,
                    SSNNo = ssnNo,
                    TINNo = tinNo,
                    CitizenShip = citizenShip,
                    MobNo = mobNo,
                    HomeNo = homeNo,
                    Street1 = street1,
                    Street2 = street2,
                    City = city,
                    State = state,
                    Country = country,
                    EduBackGround = eduBackGround,
                    Recognitions = recognitions,
                    Email = email,
                    EnterpriseID = enterpriseID,
                    Level = level,
                    LMU = lmu,
                    GMU = gmu,
                    DateHired = dateHired,
                    WorkGroup = workGroup,
                    Speciality = speciality,
                    ServieLine = serviceLine,
                    Status = status,
                    CreatedBy = createdBy
                    

                };
                return hrm.CreateEmployeeHR(eInfo);
            }
            catch (Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
                return false;
            }
        }


        public bool UpdateEmployeeCont(int eID, string fName, string mName, string lName, DateTime dob,
                                        string gender, int civStatus, string ssnNo,
                                        string tinNo, string citizenShip, string mobNo,
                                        string homeNo, string street1, string street2,
                                        string city, string state, string country,
                                        string eduBackGround, string recognitions, string email
                                        , string enterpriseID, int level, string lmu, string gmu,
                                        DateTime dateHired, string workGroup, int speciality,
                                        string serviceLine, string status,
                                        int lastModifiedBy)
        {
            try
            {
                EmployeeInfo empInfo = new EmployeeInfo()
                {
                    EmpID = eID,
                    FirstName = fName,
                    MiddleName = mName,
                    LastName = lName,
                    DateOfBirth = dob,
                    Gender = gender,
                    CivilStatus = civStatus,
                    SSNNo = ssnNo,
                    TINNo = tinNo,
                    CitizenShip = citizenShip,
                    MobNo = mobNo,
                    HomeNo = homeNo,
                    Street1 = street1,
                    Street2 = street2,
                    City = city,
                    State = state,
                    Country = country,
                    EduBackGround = eduBackGround,
                    Recognitions = recognitions,
                    Email = email,
                    EnterpriseID = enterpriseID,
                    Level = level,
                    LMU = lmu,
                    GMU = gmu,
                    DateHired = dateHired,
                    WorkGroup = workGroup,
                    Speciality = speciality,
                    ServieLine = serviceLine,
                    Status = status,
                    
                    LastModifiedBy = lastModifiedBy


                };
                return hrm.UpdateEmployeeHR(empInfo);
            }
            catch (Exception ex2)
            {
                System.Diagnostics.Debug.WriteLine(ex2.Message);
                return false;
            }
        }

        public DataTable ViewEmployeeCont(int eID)
        {
            try
            {
                return hrm.ViewEmployeeHR(eID);
            }
            catch (Exception ex3)
            {
                System.Diagnostics.Debug.WriteLine(ex3.Message);
                return null;
            }
        }

        public DataTable SearchEmployeebyNameCont(string fName, string lName)
        {
            try
            {
                return hrm.SearchEmployeeByNameHR(fName, lName);
            }
            catch (Exception ex4)
            {
                System.Diagnostics.Debug.WriteLine(ex4.Message);
                return null;
            }
        }

        public DataTable GetSpecialityDetailsCont()
        {
            try
            {
                return hrm.GetSpecialityDetailsHR();
            }
            catch (Exception ex5)
            {
                System.Diagnostics.Debug.WriteLine(ex5.Message);
                return null;
            }
        }

        public DataTable GetLevelDetailsCont()
        {
            try
            {
                return hrm.GetLevelDetailsHR();
            }
            catch (Exception ex6)
            {
                System.Diagnostics.Debug.WriteLine(ex6.Message);
                return null;
            }
        }

        public DataTable GetStatusDetailsCont()
        {
            try
            {
                return hrm.GetStatusDetailsHR();
            }
            catch (Exception ex7)
            {
                System.Diagnostics.Debug.WriteLine(ex7.Message);
                return null;
            }
        }

    }
}
