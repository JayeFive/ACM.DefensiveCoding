using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACM.BL;

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

            var payment = new Payment();
            // Populate the payment instance

            var customerRepository = new CustomerRepository();
            customerRepository.Add(customer);

            var orderRepository = new OrderRepository();
            orderRepository.Add(order);

            var inventoryRepository = new InventoryRepository();
            inventoryRepository.OrderItems(order, allowSplitOrders);

            payment.ProcessPayment(payment);
        }
    }
}
