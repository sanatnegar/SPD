using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DA;

namespace BL
{
    public class BL_frmReworkAdd:DataAccess
    {
        public string Code; // Just used for finding products in GetTechNo & GetName
        
        public string FDate;
        public string OriginCode;
        public string OriginTechNo;
        public string OriginName;
        public string DestinationCode;
        public string DestinationTechNo;
        public string DestinationName;
        public string ReworkCode;
        public string Quantity;
        public string Description;

        public string GetTechNo()
        {
            string ptechno;
            base.Connect();
            string Query = "SELECT TechNo FROM Products Where Code='{0}'";
            Query = string.Format(Query, Code);
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
        public string GetName()
        {
            string pdes;
            base.Connect();
            string Query = "SELECT Name FROM Products Where Code='{0}'";
            Query = string.Format(Query, Code);
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
        public bool isUnique()
        {
            bool Unique;
            DataTable dt = new DataTable();
            base.Connect();
            String Query = "SELECT * FROM Rework WHERE ReworkCode='{0}'";
            Query = string.Format(Query, ReworkCode);
            dt = base.SelectData(Query);
            base.Disconnect();
            if (dt.Rows.Count != 0)
            {
                Unique = false;
            }
            else
            {
                Unique = true;
            }
            
            return Unique;
            
        }
        public void AddRework()
        {
            base.Connect();
            String Query = "INSERT INTO Rework(FDate,OriginCode,OriginTechNo,OriginName,DestinationCode,DestinationTechNo,DestinationName,ReworkCode,Quantity,Description) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},'{9}')";
            Query = string.Format(Query,FDate, OriginCode, OriginTechNo, OriginName, DestinationCode, DestinationTechNo, DestinationName,ReworkCode,Quantity,Description);
            base.DoCommand(Query);
            base.Disconnect();

        }


    }
}
