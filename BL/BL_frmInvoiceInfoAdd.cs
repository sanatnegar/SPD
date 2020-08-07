using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DA;

namespace BL
{
    public class BL_frmInvoiceInfoAdd:DataAccess
    {
        public string InvoiceNumber;
        public string FDate;
        public string CustomerCode;
        public string CustomerName;
        public string RequestNumber;
        public string InternalOrderNumber;
        public long TotalTax;
        public long TotalPrice;
        

        public bool isUnique()
        {
            bool Unique;
            DataTable dt = new DataTable();
            base.Connect();
            String Query = "SELECT * FROM Invoice_Info WHERE Invoice_Number='{0}'";
            Query = string.Format(Query, InvoiceNumber);
            dt = base.SelectData(Query);
            if (dt.Rows.Count != 0)
            {
                Unique = false;
            }
            else
            {
                Unique = true;
            }
            base.Disconnect();
            return Unique;
        }
        public DataTable ListItems()
        {
            DataTable dt = new DataTable();
            return dt;
        }
        public string GetCustomerName()
        {
            string LName;
            base.Connect();
            string Query = "SELECT LName FROM Customers WHERE Code='{0}'";
            Query = string.Format(Query, CustomerCode);
            DataTable dt = new DataTable();
            dt = base.SelectData(Query);
            if (dt.Rows.Count!=0)
            {
                LName = dt.Rows[0][0].ToString();
            }
            else
            {
                LName = "";
            }
            base.Disconnect();
            return LName;
        }
        public void AddInvoiceInfo()
        {
            base.Connect();
            String Query = "INSERT INTO Invoice_Info(Invoice_Number,FDate,Customer_Code,Customer_Name,Request_Number,Internal_Order_Number,Total_Tax,Total_Price) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7})";
            Query=string.Format(Query,InvoiceNumber,FDate,CustomerCode,CustomerName,RequestNumber,InternalOrderNumber,TotalTax,TotalPrice);
            base.DoCommand(Query);
            base.Disconnect();
        }
     }
}
