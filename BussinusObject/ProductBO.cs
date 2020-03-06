using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop_CSharp.Data_Factories;
using WorkShop_CSharp.Entities;


namespace WorkShop_CSharp.BussinusObject
{
    class ProductBO
    {
        public bool addproduct(ProductEntity product)
        {
            productFactory pf = new productFactory();
            return pf.add(product);
        }
    }
}
