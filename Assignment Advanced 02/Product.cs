using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced_02
{
    internal class Product
    {
            //public Product(int id, string name, string category, double price, int stock)
            //{
            //    Id = id;
            //    Name = name;
            //    Category = category;
            //    Price = price;
            //    Stock = stock;
            //}

            public int Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public double Price { get; set; }
            public int Stock { get; set; }

            public static List<Product> SearchProducts(List<Product> product, Func<Product, bool> valid)
            {
                List<Product> searchproducts = new List<Product>();
                foreach (Product p in product)
                {
                    if (valid(p))
                        searchproducts.Add(p);

                }
                return searchproducts;
            }


        public static void PrintReports(List<Product> product , Action<Product> action)
        {
            foreach (Product p in product)
            {
                action(p);
            }
        }
            public static List<string> TransformProducts(List<Product> product, Func<Product, string> valid)
            {
                List<string> tostring = new List<string>();
                foreach (Product p in product)
                {   
                    tostring.Add(valid(p));
                }
                return tostring;
            }
            public static List<Product> FilterProducts(List<Product> product, Predicate<Product> filtr)
            {
                List<Product> fps = new List<Product>();
                foreach (Product p in product)
                {
                if(filtr(p))
                    fps.Add(p);
                }
                return fps;
            }

    }

}
