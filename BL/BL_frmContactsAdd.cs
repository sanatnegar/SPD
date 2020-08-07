using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DA;

namespace BL
{
    public class BL_frmContactsAdd:DataAccess
    {
        public string FName;
        public string LName;
        public string Tel1;
        public string Tel2;
        public string Cell1;
        public string Cell2;
        public string Web;
        public string Email1;
        public string Email2;

        public void AddContact()
        {
            base.Connect();
            string Query = "INSERT INTO Contacts (FName,LName,Tel1,Tel2,Cell1,Cell2,Web,Email1,Email2) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')";
            Query=string.Format(Query,FName,LName,Tel1,Tel2,Cell1,Cell2,Web,Email1,Email2);
            base.DoCommand(Query);
            base.Disconnect();
        }
    }
}
