namespace eCommerceApp.Models;

public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public int SubCategoryId { get; set; }
    public int Price { get; set; }
    public bool IsSale { get; set; }
    public int DiscountPercent { get; set; }
}
