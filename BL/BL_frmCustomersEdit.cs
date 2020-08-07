using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using System.Data;
using System.Data.OleDb;


namespace BL
{
    public class BL_frmCustomersEdit:DataAccess
    {
        public string Code;
        public string FName;
        public string LName;
        public string City;
        public string CompanyName;
        public string Cell;
        public string Tel;
        public string Address;
        public string Email;

        public void Update()
        {
            base.Connect();
            string Query = "UPDATE Customers SET FName='{0}',LName='{1}',Company='{2}',City='{3}',Cell='{4}',Tell='{5}',Address='{6}',Email='{7}' WHERE Code='{8}'";
            
            Query=string.Format(Query,FName,LName,City,CompanyName,Cell,Tel,Address,Email,Code);
            base.DoCommand(Query);
            base.Disconnect();
        }

    }
}
