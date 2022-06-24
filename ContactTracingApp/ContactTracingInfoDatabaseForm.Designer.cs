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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactTracingInfoDatabaseForm));
            this.LblCustomerNames = new System.Windows.Forms.Label();
            this.ListBoxCustomerInformation = new System.Windows.Forms.ListBox();
            this.BtnCheckRecord = new System.Windows.Forms.Button();
            this.ComboBoxFilterOptions = new System.Windows.Forms.ComboBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.PicBoxFilterIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFilterIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCustomerNames
            // 
            this.LblCustomerNames.AutoSize = true;
            this.LblCustomerNames.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCustomerNames.Location = new System.Drawing.Point(28, 19);
            this.LblCustomerNames.Name = "LblCustomerNames";
            this.LblCustomerNames.Size = new System.Drawing.Size(454, 25);
            this.LblCustomerNames.TabIndex = 0;
            this.LblCustomerNames.Text = "Customer Information for Contact Tracing";
            // 
            // ListBoxCustomerInformation
            // 
            this.ListBoxCustomerInformation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxCustomerInformation.FormattingEnabled = true;
            this.ListBoxCustomerInformation.HorizontalScrollbar = true;
            this.ListBoxCustomerInformation.ItemHeight = 19;
            this.ListBoxCustomerInformation.Location = new System.Drawing.Point(98, 107);
            this.ListBoxCustomerInformation.Name = "ListBoxCustomerInformation";
            this.ListBoxCustomerInformation.Size = new System.Drawing.Size(299, 213);
            this.ListBoxCustomerInformation.TabIndex = 1;
            // 
            // BtnCheckRecord
            // 
            this.BtnCheckRecord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCheckRecord.Location = new System.Drawing.Point(191, 331);
            this.BtnCheckRecord.Name = "BtnCheckRecord";
            this.BtnCheckRecord.Size = new System.Drawing.Size(109, 32);
            this.BtnCheckRecord.TabIndex = 2;
            this.BtnCheckRecord.Text = "Check Record";
            this.BtnCheckRecord.UseVisualStyleBackColor = true;
            this.BtnCheckRecord.Click += new System.EventHandler(this.BtnCheckRecord_Click);
            // 
            // ComboBoxFilterOptions
            // 
            this.ComboBoxFilterOptions.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxFilterOptions.FormattingEnabled = true;
            this.ComboBoxFilterOptions.Location = new System.Drawing.Point(236, 68);
            this.ComboBoxFilterOptions.Name = "ComboBoxFilterOptions";
            this.ComboBoxFilterOptions.Size = new System.Drawing.Size(121, 26);
            this.ComboBoxFilterOptions.TabIndex = 3;
            // 
            // BtnFilter
            // 
            this.BtnFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFilter.Location = new System.Drawing.Point(150, 69);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(75, 23);
            this.BtnFilter.TabIndex = 4;
            this.BtnFilter.Text = "Filter";
            this.BtnFilter.UseVisualStyleBackColor = true;
            // 
            // PicBoxFilterIcon
            // 
            this.PicBoxFilterIcon.BackColor = System.Drawing.Color.IndianRed;
            this.PicBoxFilterIcon.Image = global::ContactTracingApp.Properties.Resources._790818ba992ec7bba4ef7dc317245cc41;
            this.PicBoxFilterIcon.InitialImage = null;
            this.PicBoxFilterIcon.Location = new System.Drawing.Point(101, 56);
            this.PicBoxFilterIcon.Name = "PicBoxFilterIcon";
            this.PicBoxFilterIcon.Size = new System.Drawing.Size(43, 45);
            this.PicBoxFilterIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxFilterIcon.TabIndex = 5;
            this.PicBoxFilterIcon.TabStop = false;
            // 
            // ContactTracingInfoDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(493, 375);
            this.Controls.Add(this.PicBoxFilterIcon);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.ComboBoxFilterOptions);
            this.Controls.Add(this.BtnCheckRecord);
            this.Controls.Add(this.ListBoxCustomerInformation);
            this.Controls.Add(this.LblCustomerNames);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactTracingInfoDatabaseForm";
            this.Text = "Contact Tracing Information Database";
            this.Load += new System.EventHandler(this.ContactTracingInfoDatabaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFilterIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblCustomerNames;
        private ListBox ListBoxCustomerInformation;
        private Button BtnCheckRecord;
        private ComboBox ComboBoxFilterOptions;
        private Button BtnFilter;
        private PictureBox PicBoxFilterIcon;
    }
}