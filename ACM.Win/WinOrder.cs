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
            PlaceOrder();
        }

        private void PlaceOrder()
        {
            var customer = new Customer();
            // Populate the customer instance

            var order = new Order();
            // Populate the order instance

            var allowSplitOrders = true;
            var emailReceipt = true;

            var payment = new Payment();
            // Populate the payment instance

            var orderController = new OrderController();

            orderController.PlaceOrder(customer, order, payment, allowSplitOrders, emailReceipt);
        }

    }
}
