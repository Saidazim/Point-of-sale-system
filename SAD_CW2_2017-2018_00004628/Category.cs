using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD_CW2_2017_2018_00004628
{
    class Category
    {
        public static List<Category> List { get; set; } = new List<Category>()
        {
            new Category()
            {
                CategoryName = "Clothes",
                Value = 1
            },
            new Category()
            {
                CategoryName = "Foods",
                Value = 2
            },
            new Category()
            {
                CategoryName = "Drinks",
                Value = 3
            }
        };

        public string CategoryName { get; set; }

        public int Value { get; set; }

        public override string ToString()
        {
            return this.CategoryName;
        }
    }
}
