using System;
using CoffeeShop.Models;
namespace CoffeeShop
{
	public class ProductRepository
	{
        private List<ProductViewModel> _mockProducts;

        public ProductRepository()
        {
            CreateMockProductList();
        }
        private void CreateMockProductList()
        {
            _mockProducts = new List<ProductViewModel>();
            _mockProducts.Add(new ProductViewModel { Id = 1, Name = "Double Expresso", Description = "Double Shot of Cuban Coffee Expresso", Price= 2.99, Category="Hot Coffee" });
            _mockProducts.Add(new ProductViewModel { Id = 2, Name = "Cappuccino", Description = "Expresso drink with steamed milk", Price = 4.99, Category ="Hot Coffee" });
            _mockProducts.Add(new ProductViewModel { Id = 3, Name = "Water", Description = "Spring water from the french alps ", Price = 2.49,Category="Water" });
            _mockProducts.Add(new ProductViewModel { Id = 4, Name = "Strawnana Smoothie", Description = "Strawberry banana smoothie", Price= 5.99,Category="Frozen Drink"});
            _mockProducts.Add(new ProductViewModel { Id = 5, Name = "Hazelnut Frappuccino", Description = "Frozen Coffee drink with added hazelnut flavoring", Price = 7.49,Category="Frozen Drink" });
            _mockProducts.Add(new ProductViewModel { Id = 3, Name = "Egg and cheese Sandwich", Description = "Toasted Croassiant with a egg over hard and cheese ", Price = 3.49, Category = "Food" });
        }
        public IEnumerable<ProductViewModel> GetMockProducts()
        {
            return _mockProducts;
        }

        public void UpdateProduct(ProductViewModel product)
        {
            int index = _mockProducts.FindIndex(x => x.Id == product.Id);
            _mockProducts[index] = product;
        }

        public void DeleteProduct(int id)
        {
            int index = _mockProducts.FindIndex(x => x.Id == id);
            _mockProducts.RemoveAt(index);
        }

        public void CreateProduct(ProductViewModel product)
        {
            product.Id = _mockProducts.Max(x => x.Id) + 1;
            _mockProducts.Add(product);
        }

    }
}

