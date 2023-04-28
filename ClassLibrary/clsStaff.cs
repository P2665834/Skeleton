using System;

namespace ClassLibrary
{
    public class clsStaff
    {

        private Int32 mEmployeeID;
        private String mEmployeeFullName;
        private String mEmployeePosition;
        private float mSalary;
        private DateTime mDateOfEmployment;
        private Boolean mCurrentlyWorking;


        public int EmployeeID
        {
            get
            {
                return mEmployeeID;
            }
            set
            {
                mEmployeeID = value;
            }
        }

        public string EmployeeFullName
        {
            get
            {
                return mEmployeeFullName;
            }
            set
            {
                mEmployeeFullName = value;
            }
        }

        public string EmployeePosition
        {
            get
            {
                return mEmployeePosition;
            }
            set
            {
                mEmployeePosition = value;
            }
        }

        public DateTime DateOfEmployment
        {
            get
            {
                return mDateOfEmployment;
            }
            set
            {
                mDateOfEmployment = value;
            }
        }

       
        public float Salary
        {
            get
            {
                return mSalary;
            }
            set
            {
                mSalary = value;
            }
        }
        public bool  CurrentlyWorking
        {
            get
            {
                return mCurrentlyWorking;
            }
            set
            {
                mCurrentlyWorking = value;
            }
        }



        public bool Find(int EmployeeID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EmployeeID", EmployeeID);
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            if (DB.Count == 1)
            {
                mEmployeeID = Convert.ToInt32(DB.DataTable.Rows[0]["EmployeeID"]);
                mEmployeeFullName = Convert.ToString(DB.DataTable.Rows[0]["EmployeeFullName"]);
                mEmployeePosition = Convert.ToString(DB.DataTable.Rows[0]["EmployeePosition"]);
                mDateOfEmployment = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfEmployment"]);
                mSalary = (float)Convert.ToDouble(DB.DataTable.Rows[0]["Salary"]);
                mCurrentlyWorking = Convert.ToBoolean(DB.DataTable.Rows[0]["CurrentlyWorking"]);



                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string EmployeeFullName, string EmployeePosition,  string DateOfEmployment, string Salary)
        {
            String Error = "";
            DateTime DateTemp;
            if (EmployeeFullName.Length == 0)
            {
                Error = Error + "The employee full Name cannot not be blank : ";
            }
            if (EmployeeFullName.Length > 50)
            {
                Error = Error + "The employee full name must be less than 50 characters : ";
            }
            if (EmployeePosition.Length == 0)
            {
                Error = Error + "The employee's postion cannot not be blank : ";
            }
            if (EmployeePosition.Length > 20)
            {
                Error = Error + "The employee's position name must be less than 20 characters : ";
            }
            
            if (Salary.Length > 53)
            {
                Error = Error + "The employee's salary must be less than 53 characters : ";
            }
            if (Salary.Length == 0)
            {
                Error = Error + "The the employee's salary may not be blank : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(DateOfEmployment);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            return Error;

        }

    }
}