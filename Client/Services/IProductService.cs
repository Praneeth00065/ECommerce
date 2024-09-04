using Ecommerce.Shared;

namespace ECommerce.Client.Services
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        string Message { get; set; }
        Task GetProducts(string? categoryUrl = null);
        int CurrentPage { get; set; }
        int PageCount { get; set; }
        string LastSearchText { get; set; }
        Task<ServiceResponse<Product>> GetProduct(int productId);
        Task SearchProducts(string searchText, int page);
        Task<List<string>> GetProductSearchSuggestions(string searchText);
        List<Product> AdminProducts { get; set; }
        Task GetAdminProducts();
        Task<Product> CreateProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task DeleteProduct(Product product);
    }
}
