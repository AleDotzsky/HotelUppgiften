namespace Inlamning2DatabasTeknik.Views
{
    partial class CustomerInvoiceForm
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.dataGridViewChoose = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChoose)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(392, 43);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(125, 51);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Sök namn";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(57, 53);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(275, 31);
            this.textBoxSearch.TabIndex = 6;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(792, 43);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(125, 51);
            this.buttonChoose.TabIndex = 5;
            this.buttonChoose.Text = "Välj kund";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // dataGridViewChoose
            // 
            this.dataGridViewChoose.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChoose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChoose.Location = new System.Drawing.Point(57, 118);
            this.dataGridViewChoose.MultiSelect = false;
            this.dataGridViewChoose.Name = "dataGridViewChoose";
            this.dataGridViewChoose.ReadOnly = true;
            this.dataGridViewChoose.RowHeadersWidth = 82;
            this.dataGridViewChoose.RowTemplate.Height = 33;
            this.dataGridViewChoose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChoose.Size = new System.Drawing.Size(860, 532);
            this.dataGridViewChoose.TabIndex = 4;
            // 
            // CustomerInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 702);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.dataGridViewChoose);
            this.Name = "CustomerInvoiceForm";
            this.Text = "CustomerInvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChoose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.DataGridView dataGridViewChoose;
    }
}