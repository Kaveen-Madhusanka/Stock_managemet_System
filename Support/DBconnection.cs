using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WorkShop_CSharp.Support
{
    class DBconnection
    {
        public static SqlConnection Connection;
        public static String connectionString = @"Data Source=DESKTOP-7NPAUSD\SQLEXPRESS;Initial Catalog=workshopCsharp;Integrated Security=True";

        public static bool Connect()
        {
            bool rvalue = false;
            if ((Connection == null) || (Connection.State == System.Data.ConnectionState.Closed))
            {
                if (!String.IsNullOrEmpty(connectionString))
                {
                    try
                    {
                        Connection = new SqlConnection(connectionString);
                        rvalue = true;
                    }
                    catch
                    {
                        throw;
                    }

                }
                else
                {
                    MessageBox.Show("Somethin Went to wrong with the connection!!");
                }
            }
            else
            {
                rvalue = true;
            }
            return rvalue;
        }
       
    }
}
