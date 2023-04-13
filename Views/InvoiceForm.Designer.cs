namespace Inlamning2DatabasTeknik.Views
{
    partial class InvoiceForm
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
            this.dataGridViewInvoices = new System.Windows.Forms.DataGridView();
            this.buttonSeeAllInvoices = new System.Windows.Forms.Button();
            this.buttonSeeCustomerInvoices = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonChooseCustomer = new System.Windows.Forms.Button();
            this.buttonRegisterPay = new System.Windows.Forms.Button();
            this.buttonRemoveInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInvoices
            // 
            this.dataGridViewInvoices.AllowUserToOrderColumns = true;
            this.dataGridViewInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoices.Location = new System.Drawing.Point(43, 269);
            this.dataGridViewInvoices.MultiSelect = false;
            this.dataGridViewInvoices.Name = "dataGridViewInvoices";
            this.dataGridViewInvoices.ReadOnly = true;
            this.dataGridViewInvoices.RowHeadersWidth = 82;
            this.dataGridViewInvoices.RowTemplate.Height = 33;
            this.dataGridViewInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInvoices.Size = new System.Drawing.Size(1134, 493);
            this.dataGridViewInvoices.TabIndex = 0;
            // 
            // buttonSeeAllInvoices
            // 
            this.buttonSeeAllInvoices.Location = new System.Drawing.Point(1046, 133);
            this.buttonSeeAllInvoices.Name = "buttonSeeAllInvoices";
            this.buttonSeeAllInvoices.Size = new System.Drawing.Size(131, 69);
            this.buttonSeeAllInvoices.TabIndex = 1;
            this.buttonSeeAllInvoices.Text = "Alla fakturor";
            this.buttonSeeAllInvoices.UseVisualStyleBackColor = true;
            this.buttonSeeAllInvoices.Click += new System.EventHandler(this.buttonSeeAllInvoices_Click);
            // 
            // buttonSeeCustomerInvoices
            // 
            this.buttonSeeCustomerInvoices.Location = new System.Drawing.Point(496, 68);
            this.buttonSeeCustomerInvoices.Name = "buttonSeeCustomerInvoices";
            this.buttonSeeCustomerInvoices.Size = new System.Drawing.Size(148, 59);
            this.buttonSeeCustomerInvoices.TabIndex = 27;
            this.buttonSeeCustomerInvoices.Text = "Se kundens fakturor";
            this.buttonSeeCustomerInvoices.UseVisualStyleBackColor = true;
            this.buttonSeeCustomerInvoices.Click += new System.EventHandler(this.buttonSeeCustomerInvoices_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(292, 171);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(172, 31);
            this.textBoxPhone.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Telefonnummer";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(292, 82);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.ReadOnly = true;
            this.textBoxLastname.Size = new System.Drawing.Size(172, 31);
            this.textBoxLastname.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Efternamn";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(43, 171);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(172, 31);
            this.textBoxEmail.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(43, 82);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.ReadOnly = true;
            this.textBoxFirstname.Size = new System.Drawing.Size(172, 31);
            this.textBoxFirstname.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Förnamn";
            // 
            // buttonChooseCustomer
            // 
            this.buttonChooseCustomer.Location = new System.Drawing.Point(496, 143);
            this.buttonChooseCustomer.Name = "buttonChooseCustomer";
            this.buttonChooseCustomer.Size = new System.Drawing.Size(148, 59);
            this.buttonChooseCustomer.TabIndex = 28;
            this.buttonChooseCustomer.Text = "Välj kund";
            this.buttonChooseCustomer.UseVisualStyleBackColor = true;
            this.buttonChooseCustomer.Click += new System.EventHandler(this.buttonChooseCustomer_Click);
            // 
            // buttonRegisterPay
            // 
            this.buttonRegisterPay.Location = new System.Drawing.Point(877, 133);
            this.buttonRegisterPay.Name = "buttonRegisterPay";
            this.buttonRegisterPay.Size = new System.Drawing.Size(131, 69);
            this.buttonRegisterPay.TabIndex = 29;
            this.buttonRegisterPay.Text = "Registrera betalning";
            this.buttonRegisterPay.UseVisualStyleBackColor = true;
            this.buttonRegisterPay.Click += new System.EventHandler(this.buttonRegisterPay_Click);
            // 
            // buttonRemoveInvoice
            // 
            this.buttonRemoveInvoice.Location = new System.Drawing.Point(703, 133);
            this.buttonRemoveInvoice.Name = "buttonRemoveInvoice";
            this.buttonRemoveInvoice.Size = new System.Drawing.Size(131, 69);
            this.buttonRemoveInvoice.TabIndex = 30;
            this.buttonRemoveInvoice.Text = "Ta bort faktura";
            this.buttonRemoveInvoice.UseVisualStyleBackColor = true;
            this.buttonRemoveInvoice.Click += new System.EventHandler(this.buttonRemoveInvoice_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 812);
            this.Controls.Add(this.buttonRemoveInvoice);
            this.Controls.Add(this.buttonRegisterPay);
            this.Controls.Add(this.buttonChooseCustomer);
            this.Controls.Add(this.buttonSeeCustomerInvoices);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFirstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSeeAllInvoices);
            this.Controls.Add(this.dataGridViewInvoices);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInvoices;
        private System.Windows.Forms.Button buttonSeeAllInvoices;
        private System.Windows.Forms.Button buttonSeeCustomerInvoices;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonChooseCustomer;
        private System.Windows.Forms.Button buttonRegisterPay;
        private System.Windows.Forms.Button buttonRemoveInvoice;
    }
}