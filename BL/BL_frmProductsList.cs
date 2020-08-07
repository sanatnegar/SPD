using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DA;

namespace BL
{
    public class BL_frmProductsList:DataAccess
    {
        public string Code;
        public string TechNo;
        public string Description;

        public DataTable Search()
        {
            base.Connect();
            string Query = "SELECT * FROM Products WHERE Code LIKE '{0}%' AND TechNo LIKE '%{1}%' AND Name LIKE '%{2}%'";
            Query=string.Format(Query,Code,TechNo,Description);
            DataTable dt = new DataTable();
            dt=base.SelectData(Query);
            base.Disconnect();
            return dt;
        }
        public void Delete()
        {
            base.Connect();
            string Query = "DELETE FROM Products WHERE Code='{0}'";
            Query=string.Format(Query,Code);
            base.DoCommand(Query);
            base.Disconnect();
        }
    }
}
