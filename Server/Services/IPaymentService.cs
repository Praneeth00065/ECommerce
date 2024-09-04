using Ecommerce.Shared;
using Stripe.Checkout;

namespace ECommerce.Server.Services
{
    public interface IPaymentService
    {
        Task<Session> CreateCheckoutSession();
        Task<ServiceResponse<bool>> FulfillOrder(HttpRequest request);
    }
}
