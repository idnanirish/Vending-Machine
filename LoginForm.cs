using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ISDS309_FinalProject_Vending
{
    public partial class LoginForm : Form
    {
        private string[,] userData;

        public LoginForm()
        {
            InitializeComponent();

            // Load user data from text file
            string[] lines = File.ReadAllLines("userData.txt");
            userData = new string[lines.Length, 4];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');
                for (int j = 0; j < 4; j++)
                {
                    userData[i, j] = fields[j];
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if user exists and password matches
            string username = txtUsername.Text;
            string password = txtPassowrd.Text;
            bool foundUser = false;
            for (int i = 0; i < userData.GetLength(0); i++)
            {
                if (userData[i, 0] == username)
                {
                    foundUser = true;
                    if (userData[i, 2] == password)
                    {
                        MessageBox.Show("Login successful!");
                        // Open drink selection form
                        DrinkSelectionForm selectionForm = new DrinkSelectionForm(userData[i, 1]);
                        selectionForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password.");
                    }
                    break;
                }
            }
            if (!foundUser)
            {
                MessageBox.Show("User not found.");
            }
        }
    }
}