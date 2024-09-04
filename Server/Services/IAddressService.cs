using Ecommerce.Shared;
using ECommerce.Shared;

namespace ECommerce.Server.Services
{
    public interface IAddressService
    {
        Task<ServiceResponse<Address>> GetAddress();
        Task<ServiceResponse<Address>> AddOrUpdateAddress(Address address);
    }
}
