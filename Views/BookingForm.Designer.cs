namespace Inlamning2DatabasTeknik.Views
{
    partial class BookingForm
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
            this.dataGridViewAvailableRooms = new System.Windows.Forms.DataGridView();
            this.buttonCheckAvailability = new System.Windows.Forms.Button();
            this.dateTimePickerArrival = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBook = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonChooseCustomer = new System.Windows.Forms.Button();
            this.buttonSeeBookings = new System.Windows.Forms.Button();
            this.buttonSelectedCustomerBookings = new System.Windows.Forms.Button();
            this.buttonRemoveBooking = new System.Windows.Forms.Button();
            this.buttonUpdateBooking = new System.Windows.Forms.Button();
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.buttonClearSelection = new System.Windows.Forms.Button();
            this.comboBoxPeople = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAvailableRooms
            // 
            this.dataGridViewAvailableRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAvailableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableRooms.Location = new System.Drawing.Point(48, 235);
            this.dataGridViewAvailableRooms.MultiSelect = false;
            this.dataGridViewAvailableRooms.Name = "dataGridViewAvailableRooms";
            this.dataGridViewAvailableRooms.ReadOnly = true;
            this.dataGridViewAvailableRooms.RowHeadersWidth = 82;
            this.dataGridViewAvailableRooms.RowTemplate.Height = 33;
            this.dataGridViewAvailableRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAvailableRooms.Size = new System.Drawing.Size(848, 416);
            this.dataGridViewAvailableRooms.TabIndex = 0;
            // 
            // buttonCheckAvailability
            // 
            this.buttonCheckAvailability.Location = new System.Drawing.Point(570, 681);
            this.buttonCheckAvailability.Name = "buttonCheckAvailability";
            this.buttonCheckAvailability.Size = new System.Drawing.Size(184, 69);
            this.buttonCheckAvailability.TabIndex = 1;
            this.buttonCheckAvailability.Text = "Kolla tillgängliga rum";
            this.buttonCheckAvailability.UseVisualStyleBackColor = true;
            this.buttonCheckAvailability.Click += new System.EventHandler(this.buttonCheckAvailability_Click);
            // 
            // dateTimePickerArrival
            // 
            this.dateTimePickerArrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerArrival.Location = new System.Drawing.Point(696, 102);
            this.dateTimePickerArrival.Name = "dateTimePickerArrival";
            this.dateTimePickerArrival.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerArrival.TabIndex = 2;
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(696, 173);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerDeparture.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Incheckningsdag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Utcheckningsdag";
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(786, 681);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(110, 49);
            this.buttonBook.TabIndex = 6;
            this.buttonBook.Text = "Boka";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Förnamn";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(48, 73);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.ReadOnly = true;
            this.textBoxFirstname.Size = new System.Drawing.Size(172, 31);
            this.textBoxFirstname.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(48, 162);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(172, 31);
            this.textBoxEmail.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(297, 73);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.ReadOnly = true;
            this.textBoxLastname.Size = new System.Drawing.Size(172, 31);
            this.textBoxLastname.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Efternamn";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(297, 162);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(172, 31);
            this.textBoxPhone.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefonnummer";
            // 
            // buttonChooseCustomer
            // 
            this.buttonChooseCustomer.Location = new System.Drawing.Point(505, 115);
            this.buttonChooseCustomer.Name = "buttonChooseCustomer";
            this.buttonChooseCustomer.Size = new System.Drawing.Size(148, 78);
            this.buttonChooseCustomer.TabIndex = 15;
            this.buttonChooseCustomer.Text = "Välj kund för bokning";
            this.buttonChooseCustomer.UseVisualStyleBackColor = true;
            this.buttonChooseCustomer.Click += new System.EventHandler(this.buttonChooseCustomer_Click);
            // 
            // buttonSeeBookings
            // 
            this.buttonSeeBookings.Location = new System.Drawing.Point(1591, 684);
            this.buttonSeeBookings.Name = "buttonSeeBookings";
            this.buttonSeeBookings.Size = new System.Drawing.Size(167, 64);
            this.buttonSeeBookings.TabIndex = 16;
            this.buttonSeeBookings.Text = "Se alla bokningar";
            this.buttonSeeBookings.UseVisualStyleBackColor = true;
            this.buttonSeeBookings.Click += new System.EventHandler(this.buttonSeeBookings_Click);
            // 
            // buttonSelectedCustomerBookings
            // 
            this.buttonSelectedCustomerBookings.Location = new System.Drawing.Point(505, 45);
            this.buttonSelectedCustomerBookings.Name = "buttonSelectedCustomerBookings";
            this.buttonSelectedCustomerBookings.Size = new System.Drawing.Size(148, 59);
            this.buttonSelectedCustomerBookings.TabIndex = 17;
            this.buttonSelectedCustomerBookings.Text = "Se kundens bokningar";
            this.buttonSelectedCustomerBookings.UseVisualStyleBackColor = true;
            this.buttonSelectedCustomerBookings.Click += new System.EventHandler(this.buttonSelectedCustomerBookings_Click);
            // 
            // buttonRemoveBooking
            // 
            this.buttonRemoveBooking.Location = new System.Drawing.Point(1186, 684);
            this.buttonRemoveBooking.Name = "buttonRemoveBooking";
            this.buttonRemoveBooking.Size = new System.Drawing.Size(167, 62);
            this.buttonRemoveBooking.TabIndex = 18;
            this.buttonRemoveBooking.Text = "Ta bort vald bokning";
            this.buttonRemoveBooking.UseVisualStyleBackColor = true;
            this.buttonRemoveBooking.Click += new System.EventHandler(this.buttonRemoveBooking_Click);
            // 
            // buttonUpdateBooking
            // 
            this.buttonUpdateBooking.Location = new System.Drawing.Point(1381, 682);
            this.buttonUpdateBooking.Name = "buttonUpdateBooking";
            this.buttonUpdateBooking.Size = new System.Drawing.Size(167, 62);
            this.buttonUpdateBooking.TabIndex = 19;
            this.buttonUpdateBooking.Text = "Uppdatera vald bokning";
            this.buttonUpdateBooking.UseVisualStyleBackColor = true;
            this.buttonUpdateBooking.Click += new System.EventHandler(this.buttonUpdateBooking_Click);
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Location = new System.Drawing.Point(945, 235);
            this.dataGridViewBookings.MultiSelect = false;
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.ReadOnly = true;
            this.dataGridViewBookings.RowHeadersWidth = 82;
            this.dataGridViewBookings.RowTemplate.Height = 33;
            this.dataGridViewBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookings.Size = new System.Drawing.Size(811, 416);
            this.dataGridViewBookings.TabIndex = 20;
            // 
            // buttonClearSelection
            // 
            this.buttonClearSelection.Location = new System.Drawing.Point(48, 681);
            this.buttonClearSelection.Name = "buttonClearSelection";
            this.buttonClearSelection.Size = new System.Drawing.Size(123, 56);
            this.buttonClearSelection.TabIndex = 21;
            this.buttonClearSelection.Text = "Avmarkera rum";
            this.buttonClearSelection.UseVisualStyleBackColor = true;
            this.buttonClearSelection.Click += new System.EventHandler(this.buttonClearSelection_Click);
            // 
            // comboBoxPeople
            // 
            this.comboBoxPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPeople.FormattingEnabled = true;
            this.comboBoxPeople.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxPeople.Location = new System.Drawing.Point(923, 171);
            this.comboBoxPeople.Name = "comboBoxPeople";
            this.comboBoxPeople.Size = new System.Drawing.Size(121, 33);
            this.comboBoxPeople.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(918, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Antal personer";
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(1622, 149);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(136, 57);
            this.buttonMainMenu.TabIndex = 24;
            this.buttonMainMenu.Text = "Huvudmeny";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1820, 823);
            this.Controls.Add(this.buttonMainMenu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxPeople);
            this.Controls.Add(this.buttonClearSelection);
            this.Controls.Add(this.dataGridViewBookings);
            this.Controls.Add(this.buttonUpdateBooking);
            this.Controls.Add(this.buttonRemoveBooking);
            this.Controls.Add(this.buttonSelectedCustomerBookings);
            this.Controls.Add(this.buttonSeeBookings);
            this.Controls.Add(this.buttonChooseCustomer);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFirstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDeparture);
            this.Controls.Add(this.dateTimePickerArrival);
            this.Controls.Add(this.buttonCheckAvailability);
            this.Controls.Add(this.dataGridViewAvailableRooms);
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAvailableRooms;
        private System.Windows.Forms.Button buttonCheckAvailability;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrival;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonChooseCustomer;
        private System.Windows.Forms.Button buttonSeeBookings;
        private System.Windows.Forms.Button buttonSelectedCustomerBookings;
        private System.Windows.Forms.Button buttonRemoveBooking;
        private System.Windows.Forms.Button buttonUpdateBooking;
        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.Button buttonClearSelection;
        private System.Windows.Forms.ComboBox comboBoxPeople;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonMainMenu;
    }
}