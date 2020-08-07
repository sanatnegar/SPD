using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DA;

namespace BL
{
    public class BL_frmProductsAdd:DataAccess
    {
        public string Code;
        public string TechNo;
        public string Description;
        //public string Unit;

        public bool isUnique()
        {
            base.Connect();
            String Query = "Select * FROM Products WHERE Code='{0}'";
            Query=string.Format(Query,Code);
            DataTable dt = new DataTable();
            dt=base.SelectData(Query);
            base.Disconnect();
            if(dt.Rows.Count==0)
            {
                return true;
            }
            else
            {
                return false;
            }
                  
        }
        public void Add()
        {
            base.Connect();
            string Query = "INSERT INTO Products(Code,TechNo,Name) VALUES ('{0}','{1}','{2}')";
            Query = string.Format(Query,Code,TechNo,Description);
            base.DoCommand(Query);
            base.Disconnect();
        }
    }
}
