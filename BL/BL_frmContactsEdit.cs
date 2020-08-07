using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DA;

namespace BL
{
    public class BL_frmContactsEdit:DataAccess
    {
        public long ID;
        public string FName;
        public string LName;
        public string Tel1;
        public string Tel2;
        public string Cell1;
        public string Cell2;
        public string Web;
        public string Email1;
        public string Email2;

        public void UpdateContact()
        {
            base.Connect();
            string Query = "UPDATE Contacts SET FName='{0}',LName='{1}',Tel1='{2}',Tel2='{3}',Cell1='{4}',Cell2='{5}',Web='{6}',Email1='{7}',Email2='{8}' WHERE ID={9}";
            Query=string.Format(Query,FName,LName,Tel1,Tel2,Cell1,Cell2,Web,Email1,Email2,ID);
            base.DoCommand(Query);
            base.Disconnect();
        }
    }
}
