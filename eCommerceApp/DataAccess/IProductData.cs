using eCommerceApp.Models;

namespace eCommerceApp.DataAccess
{
    public interface IProductData
    {
        Task<List<Category>> GetCategories();
        Task<List<Image>> GetImages(int productId);
        Task<List<Product>> GetProducts(int subCategoryId);
        Task<List<SubCategory>> GetSubCategories(int categoryId);
    }
}