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
            this.BtnFilterByDate = new System.Windows.Forms.Button();
            this.LblFrom = new System.Windows.Forms.Label();
            this.LblTo = new System.Windows.Forms.Label();
            this.ListBoxCustomerInfo = new System.Windows.Forms.ListBox();
            this.BtnCheckRecordOrBack = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LblCustomerNames
            // 
            this.LblCustomerNames.AutoSize = true;
            this.LblCustomerNames.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCustomerNames.Location = new System.Drawing.Point(61, 9);
            this.LblCustomerNames.Name = "LblCustomerNames";
            this.LblCustomerNames.Size = new System.Drawing.Size(517, 29);
            this.LblCustomerNames.TabIndex = 0;
            this.LblCustomerNames.Text = "Customer Information for Contact Tracing";
            // 
            // BtnFilterByDate
            // 
            this.BtnFilterByDate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFilterByDate.Location = new System.Drawing.Point(42, 90);
            this.BtnFilterByDate.Name = "BtnFilterByDate";
            this.BtnFilterByDate.Size = new System.Drawing.Size(137, 34);
            this.BtnFilterByDate.TabIndex = 4;
            this.BtnFilterByDate.Text = "Filter By Date";
            this.BtnFilterByDate.UseVisualStyleBackColor = true;
            this.BtnFilterByDate.Click += new System.EventHandler(this.BtnFilterByDate_Click);
            // 
            // LblFrom
            // 
            this.LblFrom.AutoSize = true;
            this.LblFrom.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFrom.Location = new System.Drawing.Point(210, 73);
            this.LblFrom.Name = "LblFrom";
            this.LblFrom.Size = new System.Drawing.Size(74, 25);
            this.LblFrom.TabIndex = 53;
            this.LblFrom.Text = "From:";
            // 
            // LblTo
            // 
            this.LblTo.AutoSize = true;
            this.LblTo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTo.Location = new System.Drawing.Point(419, 73);
            this.LblTo.Name = "LblTo";
            this.LblTo.Size = new System.Drawing.Size(46, 25);
            this.LblTo.TabIndex = 56;
            this.LblTo.Text = "To:";
            // 
            // ListBoxCustomerInfo
            // 
            this.ListBoxCustomerInfo.FormattingEnabled = true;
            this.ListBoxCustomerInfo.HorizontalScrollbar = true;
            this.ListBoxCustomerInfo.ItemHeight = 15;
            this.ListBoxCustomerInfo.Location = new System.Drawing.Point(45, 140);
            this.ListBoxCustomerInfo.Name = "ListBoxCustomerInfo";
            this.ListBoxCustomerInfo.Size = new System.Drawing.Size(572, 154);
            this.ListBoxCustomerInfo.TabIndex = 57;
            // 
            // BtnCheckRecordOrBack
            // 
            this.BtnCheckRecordOrBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCheckRecordOrBack.Location = new System.Drawing.Point(284, 311);
            this.BtnCheckRecordOrBack.Name = "BtnCheckRecordOrBack";
            this.BtnCheckRecordOrBack.Size = new System.Drawing.Size(113, 26);
            this.BtnCheckRecordOrBack.TabIndex = 58;
            this.BtnCheckRecordOrBack.Text = "Check Record";
            this.BtnCheckRecordOrBack.UseVisualStyleBackColor = true;
            this.BtnCheckRecordOrBack.Click += new System.EventHandler(this.BtnCheckRecordOrBack_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(210, 107);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(95, 27);
            this.dateTimePicker2.TabIndex = 60;
            // 
            // ContactTracingInfoDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(644, 349);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.BtnCheckRecordOrBack);
            this.Controls.Add(this.ListBoxCustomerInfo);
            this.Controls.Add(this.LblTo);
            this.Controls.Add(this.LblFrom);
            this.Controls.Add(this.BtnFilterByDate);
            this.Controls.Add(this.LblCustomerNames);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactTracingInfoDatabaseForm";
            this.Text = "Contact Tracing Information Database";
            this.Load += new System.EventHandler(this.ContactTracingInfoDatabaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblCustomerNames;
        private Button BtnFilterByDate;
        private PictureBox PicBoxFilterIcon;
        private Button BtnDayVisited;
        private Label LblForwardSlash1;
        private TextBox TxtBoxYearVisited;
        private Label LblForwardSlash2;
        private Button BtnMonthVisited;
        private Label LblFrom;
        private Label LblTo;
        private ListBox ListBoxCustomerInfo;
        private Button BtnCheckRecordOrBack;
        private DateTimePicker dateTimePicker2;
    }
}