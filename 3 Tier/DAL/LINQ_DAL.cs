using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend;

namespace DAL
{
    public class LINQ_DAL : IDAL
    {
        public List<Product> DB;

        public LINQ_DAL()
        {
            DB = new List<Product>();

            DB.Add(new Product("beans", "food", 0));
            DB.Add(new Product("corn", "food", 1));
            DB.Add(new Product("scale", "food", 2));
            DB.Add(new Product("tv", "electronics", 3));
            DB.Add(new Product("scale", "electronics", 4));
            DB.Add(new Product("corn", "food", 5));
            DB.Add(new Product("shirt", "clothes", 6));
            DB.Add(new Product("pants", "clothes", 7));
        }

        public void AddProduct(Backend.Product p)
        {
            throw new NotImplementedException();
        }

        public List<Backend.Product> ProductNameQuery(string name)
        {
            throw new NotImplementedException();
        }

        public List<Backend.Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
