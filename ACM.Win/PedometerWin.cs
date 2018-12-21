using ACM.BL;
using System;
using System.Windows.Forms;

namespace ACM.Win
{
    public partial class PedometerWin : Form
    {
        public PedometerWin()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            var result = customer.CalculatePercentageOfGoalSteps(GoalTextBox.Text, StepsTextBox.Text);

            ResultLLabel.Text = "You reached " + result + "% of your goal!";
        }
    }
}
