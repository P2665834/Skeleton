using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {

        List<clsStaff> mEmployeeList = new List<clsStaff>();
        clsStaff mThisEmployee = new clsStaff();

        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
        }





        public List<clsStaff> EmployeeList
        {
            get
            {
                return mEmployeeList;
            }
            set
            {
                mEmployeeList = value;
            }
        }
        public int Count
        {
            get
            {
                return mEmployeeList.Count;
            }
            set
            {

            }
        }
        public clsStaff ThisEmployee
        {
            get
            {
                return mThisEmployee;
            }

            set
            {
                mThisEmployee = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EmployeeFullName", mThisEmployee.EmployeeFullName);
            DB.AddParameter("@EmployeePosition", mThisEmployee.EmployeePosition);
            DB.AddParameter("@Salary", mThisEmployee.UnitPrice);
            DB.AddParameter("@DateOfEmployment", mThisEmployee.DateOfEmployment);
            DB.AddParameter("@CurrentlyWorking", mThisEmployee.CurrentlyWorking);
            return DB.Execute("sproc_tblStaff_Insert");
        }
    

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EmployeeID", mThisEmployee.EmployeeID);
            DB.AddParameter("@EmployeeFullName", mThisEmployee.EmployeeFullName);
            DB.AddParameter("@EmployeePosition", mThisEmployee.EmployeePosition);
            DB.AddParameter("@Salary", mThisEmployee.UnitPrice);
            DB.AddParameter("@DateOfEmployment", mThisEmployee.DateOfEmployment);
            DB.AddParameter("@CurrentlyWorking", mThisEmployee.CurrentlyWorking);
            DB.Execute("sproc_tblStaff_Update");



        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EmployeeID", mThisEmployee.EmployeeID);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByEmployeeFullName(string EmployeeFullName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EmployeeFullName", EmployeeFullName);
            DB.Execute("sproc_tblStaff_FilterByEmployeeFullName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mEmployeeList = new List<clsStaff>();
            while (Index < RecordCount)
            {

                clsStaff aMemberOfstaff = new clsStaff();
                aMemberOfstaff.EmployeeID = Convert.ToInt32(DB.DataTable.Rows[Index]["EmployeeID"]);
                aMemberOfstaff.EmployeeFullName = Convert.ToString(DB.DataTable.Rows[Index]["EmployeeFullName]);
                aMemberOfstaff.EmployeePosition = Convert.ToString(DB.DataTable.Rows[Index]["EmployeePosition"]);
                aMemberOfstaff.DateOfEmployment = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfEmployment"]);
                aMemberOfstaff.Salary= (float)Convert.ToDouble(DB.DataTable.Rows[Index]["Salary"]);
                aMemberOfstaff.CurrentlyWorking = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                mEmployeeList.Add(aMemberOfstaff);
                Index++;
            }
        }
    }
}