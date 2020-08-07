using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DA;

namespace BL
{
    public class BL_frmInvoiceItemsEdit:DataAccess
    {
        public long ID;
        public string InvoiceNumber;
        public string FDate;
        public string CustomerCode;
        public string CustomerName;
        public string RequestNumber;
        public string InternalOerderNumber;
        //-------------------------------------------
        public string DraftNumber;
        public string ProductCode;
        public string ProductDescription;
        public string ProductTechNumber;
        public long Quantity;
        public long UnitPrice;
        public double Tax;
        public double Price;

        public string getProductName()
        {
            string pdes;
            base.Connect();
            string Query = "SELECT Name FROM Products Where Code='{0}'";
            Query = string.Format(Query, ProductCode);
            DataTable dt = new DataTable();
            dt = base.SelectData(Query);
            base.Disconnect();
            if (dt.Rows.Count != 0)
            {
                pdes = dt.Rows[0][0].ToString();
            }
            else
            {
                pdes = "";
            }

            return pdes;
        }
        public string getProductTechNo()
        {
            string ptechno;
            base.Connect();
            string Query = "SELECT TechNo FROM Products Where Code='{0}'";
            Query = string.Format(Query, ProductCode);
            DataTable dt = new DataTable();
            dt = base.SelectData(Query);
            if (dt.Rows.Count != 0)
            {
                ptechno = dt.Rows[0][0].ToString();
            }
            else
            {
                ptechno = "";
            }
            base.Disconnect();

            return ptechno;

        }
        public DataTable AllHistory()
        {
            base.Connect();
            string Query = "SELECT FDate,Customer_Name,Quantity,Unit_Price FROM Invoice_Items WHERE Product_Code='{0}'";
            Query = string.Format(Query, ProductCode);
            DataTable dt = new DataTable();
            dt = base.SelectData(Query);
            base.Disconnect();
            return dt;
        }
        public DataTable ThisCustomerHistory()
        {
            base.Connect();
            string Query = "SELECT FDate,Customer_Name,Quantity,Unit_Price FROM Invoice_Items WHERE Product_Code='{0}' AND Customer_Code='{1}'";
            Query = string.Format(Query, ProductCode, CustomerCode);
            DataTable dt = new DataTable();
            dt = base.SelectData(Query);
            base.Disconnect();
            return dt;

        }
        //public void AddItem()
        //{
        //    base.Connect();
        //    string Query = "INSERT INTO Invoice_Items (Invoice_Number,FDate,Customer_Code,Customer_Name,Request_Number,Internal_Order_Number,Draft_Number,Product_Code,Product_Description,Product_Tech_Number,Quantity,Unit_Price,Tax,Price) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',{10},{11},{12},{13})";
        //    Query = string.Format(Query, InvoiceNumber, FDate, CustomerCode, CustomerName, RequestNumber, InternalOerderNumber, DraftNumber, ProductCode, ProductDescription, ProductTechNumber, Quantity, UnitPrice, Tax, Price);
        //    base.DoCommand(Query);
        //    base.Disconnect();

        //}
        
        public void UpdateItem()
        {
            double totaltax;
            double totalprice;

            base.Connect();
            string Query = "UPDATE Invoice_Items SET Draft_Number='{0}',Product_Code='{1}',Product_Description='{2}',Product_Tech_Number='{3}',Quantity={4},Unit_Price={5},Tax={6},Price={7} WHERE ID={8}";
            Query=string.Format(Query,DraftNumber,ProductCode,ProductDescription,ProductTechNumber,Quantity,UnitPrice,Tax,Price,ID);
            base.DoCommand(Query);
            //Calculating total tax
            Query = "SELECT SUM(Tax) FROM Invoice_Items WHERE Invoice_Number='{0}'";
            Query = string.Format(Query, InvoiceNumber);
            DataTable dt = new DataTable();
            totaltax = base.DoCommandScalar(Query);
            //if (!double.TryParse(dt.Rows[0][0].ToString(), out totaltax))
            //{
            //    totaltax = 0;
            //}
            //else
            //{
                //totaltax = double.Parse(dt.Rows[0][0].ToString());
            //}
            //Calculating totalprice
            Query = "SELECT SUM(Price) FROM Invoice_Items WHERE Invoice_Number='{0}'";
            Query = string.Format(Query, InvoiceNumber);
            dt = new DataTable();
            totalprice = base.DoCommandScalar(Query);
            //if (!double.TryParse(dt.Rows[0][0].ToString(), out totalprice))
            //{
            //    totalprice = 0;
            //}
            //else
            //{
                //totalprice = double.Parse(dt.Rows[0][0].ToString());
            //}
            //Updating Invoice_Info Table
            Query = "UPDATE Invoice_Info SET Total_Tax={0},Total_Price={1} WHERE Invoice_Number='{2}'";
            Query = string.Format(Query, totaltax, totalprice, InvoiceNumber);
            base.DoCommand(Query);
            base.Disconnect();
            

        }
    }
}
