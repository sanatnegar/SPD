using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DA;

namespace BL
{
    public class BL_frmReworkList:DataAccess
    {
        public string OriginCode;
        public string DestinationCode;
        public string ReworkCode;

        public DataTable SelectByOrigin()
        {
            base.Connect();
            string Query = "SELECT * FROM Rework WHERE OriginCode LIKE'{0}%'";
            Query=string.Format(Query,OriginCode);
            DataTable dt = new DataTable();
            dt=base.SelectData(Query);
            base.Disconnect();
            return dt;
        }
        public DataTable SelectByDestination()
        {
            base.Connect();
            string Query = "SELECT * FROM Rework WHERE DestinationCode LIKE '{0}%'";
            Query=string.Format(Query,DestinationCode);
            DataTable dt = new DataTable();
            dt=base.SelectData(Query);
            base.Disconnect();
            return dt; 
        }
        public DataTable SelectByReworkCode()
        {
            base.Connect();
            string Query = "SELECT * FROM Rework WHERE ReworkCode LIKE '{0}%'";
            Query=string.Format(Query,ReworkCode);
            DataTable dt = new DataTable();
            dt=base.SelectData(Query);
            base.Disconnect();
            return dt; 

        }
        public void Delete()
        {
            base.Connect();
            string Query = "DELETE FROM Rework WHERE ReworkCode='{0}'";
            Query=string.Format(Query,ReworkCode);
            base.DoCommand(Query);
            base.Disconnect();

        }
        

    }
}
