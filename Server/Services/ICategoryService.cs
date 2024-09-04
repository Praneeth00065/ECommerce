using Ecommerce.Shared;

namespace ECommerce.Server.Services
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();
        Task<ServiceResponse<List<Category>>> GetAdminCategories();
        Task<ServiceResponse<List<Category>>> AddCategory(Category category);
        Task<ServiceResponse<List<Category>>> UpdateCategory(Category category);
        Task<ServiceResponse<List<Category>>> DeleteCategory(int id);
    }
}
