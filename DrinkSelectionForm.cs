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
using static System.Windows.Forms.LinkLabel;

namespace ISDS309_FinalProject_Vending
{
	public partial class DrinkSelectionForm : Form
	{
		// 2D list for storing drink data
		private string[,] drinks;

		// 2D list for storing selected drinks
		private string[,] selectedDrinks;

		// number of selected drinks
		private int selectedDrinksCount;

		// customer name
		private string customerName;

		public DrinkSelectionForm(string name)
		{
			InitializeComponent();
			customerName = name;

			// set selected drinks count to 0
			selectedDrinksCount = 0;

			// Load drink data from text file
			drinks = LoadDrinkData();

			// Populate the drink list
			for (int i = 0; i < drinks.GetLength(0); i++)
			{
				lstDrinks.Items.Add(drinks[i, 0]);
			}

			// Initialize selected drinks list as the the maximum number of selected drinks can not exceed total number of drinks
			selectedDrinks = new string[getMaxSelectedDrinksListLength(), 3];

		}

		private int getMaxSelectedDrinksListLength()
		{
			int max = 0;
			// loop through the drinks array
			for (int i = 0; i < drinks.GetLength(0); i++)
			{
				// if the drink has a stock
				if (drinks[i, 0] != null && Convert.ToInt32(drinks[i, 2]) > 0)
				{
					// add the stock to the max
					max += Convert.ToInt32(drinks[i, 2]);
				}
			}
			return max;
		}

		private string[,] LoadDrinkData()
		{
			string[] lines = File.ReadAllLines("drinkData.txt");
			string[,] drinkData = new string[lines.Length, 3];
			for (int i = 0; i < lines.Length; i++)
			{
				// split each line into fields
				string[] fields = lines[i].Split(',');
				// add each field to the 2D array of drinkData
				for (int j = 0; j < 3; j++)
				{
					drinkData[i, j] = fields[j];
				}
			}

			return drinkData;
		}

		private void lstDrinks_SelectedIndexChanged(object sender, EventArgs e)
		{
			// get the new selected drink index
			int selectedIndex = lstDrinks.SelectedIndex;

			// display the drink information if a drink is selected
			if (selectedIndex != -1)
			{
				lblPrice.Text = "Price : " + "$" + drinks[selectedIndex, 1].ToString();
				lblInventory.Text = "Inventory : " + drinks[selectedIndex, 2].ToString();
			}
			else // otherwise clear previous information.
			{
				lblPrice.Text = "Price : " + "$0";
				lblInventory.Text = "Inventory : 0";
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			int selectedIndex = lstDrinks.SelectedIndex;
			if (selectedIndex != -1)
			{
				// check if the drink has any stock left
				if (Convert.ToInt32(drinks[selectedIndex, 2]) > 0)
				{
					// add a drink to the selected drinks list
					selectedDrinks[selectedDrinksCount, 0] = drinks[selectedIndex, 0];
					selectedDrinks[selectedDrinksCount, 1] = drinks[selectedIndex, 1];
					selectedDrinks[selectedDrinksCount, 2] = 1 + "";

					// update the drinks stock by subtracting 1
					drinks[selectedIndex, 2] = (Convert.ToInt32(drinks[selectedIndex, 2]) - 1).ToString();
					lblInventory.Text = "Inventory : " + drinks[selectedIndex, 2].ToString();

					// refresh the selected drinks list
					selectedDrinksCount++;
					LoadSelectedDrinks();
				}
				else
				{
					MessageBox.Show("Sorry, this drink is out of stock.");
				}
			}
		}

		private void LoadSelectedDrinks()
		{
			// Clear the selected drinks list
			lstSelectedDrinks.Items.Clear();

			// Load the selected drink list from the 2D array.
			for (int i = 0; i < selectedDrinksCount; i++)
			{
				lstSelectedDrinks.Items.Add(i + 1 + " - " + selectedDrinks[i, 0]);
			}

			// Set the total cost for the selected drinks.
			lblTotalCost.Text = "Total : " + "$" + CalculateTotalCost().ToString("F");
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			// get the selected drink index
			int selectedIndex = lstSelectedDrinks.SelectedIndex;
			if (selectedIndex > -1)
			{
				// Check for the drink in the drinks list
				for (int i = 0; i < drinks.GetLength(0); i++)
				{
					// if the drink is found, update the stock by adding 1
					if (drinks[i, 0] == selectedDrinks[selectedIndex, 0])
					{
						drinks[i, 2] = (Convert.ToInt32(drinks[i, 2]) + 1).ToString();

						// clear the drinks selection to update the inventory and break this loop.
						lstDrinks.SelectedIndex = -1;
						break;
					}
				}

				// Now shift all the drinks in the selected drinks list to the left by 1 from the selected index.
				// This will remove the selected drink from the selected drinks list.
				for (int i = selectedIndex; i < selectedDrinksCount - 1; i++)
				{
					selectedDrinks[i, 0] = selectedDrinks[i + 1, 0];
					selectedDrinks[i, 1] = selectedDrinks[i + 1, 1];
					selectedDrinks[i, 2] = selectedDrinks[i + 1, 2];
				}

				// update the selected drinks count and refresh the selected drinks list.
				selectedDrinksCount--;
				LoadSelectedDrinks();
			}


		}

		private void btnCheckout_Click(object sender, EventArgs e)
		{
			// check if there are any drinks selected
			if (selectedDrinksCount == 0)
			{
				MessageBox.Show("Please select at least one drink to purchase.");
			}
			else
			{
				// show the checkout form
				double totalCost = CalculateTotalCost();
				CheckoutForm checkoutForm = new CheckoutForm(customerName, selectedDrinks, totalCost);

				// check if the transaction was successfull or not
				if (checkoutForm.ShowDialog() == DialogResult.OK)
				{
					// close this form only if the transaction was successfull
					this.Close();
				}

			}
		}

		// calculate the total cost of the selected drinks
		private double CalculateTotalCost()
		{
			// initialize the total cost to 0
			double total = 0;

			// loop through all the selected drinks and add the cost to the total
			for (int i = 0; i < selectedDrinksCount; i++)
			{
				total += Convert.ToDouble(selectedDrinks[i, 1]);
			}
			return total;
		}
	}
}