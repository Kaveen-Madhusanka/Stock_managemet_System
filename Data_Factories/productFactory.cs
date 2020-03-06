using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkShop_CSharp.Entities;
using WorkShop_CSharp.Support;
using System.Data.SqlClient;
using System.Data;

namespace WorkShop_CSharp.Data_Factories
{
    class productFactory
    {
        public bool add(ProductEntity product)
        {
            bool rvalue = false;

            try
            {
                if (DBconnection.Connect())
                {
                    SqlCommand cmd = new SqlCommand("new_product",DBconnection.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@code",SqlDbType.VarChar).Value = product.Product_code1;
                    cmd.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = product.Product_name1;
                    cmd.Parameters.AddWithValue("@description", SqlDbType.Text).Value = product.Product_description1;
                    cmd.Parameters.AddWithValue("@qty_in_hand", SqlDbType.Float).Value = product.Qty_in_hand;
                    cmd.Parameters.AddWithValue("@is_active", SqlDbType.TinyInt).Value = product.Is_active;
                    cmd.Parameters.AddWithValue("@is_deleted", SqlDbType.TinyInt).Value = product.Is_deleted;
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    cmd.Dispose();
                    rvalue = true;


                }
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.ToString());
            }

            return rvalue;
            
        }
    }
}
