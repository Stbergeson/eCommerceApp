using eCommerceApp.Models;

namespace eCommerceApp.Pages;

public partial class NavMenu
{
    private List<Category> _categories= new List<Category>();
    private List<SubCategory> _subCategories= new List<SubCategory>();

    public async Task GetCategories()
    {
        //get all categories
        _categories.Add(new Category { Id = 1, Title = "Furniture"});
        _categories.Add(new Category { Id = 2, Title = "Clothing" });
        _categories.Add(new Category { Id = 3, Title = "Electronics" });
        //get all sub categories
        _subCategories.Add(new SubCategory { Id = 1, Title = "Beds", CategoryId= 1 });
        _subCategories.Add(new SubCategory { Id = 2, Title = "Dressers", CategoryId = 1 });
        _subCategories.Add(new SubCategory { Id = 3, Title = "Chairs", CategoryId = 1 });

        _subCategories.Add(new SubCategory { Id = 4, Title = "Shirts", CategoryId = 2 });
        _subCategories.Add(new SubCategory { Id = 5, Title = "Dresses", CategoryId = 2 });
        _subCategories.Add(new SubCategory { Id = 6, Title = "Pants", CategoryId = 2 });

        _subCategories.Add(new SubCategory { Id = 7, Title = "Computers", CategoryId = 3 });
        _subCategories.Add(new SubCategory { Id = 8, Title = "Televisions", CategoryId = 3 });
        _subCategories.Add(new SubCategory { Id = 9, Title = "Monitors", CategoryId = 3 });
    }
}
