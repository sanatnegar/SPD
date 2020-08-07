using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace DA
{
    public class DataAccess
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataTable dt;

        public DataAccess()
        {
            con=new OleDbConnection();
            da=new OleDbDataAdapter();
            cmd = new OleDbCommand();
            cmd.Connection = con;
            da.SelectCommand = cmd;

        }
        public void Connect()
        {
            //con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\SPD\\SPD_DB\\SPD.accdb";
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+"\\SPD.accdb";
            con.Open();

        }
        public void Disconnect()
        {
            con.Close();
        }

        public DataTable SelectData(string strSQL)
        {
            cmd.CommandText = strSQL;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        public void DoCommand(string strSQL)
        {
            cmd.CommandText = strSQL;
            cmd.ExecuteNonQuery();
        }
        public double DoCommandScalar(string strSQL)
        {
            double output;
            cmd.CommandText = strSQL;
            output=Convert.ToDouble(cmd.ExecuteScalar());
            return output;
        }

    }
}
