using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using System.Data;
using System.Data.OleDb;

namespace BL
{
    
    
    public class BL_frmCustomersAdd:DataAccess
    {
        public string Code;
        public string FName;
        public string LName;
        public string City;
        public string CompanyName;
        public string Cell;
        public string Tel;
        public string Address;
        public string Email;

        public bool isUnique()
        {
            DataTable dt = new DataTable();
            base.Connect();
            string Query = "SELECT * FROM Customers Where Code='{0}'";
            Query=string.Format(Query,Code);
            dt = base.SelectData(Query);
            base.Disconnect();
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
                       
        }
        public void Add()
        {
            base.Connect();
            string Query = "INSERT INTO Customers(Code,FName,LName,Company,City,Cell,Tell,Address,Email)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')";
            Query = string.Format(Query,Code,FName ,LName ,CompanyName ,City,Cell ,Tel ,Address,Email );
            base.DoCommand(Query);
            base.Disconnect();
        }

    }
}
