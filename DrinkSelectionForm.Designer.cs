
using System;

namespace ISDS309_FinalProject_Vending
{
    partial class DrinkSelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.lstDrinks = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.lstSelectedDrinks = new System.Windows.Forms.ListBox();
			this.btnCheckout = new System.Windows.Forms.Button();
			this.lblDrinks = new System.Windows.Forms.Label();
			this.lblSelectedDrinks = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
			this.lblInventory = new System.Windows.Forms.Label();
			this.lblTotalCost = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lstDrinks
			// 
			this.lstDrinks.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lstDrinks.FormattingEnabled = true;
			this.lstDrinks.ItemHeight = 15;
			this.lstDrinks.Location = new System.Drawing.Point(12, 40);
			this.lstDrinks.Name = "lstDrinks";
			this.lstDrinks.Size = new System.Drawing.Size(379, 94);
			this.lstDrinks.TabIndex = 0;
			this.lstDrinks.SelectedIndexChanged += new System.EventHandler(this.lstDrinks_SelectedIndexChanged);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAdd.Location = new System.Drawing.Point(316, 140);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnRemove.Location = new System.Drawing.Point(316, 317);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 2;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// lstSelectedDrinks
			// 
			this.lstSelectedDrinks.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lstSelectedDrinks.FormattingEnabled = true;
			this.lstSelectedDrinks.ItemHeight = 15;
			this.lstSelectedDrinks.Location = new System.Drawing.Point(12, 217);
			this.lstSelectedDrinks.Name = "lstSelectedDrinks";
			this.lstSelectedDrinks.Size = new System.Drawing.Size(379, 94);
			this.lstSelectedDrinks.TabIndex = 3;
			// 
			// btnCheckout
			// 
			this.btnCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCheckout.Location = new System.Drawing.Point(316, 346);
			this.btnCheckout.Name = "btnCheckout";
			this.btnCheckout.Size = new System.Drawing.Size(75, 23);
			this.btnCheckout.TabIndex = 4;
			this.btnCheckout.Text = "Checkout";
			this.btnCheckout.UseVisualStyleBackColor = true;
			this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
			// 
			// lblDrinks
			// 
			this.lblDrinks.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblDrinks.AutoSize = true;
			this.lblDrinks.Location = new System.Drawing.Point(12, 22);
			this.lblDrinks.Name = "lblDrinks";
			this.lblDrinks.Size = new System.Drawing.Size(40, 15);
			this.lblDrinks.TabIndex = 5;
			this.lblDrinks.Text = "Drinks";
			// 
			// lblSelectedDrinks
			// 
			this.lblSelectedDrinks.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblSelectedDrinks.AutoSize = true;
			this.lblSelectedDrinks.Location = new System.Drawing.Point(12, 199);
			this.lblSelectedDrinks.Name = "lblSelectedDrinks";
			this.lblSelectedDrinks.Size = new System.Drawing.Size(87, 15);
			this.lblSelectedDrinks.TabIndex = 6;
			this.lblSelectedDrinks.Text = "Drinks Selected";
			// 
			// lblPrice
			// 
			this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPrice.AutoSize = true;
			this.lblPrice.Location = new System.Drawing.Point(12, 154);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(42, 15);
			this.lblPrice.TabIndex = 7;
			this.lblPrice.Text = "Price : ";
			// 
			// lblInventory
			// 
			this.lblInventory.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblInventory.AutoSize = true;
			this.lblInventory.Location = new System.Drawing.Point(12, 137);
			this.lblInventory.Name = "lblInventory";
			this.lblInventory.Size = new System.Drawing.Size(66, 15);
			this.lblInventory.TabIndex = 8;
			this.lblInventory.Text = "Inventory : ";
			// 
			// lblTotalCost
			// 
			this.lblTotalCost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTotalCost.AutoSize = true;
			this.lblTotalCost.Location = new System.Drawing.Point(12, 314);
			this.lblTotalCost.Name = "lblTotalCost";
			this.lblTotalCost.Size = new System.Drawing.Size(41, 15);
			this.lblTotalCost.TabIndex = 9;
			this.lblTotalCost.Text = "Total : ";
			// 
			// DrinkSelectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 386);
			this.Controls.Add(this.lblTotalCost);
			this.Controls.Add(this.lblInventory);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.lblSelectedDrinks);
			this.Controls.Add(this.lblDrinks);
			this.Controls.Add(this.btnCheckout);
			this.Controls.Add(this.lstSelectedDrinks);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lstDrinks);
			this.Name = "DrinkSelectionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DrinkSelectionForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDrinks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstSelectedDrinks;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.Label lblSelectedDrinks;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblTotalCost;
    }
}