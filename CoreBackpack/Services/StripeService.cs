//using CoreBackpack.cMath;
//using Stripe;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace CoreBackpack.Services
//{
//    public interface IStripeService
//    {
//        Task<string> CreateCustomer(string Name);
//        Task<string> AddCardToCustomer(string customerId, string cardToken);
//        Task<Charge> ChargeCard(string cardToken);
//        Task<Invoice> CreateInvoice(string customerId, decimal amount, string description = "", string currency = "usd", bool autoCharge = false);
//        Task<Invoice> PayInvoice(string invoiceId, string cardId);
//    }

//    public class StripeService : IStripeService
//    {
//        public async Task<string> CreateCustomer(string Name)
//        {
//            var options = new CustomerCreateOptions
//            {
//                Name = Name,
//            };

//            var service = new CustomerService();
//            Customer customer = await service.CreateAsync(options);
//            return customer.Id;
//        }

//        public async Task<string> AddCardToCustomer(string customerId, string cardToken)
//        {
//            var service = new CustomerService();
//            var customer = await service.UpdateAsync(customerId, new CustomerUpdateOptions()
//            {
//                Source = cardToken
//            });

//            return customer.DefaultSourceId;
//        }

//        public async Task<Charge> ChargeCard(string cardToken)
//        {
//            var chargeService = new ChargeService();
//            return await chargeService.CreateAsync(new ChargeCreateOptions()
//            {
//                Source = cardToken
//            });
//        }

//        public async Task PurchaseSubscription(string customerId, string paymentMethodId, List<string> PriceIds)
//        {
//            var subscriptionService = new SubscriptionService();

//            var items = new List<SubscriptionItemOptions>();

//            // this is the subscription
//            foreach (var priceId in PriceIds)
//            {
//                items.Add(new SubscriptionItemOptions
//                {
//                    Price = priceId,
//                });
//            }

//            var subscriptionOptions = new SubscriptionCreateOptions
//            {
//                Customer = customerId,
//                DefaultPaymentMethod = paymentMethodId,
//                Items = items
//            };

//            var paymentIntent = await subscriptionService.CreateAsync(subscriptionOptions);
//            if (paymentIntent.Status == "active")
//            {
//                // save to transaction table
//            }
//            else
//            {
//                //context.TransactionLineItems.Add(new TransactionLineItem()
//                //{
//                //    Plan = servicesGateway.Plans,
//                //    Amount = servicesGateway.Price,
//                //    TransactionId = transactionId,
//                //    Error = paymentIntent.Status,
//                //    Qty = 1,
//                //});
//                //await context.SaveChangesAsync();

//                //return new ChargedResult()
//                //{
//                //    IsSuccessful = false,
//                //    Error = paymentIntent.Status
//                //};
//            }
//        }

//        public async Task PurchaseProduct(string customerId, string paymentMethodId, decimal totalAmount)
//        {
//            var service = new PaymentIntentService();
//            var options = new PaymentIntentCreateOptions
//            {
//                Amount = MoneyExtender.ConvertToCents(totalAmount),
//                Currency = "usd",
//                PaymentMethodTypes = new List<string> { "card" },
//                Customer = customerId,
//                PaymentMethod = paymentMethodId,
//                Confirm = true,
//                OffSession = true,
//            };
//            var paymentIntent = await service.CreateAsync(options);
//            if (paymentIntent != null)
//            {
//                if (paymentIntent.Status == "succeeded")
//                {

//                }
//                else
//                {

//                }
//            }
//        }

//        public async Task<Invoice> CreateInvoice(string customerId, decimal amount, string description = "", string currency = "usd", bool autoCharge = false)
//        {
//            var invoiceItemOptions = new InvoiceItemCreateOptions
//            {
//                Amount = MoneyExtender.ConvertToCents(amount),
//                Currency = currency,
//                Customer = customerId,
//                Description = description
//            };

//            var service = new InvoiceItemService();
//            var invoiceItem = await service.CreateAsync(invoiceItemOptions);

//            var invoiceOptions = new InvoiceCreateOptions
//            {
//                Customer = customerId,
//                AutoAdvance = autoCharge, // auto-finalize this draft after ~1 hour
//            };

//            var _service = new Stripe.InvoiceService();
//            var invoice = await _service.CreateAsync(invoiceOptions);

//            return invoice;
//        }

//        public async Task<Invoice> PayInvoice(string invoiceId, string cardId)
//        {
//            var service = new Stripe.InvoiceService();
//            var invoice = await service.PayAsync(invoiceId, new InvoicePayOptions()
//            {
//                Source = cardId
//            });
//            return invoice;
//        }
//    }
//}