using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DA;

namespace BL
{
    public class BL_frmInvoiceInfoEdit:DataAccess
    {
        public string InvoiceNumber;
        public string FDate;
        public string CustomerCode;
        public string CustomerName;
        public string RequesyNumber;
        public string InternalOerderNumber;

        public string GetCustomerName()
        {
            string LName;
            base.Connect();
            string Query = "SELECT LName FROM Customers WHERE Code='{0}'";
            Query = string.Format(Query, CustomerCode);
            DataTable dt = new DataTable();
            dt = base.SelectData(Query);
            if (dt.Rows.Count != 0)
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
        
        public void UpdateInvoiceInfo()
        {
            base.Connect();
            //Updating Invoice_Info Table
            string Query = "UPDATE Invoice_Info SET FDate='{0}',Customer_Code='{1}',Customer_Name='{2}',Request_Number='{3}',Internal_Order_Number='{4}' WHERE Invoice_Number='{5}'";
            Query=string.Format(Query,FDate,CustomerCode,CustomerName,RequesyNumber,InternalOerderNumber,InvoiceNumber);
            base.DoCommand(Query);
            //Updating Invoice_Items Table
            Query = "UPDATE Invoice_Items SET FDate='{0}',Customer_Code='{1}',Customer_Name='{2}',Request_Number='{3}',Internal_Order_Number='{4}' WHERE Invoice_Number='{5}'";
            Query = string.Format(Query, FDate, CustomerCode, CustomerName, RequesyNumber, InternalOerderNumber, InvoiceNumber);
            base.DoCommand(Query);
            base.Disconnect();

        }
    }
}
