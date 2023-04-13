namespace Inlamning2DatabasTeknik.Views
{
    partial class HotelForm
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
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.buttonBookings = new System.Windows.Forms.Button();
            this.buttonInvoices = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.Location = new System.Drawing.Point(57, 165);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(123, 69);
            this.buttonCustomers.TabIndex = 0;
            this.buttonCustomers.Text = "Hantera kunder";
            this.buttonCustomers.UseVisualStyleBackColor = true;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // buttonBookings
            // 
            this.buttonBookings.Location = new System.Drawing.Point(238, 165);
            this.buttonBookings.Name = "buttonBookings";
            this.buttonBookings.Size = new System.Drawing.Size(119, 69);
            this.buttonBookings.TabIndex = 1;
            this.buttonBookings.Text = "Hantera bokningar";
            this.buttonBookings.UseVisualStyleBackColor = true;
            this.buttonBookings.Click += new System.EventHandler(this.buttonBookings_Click);
            // 
            // buttonInvoices
            // 
            this.buttonInvoices.Location = new System.Drawing.Point(425, 165);
            this.buttonInvoices.Name = "buttonInvoices";
            this.buttonInvoices.Size = new System.Drawing.Size(118, 69);
            this.buttonInvoices.TabIndex = 2;
            this.buttonInvoices.Text = "Hantera fakturor";
            this.buttonInvoices.UseVisualStyleBackColor = true;
            this.buttonInvoices.Click += new System.EventHandler(this.buttonInvoices_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hotell Applikationen";
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInvoices);
            this.Controls.Add(this.buttonBookings);
            this.Controls.Add(this.buttonCustomers);
            this.Name = "HotelForm";
            this.Text = "HotelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.Button buttonBookings;
        private System.Windows.Forms.Button buttonInvoices;
        private System.Windows.Forms.Label label1;
    }
}