using eCommerceApp.Models;
using Microsoft.CodeAnalysis.Elfie.Model.Tree;

namespace eCommerceApp.DataAccess;

public class ProductData : IProductData
{
    private readonly ISqlDataAccess _sql;

    public ProductData(ISqlDataAccess sql)
    {
        _sql = sql;
    }

    public Task<List<Category>> GetCategories()
    {
        throw new NotImplementedException();
    }

    public Task<List<SubCategory>> GetSubCategories(int categoryId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>> GetProducts(int subCategoryId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Image>> GetImages(int productId)
    {
        throw new NotImplementedException();
    }
}
