using ACM.BL;
using Core.Common;
using System;
using System.Windows.Forms;

namespace ACM.Win
{
    public partial class WinOrder : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            // Populate the customer instance

            var order = new Order();
            // Populate the order instance

            var allowSplitOrders = true;
            var emailReceipt = true;

            var payment = new Payment();
            // Populate the payment instance

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
