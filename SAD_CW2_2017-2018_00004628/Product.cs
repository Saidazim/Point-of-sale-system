using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD_CW2_2017_2018_00004628
{
    class Product
    {

        public static List<Product> products { get; set; } = new List<Product>()
        {
            new Product()
            {
                ProductName     = "Shirt",
                Price           = "10",
                ProductCategory = new Category() { CategoryName = "Clothes", Value = 1 }
            },
            new Product()
            {
                ProductName     = "Suit",
                Price           = "30",
                ProductCategory = new Category() { CategoryName = "Clothes", Value = 1 }
            },
            new Product()
            {
                ProductName     = "Meat",
                Price           = "5",
                ProductCategory = new Category() { CategoryName = "Foods", Value = 2 }
            },
            new Product()
            {
                ProductName     = "Water",
                Price           = "1",
                ProductCategory = new Category() { CategoryName = "Drinks", Value = 3 }
            }
        };


        public string ProductName { get; set; }

        public string Price { get; set; }

        public Category ProductCategory { get; set; }

        public Byte[] Image { get; set; }
        
    }
}
