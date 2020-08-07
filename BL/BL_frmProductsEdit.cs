using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DA;

namespace BL
{
    public class BL_frmProductsEdit:DataAccess
    {
  
        public string Code;
        public string TechNo;
        public string Description;
       

        public bool isUnique()
        {
            return true;
        }
        public void Update()
        {
            base.Connect();
            string Query = "UPDATE Products SET TechNo='{0}',Name='{1}' WHERE Code='{2}'";
            Query=string.Format(Query,TechNo,Description,Code);
            base.DoCommand(Query);
            base.Disconnect();

        }
    }
}
