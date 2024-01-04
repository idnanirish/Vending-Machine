
using System;

namespace ISDS309_FinalProject_Vending
{
    partial class CheckoutForm
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
			this.lblSelectedDrinks = new System.Windows.Forms.Label();
			this.lblTotalCost = new System.Windows.Forms.Label();
			this.lblCardNumber = new System.Windows.Forms.Label();
			this.lblCVV = new System.Windows.Forms.Label();
			this.lblExpiration = new System.Windows.Forms.Label();
			this.lstSelectedDrinks = new System.Windows.Forms.ListBox();
			this.txtCardNumber = new System.Windows.Forms.TextBox();
			this.txtCVV = new System.Windows.Forms.TextBox();
			this.txtExpiration = new System.Windows.Forms.TextBox();
			this.btnPurchase = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblSelectedDrinks
			// 
			this.lblSelectedDrinks.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblSelectedDrinks.AutoSize = true;
			this.lblSelectedDrinks.Location = new System.Drawing.Point(27, 24);
			this.lblSelectedDrinks.Name = "lblSelectedDrinks";
			this.lblSelectedDrinks.Size = new System.Drawing.Size(87, 15);
			this.lblSelectedDrinks.TabIndex = 0;
			this.lblSelectedDrinks.Text = "Selected Drinks";
			// 
			// lblTotalCost
			// 
			this.lblTotalCost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTotalCost.AutoSize = true;
			this.lblTotalCost.Location = new System.Drawing.Point(27, 139);
			this.lblTotalCost.Name = "lblTotalCost";
			this.lblTotalCost.Size = new System.Drawing.Size(68, 15);
			this.lblTotalCost.TabIndex = 1;
			this.lblTotalCost.Text = "Total Cost : ";
			// 
			// lblCardNumber
			// 
			this.lblCardNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCardNumber.AutoSize = true;
			this.lblCardNumber.Location = new System.Drawing.Point(137, 199);
			this.lblCardNumber.Name = "lblCardNumber";
			this.lblCardNumber.Size = new System.Drawing.Size(79, 15);
			this.lblCardNumber.TabIndex = 2;
			this.lblCardNumber.Text = "Card Number";
			// 
			// lblCVV
			// 
			this.lblCVV.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCVV.AutoSize = true;
			this.lblCVV.Location = new System.Drawing.Point(137, 251);
			this.lblCVV.Name = "lblCVV";
			this.lblCVV.Size = new System.Drawing.Size(29, 15);
			this.lblCVV.TabIndex = 3;
			this.lblCVV.Text = "CVV";
			// 
			// lblExpiration
			// 
			this.lblExpiration.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblExpiration.AutoSize = true;
			this.lblExpiration.Location = new System.Drawing.Point(203, 251);
			this.lblExpiration.Name = "lblExpiration";
			this.lblExpiration.Size = new System.Drawing.Size(60, 15);
			this.lblExpiration.TabIndex = 4;
			this.lblExpiration.Text = "Expiration";
			// 
			// lstSelectedDrinks
			// 
			this.lstSelectedDrinks.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lstSelectedDrinks.FormattingEnabled = true;
			this.lstSelectedDrinks.ItemHeight = 15;
			this.lstSelectedDrinks.Location = new System.Drawing.Point(27, 42);
			this.lstSelectedDrinks.Name = "lstSelectedDrinks";
			this.lstSelectedDrinks.Size = new System.Drawing.Size(391, 94);
			this.lstSelectedDrinks.TabIndex = 5;
			// 
			// txtCardNumber
			// 
			this.txtCardNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCardNumber.Location = new System.Drawing.Point(137, 217);
			this.txtCardNumber.Name = "txtCardNumber";
			this.txtCardNumber.Size = new System.Drawing.Size(179, 23);
			this.txtCardNumber.TabIndex = 0;
			// 
			// txtCVV
			// 
			this.txtCVV.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCVV.Location = new System.Drawing.Point(137, 269);
			this.txtCVV.Name = "txtCVV";
			this.txtCVV.Size = new System.Drawing.Size(60, 23);
			this.txtCVV.TabIndex = 1;
			// 
			// txtExpiration
			// 
			this.txtExpiration.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtExpiration.Location = new System.Drawing.Point(203, 269);
			this.txtExpiration.Name = "txtExpiration";
			this.txtExpiration.Size = new System.Drawing.Size(113, 23);
			this.txtExpiration.TabIndex = 2;
			// 
			// btnPurchase
			// 
			this.btnPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnPurchase.Location = new System.Drawing.Point(343, 351);
			this.btnPurchase.Name = "btnPurchase";
			this.btnPurchase.Size = new System.Drawing.Size(75, 23);
			this.btnPurchase.TabIndex = 3;
			this.btnPurchase.Text = "Purchase";
			this.btnPurchase.UseVisualStyleBackColor = true;
			this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
			// 
			// CheckoutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 386);
			this.Controls.Add(this.btnPurchase);
			this.Controls.Add(this.txtExpiration);
			this.Controls.Add(this.txtCVV);
			this.Controls.Add(this.txtCardNumber);
			this.Controls.Add(this.lstSelectedDrinks);
			this.Controls.Add(this.lblExpiration);
			this.Controls.Add(this.lblCVV);
			this.Controls.Add(this.lblCardNumber);
			this.Controls.Add(this.lblTotalCost);
			this.Controls.Add(this.lblSelectedDrinks);
			this.Name = "CheckoutForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "checkoutFrom";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectedDrinks;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.ListBox lstSelectedDrinks;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtExpiration;
        private System.Windows.Forms.Button btnPurchase;

    }
}