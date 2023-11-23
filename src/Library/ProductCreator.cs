using System.Collections.Generic;
using System.Linq;
using Full_GRASP_And_SOLID;

namespace Library
{
    public class ProductCreator
    {
        private static List<Product> productCatalog = new List<Product>();

        public static Product CreateProduct(string description)
        {
            Product existingProduct = GetProduct(description);

            if (existingProduct != null)
            {
                return existingProduct;
            }

            AddProductToCatalog(description, 0);
            return GetProduct(description);
        }

        public static void AddProductToCatalog(string description, double unitCost)
        {
            productCatalog.Add(new Product(description, unitCost));
        }

        private static Product GetProduct(string description)
        {
            var query = from Product product in productCatalog where product.Description == description select product;
            return query.FirstOrDefault();
        }
    }

}