using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using System.Data;
using System.Data.OleDb;


namespace BL
{
    public class BL_frmCustomersList:DataAccess
    {
        public string LName;
        public string Code;
        public DataTable SelectAll()
        {
            base.Connect();
            string Query = "SELECT * FROM Customers ORDER BY LName";
            DataTable Output_Q = base.SelectData(Query);
            base.Disconnect();
            return Output_Q;

        }
        public DataTable SelectSearch()
        {
            base.Connect();
            string Query = "SELECT * FROM Customers WHERE LName='{0}%' ORDER BY LNAME";
            Query = string.Format(Query, LName);
            DataTable Output_Q = base.SelectData(Query);
            base.Disconnect();
            return Output_Q;
        }
        public void Delete()
        {
            base.Connect();
            String Query = "DELETE FROM Customers WHERE Code='{0}'";
            Query = string.Format(Query, Code);
            base.DoCommand(Query);
            base.Disconnect();
        }



    }
}
