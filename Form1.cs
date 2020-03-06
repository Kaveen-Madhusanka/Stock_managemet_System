using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkShop_CSharp.BussinusObject;
using WorkShop_CSharp.Entities;

namespace WorkShop_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductEntity product = new ProductEntity();
            product.Product_code1 = txtcode.Text;
            product.Product_name1 = txtname.Text;
            product.Product_description1 = txtdescription.Text;
            product.Qty_in_hand = (float)Convert.ToDouble(txtquntity.Text);
            product.Is_active = true;
            product.Is_deleted = false;


            ProductBO po = new ProductBO();
            if (po.addproduct(product))
            {
                MessageBox.Show("Inserted");
            }
            else
            {
                MessageBox.Show(" not Inserted");
            }


        }
    }
}
