using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace ISDS309_FinalProject_Vending
{
    public partial class CheckoutForm : Form
    {
		// customer name
        private string customerName;

		// 2D array for selected drinks
		private string[,] selectedDrinks;

		// total cost of drinks
		private double totalCost;

		// number of drinks
		private int selectedDrinksCount;

		public CheckoutForm(string name, string[,] drinks, double cost)
        {
            InitializeComponent();
			// set the drinks count to 0
			selectedDrinksCount = 0;

            // set the parameter values to fields
            customerName = name;
            selectedDrinks = drinks;
            totalCost = cost;

			// display the selected drinks
			DisplayOrderDetails();
        }

        private void DisplayOrderDetails()
		{
			 double total = 0;
			lstSelectedDrinks.Items.Clear();

			// loop through the selected drinks array
			for (int i = 0; i < selectedDrinks.GetLength(0); i++)
			{
				// if there is a drink in the array
				if (!string.IsNullOrWhiteSpace(selectedDrinks[i, 0]))
				{
					// add the drink to the listbox
					lstSelectedDrinks.Items.Add(i + 1 + " - " + selectedDrinks[i, 0]);
					// add the drink cost to the total
					total += Convert.ToDouble(selectedDrinks[i, 1]);
                }
                else
                {
					// if there is no drink in the array, set the total count and break out of the loop
					selectedDrinksCount = i;
                    break;
                }

				// set the selected index count to the max value since the loop will terminate
				if (i == selectedDrinks.GetLength(0) - 1)
				{
					selectedDrinksCount = i + 1;
				}
			}

			// display the total cost
			lblTotalCost.Text = "Total Cost : " + "$" + total.ToString("F");
		}

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            // Get the current card details of user
            string cardNumber = txtCardNumber.Text;
            string cvv = txtCVV.Text;
            string expiration = txtExpiration.Text;

			// Check if the card details are valid
			if (string.IsNullOrWhiteSpace(cardNumber) || string.IsNullOrWhiteSpace(cvv) || string.IsNullOrWhiteSpace(expiration))
            {
                MessageBox.Show("Please fill in all the payment details.");
            }
            else if (cardNumber.Length != 16 || !cardNumber.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 16-digit credit card number.");
            }
            else if (cvv.Length != 3 || !cvv.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 3-digit CVV number.");
            }
            else if (!DateTime.TryParseExact(expiration, "MM/yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime expirationDate))
			{
				MessageBox.Show("Please enter a valid expiration date in the format MM/yy.");
			}
			else
            {
                // Update drink inventory
                UpdateDrinkInventory();

                // Generate receipt and transaction log
                GenerateReceipt();
                GenerateTransactionLog();

                MessageBox.Show("Transaction successful. Thank you for your purchase!");

				// Set the dialog result to OK as the transaction was successful, to close the selection form.
				this.DialogResult = DialogResult.OK;
				// close the form
				this.Close();
            }
        }

        private void UpdateDrinkInventory()
        {
			// Read the drinks data from the inventory file
			string[] lines = File.ReadAllLines("drinkData.txt");

			// loop through all the lines loaded from the text file
			for (int i = 0; i < lines.Length; i++)
            {
				// split the line into an array
				string[] fields = lines[i].Split(',');

				// get the drink name and quntity
				string drinkName = fields[0];
				int drinkQuantity = Convert.ToInt32(fields[2]);

				// loop through the selected drinks array
				for (int j = 0; j < selectedDrinksCount; j++)
				{
					// if the drink name matches the selected drink
					if (drinkName == selectedDrinks[j, 0])
					{
						// get the drink quantity and decrease it by 1
						drinkQuantity -= 1;
					}
				}
				// update the line with the new quantity
				lines[i] = fields[0] + "," + fields[1] + "," + drinkQuantity;
			}
			// write the updated lines to the file
			File.WriteAllLines("drinkData.txt", lines);
        }

        private void GenerateReceipt()
        {
			// add the customer name and other information to the receipt
			string receipt = "Customer: " + customerName + Environment.NewLine;
            receipt += "Order date: " + DateTime.Now.ToShortDateString() + Environment.NewLine;
            receipt += "Order time: " + DateTime.Now.ToShortTimeString() + Environment.NewLine;
            receipt += "Drinks:" + Environment.NewLine;

			// loop through the selected drinks array and add the drinks names to the receipt
			for (int i = 0; i < selectedDrinksCount; i++)
			{
                receipt +=  (i + 1) + " - " + selectedDrinks[i, 0] + Environment.NewLine;
            }

			// add the total cost to the receipt
			receipt += "Total cost: $" + totalCost.ToString("F") + Environment.NewLine;

			// write the receipt to the file, the file name is the current date and time in the format MM-dd-yyyy HH-mm-ss
			File.WriteAllText("receipt-" + DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss") + ".txt", receipt);
        }

        private void GenerateTransactionLog()
        {
			// add the customer name and other information to the transaction log
			string transaction =DateTime.Now.ToString("MM-dd-yyyy") + " / ";
            transaction += DateTime.Now.ToShortTimeString() + " / ";
			transaction += customerName + " / ";
			// add the total cost to the transaction log
			transaction += "$" + totalCost.ToString("F") + Environment.NewLine;

			// Append the transaction log to the file, the file name is the current date and time in the format MM-dd-yyyy
			File.AppendAllText("transactionLog-" + DateTime.Now.Date.ToString("MM-dd-yyyy") + ".txt", transaction);
		}
    }
}
