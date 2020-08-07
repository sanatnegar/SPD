using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DA;

namespace BL
{
    public class BL_frmReporting:DataAccess
    {
        public string FDate1;
        public string FDate2;
        public string CustomerCode;

        public DataTable CustomerList()
        {
            base.Connect();
            string Query = "SELECT Code,LName FROM Customers ORDER BY ID";
            DataTable dt = new DataTable();
            dt = base.SelectData(Query);
            base.Disconnect();
            return dt;
        }
        
        public DataTable TotalizedAll()
        {
            base.Connect();
            string Query = "SELECT * FROM Invoice_Info WHERE FDATE BETWEEN '{0}' AND '{1}' ORDER BY FDate";
            Query=string.Format(Query,FDate1,FDate2);
            DataTable dt = new DataTable();
            dt = base.SelectData(Query);
            base.Disconnect();
            return dt;
        }
        public DataTable TotalizedByCustomer()
        {
            base.Connect();
            string Query = "SELECT * FROM Invoice_Info WHERE Customer_Code='{0}' AND FDATE BETWEEN '{1}' AND '{2}' ORDER BY FDate";
            Query = string.Format(Query, CustomerCode,FDate1, FDate2);
            DataTable dt = new DataTable();
            dt = base.SelectData(Query);
            base.Disconnect();
            return dt;
        }
        public DataTable DetailedAll()
        {
            base.Connect();
            string Query = "SELECT * FROM Invoice_Items WHERE FDATE BETWEEN '{0}' AND '{1}' ORDER BY FDate";
            Query = string.Format(Query,FDate1, FDate2);
            DataTable dt = new DataTable();
            dt = base.SelectData(Query);
            base.Disconnect();
            return dt;
        }
        public DataTable DetailedByCustomer()
        {
            base.Connect();
            string Query = "SELECT * FROM Invoice_Items WHERE Customer_Code='{0}' AND FDATE BETWEEN '{1}' AND '{2}' ORDER BY FDate";
            Query = string.Format(Query, CustomerCode, FDate1, FDate2);
            DataTable dt = new DataTable();
            dt = base.SelectData(Query);
            base.Disconnect();
            return dt;
        }

        public double GetSumTotalizedAll()
        {
            double output;
            base.Connect();
            string Query = "SELECT SUM(Total_Price) FROM Invoice_Info WHERE FDATE BETWEEN '{0}' AND '{1}'";
            Query =string.Format(Query,FDate1,FDate2);
            output=base.DoCommandScalar(Query);
            base.Disconnect();
            return output;
        }
        public double GetSumTotalizedByCustomer()
        {
            double output;
            base.Connect();
            string Query = "SELECT SUM(Total_Price) FROM Invoice_Info WHERE Customer_Code='{0}' AND FDATE BETWEEN '{1}' AND '{2}'";
            Query = string.Format(Query,CustomerCode, FDate1, FDate2);
            output = base.DoCommandScalar(Query);
            base.Disconnect();
            return output;
        }
        public double GetSumDetailedAll()
        {
            double output;
            base.Connect();
            string Query = "SELECT SUM(Price) FROM Invoice_Items WHERE FDate BETWEEN '{0}' AND '{1}'";
            Query = string.Format(Query,FDate1, FDate2);
            output = base.DoCommandScalar(Query);
            base.Disconnect();
            return output;
        }
        public double GetSumDetailedByCustomer()
        {
            double output;
            base.Connect();
            string Query = "SELECT SUM(Price) FROM Invoice_Items WHERE Customer_Code='{0}' AND FDate BETWEEN '{1}' AND '{2}'";
            Query = string.Format(Query, CustomerCode, FDate1, FDate2);
            output = base.DoCommandScalar(Query);
            base.Disconnect();
            return output;
        }
        public double GetTaxTotalizedAll()
        {
            double output;
            base.Connect();
            string Query = "SELECT SUM(Total_Tax) FROM Invoice_Info WHERE FDate BETWEEN '{0}' AND '{1}'";
            Query = string.Format(Query,FDate1, FDate2);
            output = base.DoCommandScalar(Query);
            base.Disconnect();
            return output;
        }
        public double GetTaxTotalizedByCustomer()
        {
            double output;
            base.Connect();
            string Query = "SELECT SUM(Total_Tax) FROM Invoice_Info WHERE Customer_Code='{0}' AND FDate BETWEEN '{1}' AND '{2}'";
            Query = string.Format(Query, CustomerCode, FDate1, FDate2);
            output = base.DoCommandScalar(Query);
            base.Disconnect();
            return output;
        }
        public double GetTaxDetailedAll()
        {
            double output;
            base.Connect();
            string Query = "SELECT SUM(Tax) FROM Invoice_Items WHERE FDate BETWEEN '{0}' AND '{1}'";
            Query = string.Format(Query,FDate1, FDate2);
            output = base.DoCommandScalar(Query);
            base.Disconnect();
            return output;
           
        }
        public double GetTaxDetailedByCustomer()
        {
            double output;
            base.Connect();
            string Query = "SELECT SUM(Tax) FROM Invoice_Items WHERE Customer_Code='{0}' AND FDate BETWEEN '{1}' AND '{2}'";
            Query = string.Format(Query, CustomerCode, FDate1, FDate2);
            output = base.DoCommandScalar(Query);
            base.Disconnect();
            return output;
        }

    }
}
