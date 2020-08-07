using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DA;

namespace BL
{
    public class BL_frmReworkEdit:DataAccess
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
        public long Quantity;
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
        public void Update()
        {
            base.Connect();
            string Query = "UPDATE Rework SET FDate='{0}',OriginCode='{1}',OriginTechNo='{2}',OriginName='{3}',DestinationCode='{4}',DestinationTechNo='{5}',DestinationName='{6}',Quantity={7},Description='{8}' WHERE ReworkCode='{9}'";
            Query=string.Format(Query,FDate,OriginCode,OriginTechNo,OriginName,DestinationCode,DestinationTechNo,DestinationName,Quantity,Description,ReworkCode);
            base.DoCommand(Query);
            base.Disconnect();
        }
    }
}
