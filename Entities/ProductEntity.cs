using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_CSharp.Entities
{
    class ProductEntity
    {
        private int id;
        private String Product_code;
        private String Product_name;
        private String Product_description;
        private float qty_in_hand;
        private Boolean is_active;
        private Boolean is_deleted;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public String Product_code1
        {
            get { return Product_code; }
            set { Product_code = value; }
        }
       
        public String Product_name1
        {
            get { return Product_name; }
            set { Product_name = value; }
        }
       
        public String Product_description1
        {
            get { return Product_description; }
            set { Product_description = value; }
        }
        
        public float Qty_in_hand
        {
            get { return qty_in_hand; }
            set { qty_in_hand = value; }
        }
        
        public Boolean Is_active
        {
            get { return is_active; }
            set { is_active = value; }
        }
        
        public Boolean Is_deleted
        {
            get { return is_deleted; }
            set { is_deleted = value; }
        }

        public ProductEntity()
        {
            this.id = 0;
            this.Product_code = "PROD-0000";
            this.Product_name = "ABCD";
            this.Product_description = "This is default product";
            this.qty_in_hand = 0;
            this.is_active = true;
            this.is_deleted = true;
        }

        public ProductEntity(int id,string product_code,string product_name, string product_description, float qty_in_hand, Boolean is_active, Boolean is_deleted)
        {
            this.id = id;
            this.Product_code =product_code;
            this.Product_name = product_name;
            this.Product_description = product_description;
            this.qty_in_hand = qty_in_hand;
            this.is_active = is_active;
            this.is_deleted = is_deleted;
        }
        
    }
}
