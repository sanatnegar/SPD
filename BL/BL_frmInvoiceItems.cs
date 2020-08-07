using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DA;

namespace BL
{
    public class BL_frmInvoiceItems:DataAccess
    {
        public long ItemID;
        public string InvoiceNumber;
        public DataTable SelectAllItems()
        {
            base.Connect();
            string Query = "SELECT * FROM Invoice_Items WHERE Invoice_Number='{0}' ORDER BY ID";
            Query=string.Format(Query,InvoiceNumber);
            DataTable dt = new DataTable();
            dt = base.SelectData(Query);
            base.Disconnect();
            return dt;
        }
        public Double GetTotalTax()
        {
            double totaltax;
            base.Connect();
            string Query = "SELECT SUM(Tax) FROM Invoice_Items WHERE Invoice_Number='{0}'";
            Query=string.Format(Query,InvoiceNumber);
            DataTable dt = new DataTable();
            dt = base.SelectData(Query);
            base.Disconnect();
                        
            if (!double.TryParse(dt.Rows[0][0].ToString(), out totaltax))
            {
                totaltax= 0;
            }
            else
            {
                totaltax = double.Parse(dt.Rows[0][0].ToString());
            }
            
            return totaltax;
        }
        public Double GetTotalPrice()
        {
            double totalprice;
            base.Connect();
            string Query = "SELECT SUM(Price) FROM Invoice_Items WHERE Invoice_Number='{0}'";
            Query = string.Format(Query, InvoiceNumber);
            DataTable dt = new DataTable();
            dt = base.SelectData(Query);
            base.Disconnect();
            
            if (!double.TryParse(dt.Rows[0][0].ToString(), out totalprice))
            {
                totalprice = 0;
            }
            else
            {
                totalprice = double.Parse(dt.Rows[0][0].ToString());
            }
            
            return totalprice;
        }
        public void DeleteItem()
        {
            double totaltax;
            double totalprice;
            base.Connect();
            //Deleting selected item
            string Query = "DELETE FROM Invoice_Items WHERE ID={0}";
            Query=string.Format(Query,ItemID);
            base.DoCommand(Query);
            //Calculating total tax
            Query = "SELECT SUM(Tax) FROM Invoice_Items WHERE Invoice_Number='{0}'";
            Query = string.Format(Query, InvoiceNumber);
            DataTable dt = new DataTable();
            dt = base.SelectData(Query);
            if (!double.TryParse(dt.Rows[0][0].ToString(), out totaltax))
            {
                totaltax = 0;
            }
            else
            {
                totaltax = double.Parse(dt.Rows[0][0].ToString());
            }
            //Calculating totalprice
            Query = "SELECT SUM(Price) FROM Invoice_Items WHERE Invoice_Number='{0}'";
            Query = string.Format(Query, InvoiceNumber);
            dt = new DataTable();
            dt = base.SelectData(Query);
            if (!double.TryParse(dt.Rows[0][0].ToString(), out totalprice))
            {
                totalprice = 0;
            }
            else
            {
                totalprice = double.Parse(dt.Rows[0][0].ToString());
            }
            //Updating Invoice_Info Table
            Query = "UPDATE Invoice_Info SET Total_Tax={0},Total_Price={1} WHERE Invoice_Number='{2}'";
            Query = string.Format(Query, totaltax, totalprice, InvoiceNumber);
            base.DoCommand(Query);
            base.Disconnect();
        }
    }
}
