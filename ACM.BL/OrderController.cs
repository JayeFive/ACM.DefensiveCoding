﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Common;

namespace ACM.BL
{
    public class OrderController
    {
        private CustomerRepository customerRepository { get; set; }
        private OrderRepository orderRepository { get; set; }
        private InventoryRepository inventoryRepository { get; set; }
        private EmailLibrary emailLibrary { get; set; }

        public OrderController()
        {
            customerRepository = new CustomerRepository();
            orderRepository = new OrderRepository();
            inventoryRepository = new InventoryRepository();
            emailLibrary = new EmailLibrary();
        }

        public void PlaceOrder(Customer customer, Order order, Payment payment, bool allowSplitOrders, bool emailReceipt)
        {
            customerRepository.Add(customer);
            orderRepository.Add(order);
            inventoryRepository.OrderItems(order, allowSplitOrders);
            payment.ProcessPayment(payment);

            if (emailReceipt)
            {
                customer.ValidateEmail();
                customerRepository.Update();

                emailLibrary.SendLibrary(customer.EmailAddress, "Here is your receipt");
            }
        }
    }
}
