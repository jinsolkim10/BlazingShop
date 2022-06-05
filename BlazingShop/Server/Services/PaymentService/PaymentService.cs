using BlazingShop.Shared;
using Stripe;
using Stripe.Checkout;

namespace BlazingShop.Server.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        public PaymentService()
        {
            StripeConfiguration.ApiKey = "sk_test_51L7BIWDSWiaDVUiBIBUGEcbf3TeyVRxyMYz3wj5OclvidK5dcysKR4vc16vLnUlUzLWjN3FsBgDLdF5AOwxJHU0o00RALHg0uX";
        }
        public Session CreateCheckoutSession(List<CartItem> cartItems)
        {
            var lineItems = new List<SessionLineItemOptions>();
            cartItems.ForEach(ci => lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmountDecimal = ci.Price * 100,
                    Currency = "usd",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = ci.ProductTitle,
                        Images = new List<string> { ci.Image }
                    }
                },
                Quantity = ci.Quantity
            }));

            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string>
                {
                    "card"
                },
                LineItems = lineItems,
                Mode = "payment",
                SuccessUrl = "https://localhost:7036/order-success",
                CancelUrl = "https://localhost:7036/cart",
            };


                var service = new SessionService();
                Session session = service.Create(options);
            return session;
        }



    }
}

