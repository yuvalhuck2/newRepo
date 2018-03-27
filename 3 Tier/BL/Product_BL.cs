using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend;
using DAL;

namespace BL
{
    public class Product_BL : IBL
    {
        IDAL itsDAL;

        public Product_BL(IDAL dal)
        {
            itsDAL = dal;
        }

        public void AddProduct(Backend.Product p)
        {
            throw new NotImplementedException();
        }

        public List<Product> FindProductByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
