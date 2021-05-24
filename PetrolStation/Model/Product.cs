using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation.Model
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Category ProductCategory { get; set; }

        public Product(Category prodCategory)
        {
            ProductCategory = prodCategory;
            ProductCategory.Products.Add(this);
        }
    }
}
