namespace ContactTracingApp
{
    partial class ContactTracingInfoDatabaseForm
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
            this.LblCustomerNames = new System.Windows.Forms.Label();
            this.ListBoxCustomerNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblCustomerNames
            // 
            this.LblCustomerNames.AutoSize = true;
            this.LblCustomerNames.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCustomerNames.Location = new System.Drawing.Point(25, 21);
            this.LblCustomerNames.Name = "LblCustomerNames";
            this.LblCustomerNames.Size = new System.Drawing.Size(296, 33);
            this.LblCustomerNames.TabIndex = 0;
            this.LblCustomerNames.Text = "Names of Customers";
            // 
            // ListBoxCustomerNames
            // 
            this.ListBoxCustomerNames.FormattingEnabled = true;
            this.ListBoxCustomerNames.ItemHeight = 15;
            this.ListBoxCustomerNames.Location = new System.Drawing.Point(22, 98);
            this.ListBoxCustomerNames.Name = "ListBoxCustomerNames";
            this.ListBoxCustomerNames.Size = new System.Drawing.Size(299, 214);
            this.ListBoxCustomerNames.TabIndex = 1;
            // 
            // ContactTracingInfoDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 341);
            this.Controls.Add(this.ListBoxCustomerNames);
            this.Controls.Add(this.LblCustomerNames);
            this.Name = "ContactTracingInfoDatabaseForm";
            this.ShowIcon = false;
            this.Text = "Contact Tracing Information Database";
            this.Load += new System.EventHandler(this.ContactTracingInfoDatabaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblCustomerNames;
        private ListBox ListBoxCustomerNames;
        private ComboBox comboBox1;
    }
}