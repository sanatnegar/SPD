using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DA;

namespace BL
{
    public class BL_frmContactsList:DataAccess
    {
        public long ID;
        public string FName;
        public string LName;
        public DataTable SearchContacts()
        {
            base.Connect();
            string Query = "SELECT * FROM Contacts WHERE FName LIKE '%{0}%' AND LName LIKE '%{1}%' ORDER BY LNAME";
            Query =string.Format(Query,FName,LName);
            DataTable dt=new DataTable();
            dt=base.SelectData(Query);
            base.Disconnect();
            return dt;
        }
        public void DeleteContact()
        {
            base.Connect();
            string Query = "DELETE FROM Contacts WHERE ID={0}";
            Query=string.Format(Query,ID);
            base.DoCommand(Query);
            base.Disconnect();
        }
    }
}
