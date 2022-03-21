using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Proj2_Ali
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Declaration of global variables
        public string patty;
        public decimal cost = 4;
        public double pattyCount;
        public string beverage;

        public MainWindow()
        {
            InitializeComponent();
            //Initial base cost is disiplayed in currency format
            //I will do a DYNAMIC cost label
            lblInitialCost.Content = string.Format("{0:C}", cost);
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

            if (lblInitialCost != null)
            {
                patty = "Spicy Beef";
                //base cost is the same when spicy beef is selected
                lblInitialCost.Content = string.Format("{0:C}", cost);
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            patty = "Garlic Chicken";
            //base cost is the same when garlic chicken is selected
            lblInitialCost.Content = string.Format("{0:C}", cost);
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            patty = "Potato and Beans";
            //base cost is the same when potato and beans is selected 
            lblInitialCost.Content = string.Format("{0:C}", cost);
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            double changedValue = e.NewValue - e.OldValue;

            //when slider value is manipulated, update the cost accordingly 
            //Convert value of slider to decimal
            if (changedValue <= 0)
            {
                cost = cost + ((decimal)0.50 * Convert.ToDecimal(changedValue));
            }
            else
            {
                cost = cost + ((decimal)0.50 * Convert.ToDecimal(changedValue));
            }

            //display updated cost after slider manipulation in currency format
            lblInitialCost.Content = string.Format("{0:C}", cost);
            lblExtraPatties.Content = sldPatty.Value.ToString();

        }

        //when cheese object is checked, no event
        private void chkCheese_Checked(object sender, RoutedEventArgs e)
        {

        }

        //when pickles is selected, cost event must be updated and displayed
        private void chkPickles_Checked(object sender, RoutedEventArgs e)
        {
            //if pickles is selected, update cost
            if (chkPickles.IsChecked.Value)
            {
                cost = cost + (decimal)(1.0);
            }
            else
            {
                cost = cost - (decimal)(1.0);
            }

            lblInitialCost.Content = string.Format("{0:C}", cost);
        }



        private void btnConfirmOrder_Click(object sender, RoutedEventArgs e)
        {
            //String builder creates variables to contain any text, this is based on our requirements. 
            StringBuilder sb = new StringBuilder();

            string strmessage = string.Empty;

            //if no value is entered into name textbox, turn it red and do not allow submission until it is filled
            if (string.IsNullOrEmpty(txtName.Text))
            {
                txtName.Background = Brushes.Red;
                return;
            }

            sb.Append($"Thank you for visting Maryam's Burger Shack, {txtName.Text}!");
            //Environment.NewLine is used to add a new line in the message box. 
            sb.Append(Environment.NewLine);

            //manipulate string result based on manipulation or lack of, on the slide
            if (sldPatty.Value == 0)
                sb.Append($"You ordered {patty} patty burger.");
            else
                sb.Append($"You ordered {sldPatty.Value.ToString()} extra patties with your {patty} patty burger.");

            //if a checkbox is not checked, do not include a string value for these vars 
            string strChz = string.Empty;
            string strPickles = string.Empty;

            //if these values are checked, please assign cheese to the variable, and pickles to the variable
            if (chkCheese.IsChecked.Value)
                strChz = "cheese";
            if (chkPickles.IsChecked.Value)
                strPickles = "pickles";

            //if both pickles and cheese are selected, please add this line
            if (!string.IsNullOrEmpty(strPickles) && !string.IsNullOrEmpty(strChz))
                sb.Append(strmessage + " With " + strChz + " and " + strPickles + ".");
            //if pickles is selected, please add this line
            else if (!string.IsNullOrEmpty(strPickles))
                sb.Append(strmessage + " With " + strPickles + ".");
            //if cheese is selected, please add this line
            else if (!string.IsNullOrEmpty(strChz))
                sb.Append(strmessage + " With " + strChz + ".");

            sb.Append(Environment.NewLine);
            //string result based on beverage selection
            sb.Append("We will add " + cboBeverage.Text + " to your order.");

            sb.Append(Environment.NewLine);
            if (!string.IsNullOrEmpty(txtOther.Text))
                //if other is not empty, please add this line
                sb.Append("We will do our best to fulfill your additional request of " + txtOther.Text + ".");

            sb.Append(Environment.NewLine);
            //display dynamic order total
            sb.Append($"Your order total is {string.Format("{0:C}", cost)}.");

            sb.Append(Environment.NewLine);
            //display order #
            sb.Append("Your order # is 651, it will be ready in about 10 minutes!");


            //show message box with final string sb
            MessageBox.Show(sb.ToString());

        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if value is added to the textbox, change background color to white and allow confirmation of order
            txtName.Background = Brushes.White;
        }


    }
}
