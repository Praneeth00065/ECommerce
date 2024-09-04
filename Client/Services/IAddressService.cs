using ECommerce.Shared;

namespace ECommerce.Client.Services
{
    public interface IAddressService
    {
        Task<Address> GetAddress();
        Task<Address> AddOrUpdateAddress(Address address);
    }
}
