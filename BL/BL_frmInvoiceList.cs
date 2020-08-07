using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DA;

namespace BL
{
    public class BL_frmInvoiceList:DataAccess
    {
        public string InvoiceNumber;
        public string FD1;
        public string FD2;
        public string IN1;
        public string IN2;

        public DataTable SelectAll()
        {
            base.Connect();
            string Query = "SELECT * FROM Invoice_Info ORDER BY Invoice_Number";
            DataTable Output_Q = base.SelectData(Query);
            base.Disconnect();
            return Output_Q;
            
        }
        public DataTable SelectAllReverse()
        {
            base.Connect();
            string Query = "SELECT * FROM Invoice_Info ORDER BY Invoice_Number DESC";
            DataTable Output_Q = base.SelectData(Query);
            base.Disconnect();
            return Output_Q;
        }
        public DataTable SelectLast100()
        {
            base.Connect();
            string Query = "SELECT TOP 100 * FROM Invoice_Info ORDER BY Invoice_Number DESC";
            DataTable Output_Q = base.SelectData(Query);
            base.Disconnect();
            return Output_Q;
        }
        public void DeleteInvoice()
        {
           
            base.Connect();
            string Query = "DELETE FROM Invoice_Info WHERE Invoice_Number='{0}'";
            Query=string.Format(Query,InvoiceNumber);
            base.DoCommand(Query);
            Query = "DELETE FROM Invoice_Items WHERE Invoice_Number='{0}'";
            Query = string.Format(Query, InvoiceNumber);
            base.DoCommand(Query);
            base.Disconnect();

        }
        public void UpdateInvoice()
        {

        }
        public DataTable SelectByDate()
        {
            base.Connect();
            string Query = "SELECT * FROM Invoice_Info WHERE FDate BETWEEN '{0}' AND '{1}'";
            Query = string.Format(Query, FD1, FD2);
            DataTable Output_Q = base.SelectData(Query);
            base.Disconnect();
            return Output_Q;
        }
        public DataTable SelectByInvoiceNumber()
        {
            base.Connect();
            string Query = "SELECT * FROM Invoice_Info WHERE Invoice_Number BETWEEN '{0}' AND '{1}'";
            Query = string.Format(Query, IN1, IN2);
            DataTable Output_Q = base.SelectData(Query);
            base.Disconnect();
            return Output_Q;
        }

    }
}
