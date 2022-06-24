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
            this.BtnCheckRecordOrBack = new System.Windows.Forms.Button();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.ListBoxCustomerInformation = new System.Windows.Forms.ListBox();
            this.LblFrom = new System.Windows.Forms.Label();
            this.DTPFromDate = new System.Windows.Forms.DateTimePicker();
            this.DTPToDate = new System.Windows.Forms.DateTimePicker();
            this.LblTo = new System.Windows.Forms.Label();
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
            // BtnCheckRecordOrBack
            // 
            this.BtnCheckRecordOrBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCheckRecordOrBack.Location = new System.Drawing.Point(283, 406);
            this.BtnCheckRecordOrBack.Name = "BtnCheckRecordOrBack";
            this.BtnCheckRecordOrBack.Size = new System.Drawing.Size(109, 32);
            this.BtnCheckRecordOrBack.TabIndex = 2;
            this.BtnCheckRecordOrBack.Text = "Check Record";
            this.BtnCheckRecordOrBack.UseVisualStyleBackColor = true;
            this.BtnCheckRecordOrBack.Click += new System.EventHandler(this.BtnCheckRecord_Click);
            // 
            // BtnFilter
            // 
            this.BtnFilter.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFilter.Location = new System.Drawing.Point(61, 145);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(75, 33);
            this.BtnFilter.TabIndex = 4;
            this.BtnFilter.Text = "Filter";
            this.BtnFilter.UseVisualStyleBackColor = true;
            // 
            // ListBoxCustomerInformation
            // 
            this.ListBoxCustomerInformation.ColumnWidth = 200;
            this.ListBoxCustomerInformation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxCustomerInformation.FormattingEnabled = true;
            this.ListBoxCustomerInformation.HorizontalScrollbar = true;
            this.ListBoxCustomerInformation.ItemHeight = 18;
            this.ListBoxCustomerInformation.Location = new System.Drawing.Point(37, 184);
            this.ListBoxCustomerInformation.MultiColumn = true;
            this.ListBoxCustomerInformation.Name = "ListBoxCustomerInformation";
            this.ListBoxCustomerInformation.Size = new System.Drawing.Size(575, 184);
            this.ListBoxCustomerInformation.TabIndex = 1;
            // 
            // LblFrom
            // 
            this.LblFrom.AutoSize = true;
            this.LblFrom.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFrom.Location = new System.Drawing.Point(164, 127);
            this.LblFrom.Name = "LblFrom";
            this.LblFrom.Size = new System.Drawing.Size(74, 25);
            this.LblFrom.TabIndex = 53;
            this.LblFrom.Text = "From:";
            // 
            // DTPFromDate
            // 
            this.DTPFromDate.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DTPFromDate.CustomFormat = "";
            this.DTPFromDate.Location = new System.Drawing.Point(164, 155);
            this.DTPFromDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.DTPFromDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DTPFromDate.Name = "DTPFromDate";
            this.DTPFromDate.Size = new System.Drawing.Size(116, 23);
            this.DTPFromDate.TabIndex = 54;
            // 
            // DTPToDate
            // 
            this.DTPToDate.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DTPToDate.Location = new System.Drawing.Point(305, 155);
            this.DTPToDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.DTPToDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DTPToDate.Name = "DTPToDate";
            this.DTPToDate.Size = new System.Drawing.Size(116, 23);
            this.DTPToDate.TabIndex = 55;
            this.DTPToDate.Value = new System.DateTime(2022, 6, 25, 0, 0, 0, 0);
            // 
            // LblTo
            // 
            this.LblTo.AutoSize = true;
            this.LblTo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTo.Location = new System.Drawing.Point(305, 127);
            this.LblTo.Name = "LblTo";
            this.LblTo.Size = new System.Drawing.Size(46, 25);
            this.LblTo.TabIndex = 56;
            this.LblTo.Text = "To:";
            // 
            // ContactTracingInfoDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.LblTo);
            this.Controls.Add(this.DTPToDate);
            this.Controls.Add(this.DTPFromDate);
            this.Controls.Add(this.LblFrom);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.BtnCheckRecordOrBack);
            this.Controls.Add(this.ListBoxCustomerInformation);
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
        private Button BtnCheckRecordOrBack;
        private Button BtnFilter;
        private PictureBox PicBoxFilterIcon;
        private ListBox ListBoxCustomerInformation;
        private Button BtnDayVisited;
        private Label LblForwardSlash1;
        private TextBox TxtBoxYearVisited;
        private Label LblForwardSlash2;
        private Button BtnMonthVisited;
        private Label LblFrom;
        private DateTimePicker DTPFromDate;
        private DateTimePicker DTPToDate;
        private Label LblTo;
    }
}