using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DA;

namespace BL
{
    public class BL_frmCustomerSupport:DataAccess
    {
        public string Code;
        public string TechNo;
        public string Name;
        public string CustomerCode;
        public string OriginCode;
        public string DestinationCode;

        public DataTable SearchProduct()
        {
            base.Connect();
            string Query = "SELECT * FROM Products WHERE Code LIKE '%{0}%' AND TechNo LIKE '%{1}%' AND Name LIKE '%{2}%'";
            Query=string.Format(Query,Code,TechNo,Name);
            DataTable dt = new DataTable();
            dt=base.SelectData(Query);
            base.Disconnect();
            return dt;
        }
        public DataTable CustomerList()
        {
            base.Connect();
            string Query = "SELECT Code,LName FROM Customers ORDER BY ID";
            DataTable dt = new DataTable();
            dt = base.SelectData(Query);
            base.Disconnect();
            return dt;
        }
        public DataTable SalesHistoryAll()
        {
            base.Connect();
            string Query = "SELECT * FROM Invoice_Items WHERE Product_Code='{0}' ORDER BY FDate DESC";
            Query=string.Format(Query,Code);
            DataTable dt=new DataTable();
            dt=base.SelectData(Query);
            base.Disconnect();
            return dt;
        }
        public DataTable SalesHistoryByCustomerCode()
        {
            base.Connect();
            string Query = "SELECT * FROM Invoice_Items WHERE Customer_Code='{0}' AND Product_Code='{1}' ORDER BY FDate DESC";
            Query = string.Format(Query, CustomerCode, Code);
            DataTable dt = new DataTable();
            dt = base.SelectData(Query);
            base.Disconnect();
            return dt;
        }
        public DataTable SearchOrigin()
        {
            base.Connect();
            string Query = "SELECT * FROM Rework WHERE OriginCode='{0}'";
            Query=string.Format(Query,OriginCode);
            DataTable dt=new DataTable();
            dt=base.SelectData(Query);
            base.Disconnect();
            return dt;
        }
        public DataTable SearchDestination()
        {
            base.Connect();
            string Query = "SELECT * FROM Rework WHERE DestinationCode='{0}'";
            Query=string.Format(Query,DestinationCode);
            DataTable dt=new DataTable();
            dt=base.SelectData(Query);
            base.Disconnect();
            return dt;
        }
    }
}
