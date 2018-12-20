using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Common;

namespace ACM.BL
{
    public class OrderController
    {
        public void PlaceOrder(Customer customer, Order order, Payment payment, bool allowSplitOrders, bool emailReceipt)
        {
            var customerRepository = new CustomerRepository();
            customerRepository.Add(customer);

            var orderRepository = new OrderRepository();
            orderRepository.Add(order);

            var inventoryRepository = new InventoryRepository();
            inventoryRepository.OrderItems(order, allowSplitOrders);

            payment.ProcessPayment(payment);

            if (emailReceipt)
            {
                customer.ValidateEmail();
                customerRepository.Update();

                var emailLibrary = new EmailLibrary();
                emailLibrary.SendLibrary(customer.EmailAddress, "Here is your receipt");
            }
        }
    }
}
