using Ecommerce.Shared;
using ECommerce.Shared;

namespace ECommerce.Server.Services
{
    public interface IProductTypeService
    {

        Task<ServiceResponse<List<ProductType>>> GetProductTypes();
        Task<ServiceResponse<List<ProductType>>> AddProductType(ProductType productType);
        Task<ServiceResponse<List<ProductType>>> UpdateProductType(ProductType productType);
    }
}
