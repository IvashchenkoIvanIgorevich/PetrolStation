using System.Collections;
using System.Collections.Generic;

namespace PetrolStation.Model
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IEnumerable<Category> SubCategories { get; set; } = new List<Category>();
        public List<Product> Products { get; set; } = new List<Product>();

        public Category(IEnumerable<Category> subCategories)
        {
            SubCategories = subCategories;
        }
    }
}
