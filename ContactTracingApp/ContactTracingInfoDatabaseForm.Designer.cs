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
            this.TxtBoxSearchOrFilterDate = new System.Windows.Forms.TextBox();
            this.ListBoxCustomerInfo = new System.Windows.Forms.ListBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.LblNoteOfFormatOfListBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblCustomerNames
            // 
            this.LblCustomerNames.AutoSize = true;
            this.LblCustomerNames.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCustomerNames.Location = new System.Drawing.Point(19, 25);
            this.LblCustomerNames.Name = "LblCustomerNames";
            this.LblCustomerNames.Size = new System.Drawing.Size(454, 25);
            this.LblCustomerNames.TabIndex = 0;
            this.LblCustomerNames.Text = "Customer Information for Contact Tracing";
            // 
            // BtnCheckRecordOrBack
            // 
            this.BtnCheckRecordOrBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCheckRecordOrBack.Location = new System.Drawing.Point(176, 299);
            this.BtnCheckRecordOrBack.Name = "BtnCheckRecordOrBack";
            this.BtnCheckRecordOrBack.Size = new System.Drawing.Size(113, 26);
            this.BtnCheckRecordOrBack.TabIndex = 58;
            this.BtnCheckRecordOrBack.Text = "Check Record";
            this.BtnCheckRecordOrBack.UseVisualStyleBackColor = true;
            this.BtnCheckRecordOrBack.Click += new System.EventHandler(this.BtnCheckRecordOrBack_Click);
            // 
            // TxtBoxSearchOrFilterDate
            // 
            this.TxtBoxSearchOrFilterDate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxSearchOrFilterDate.Location = new System.Drawing.Point(41, 64);
            this.TxtBoxSearchOrFilterDate.Name = "TxtBoxSearchOrFilterDate";
            this.TxtBoxSearchOrFilterDate.Size = new System.Drawing.Size(179, 31);
            this.TxtBoxSearchOrFilterDate.TabIndex = 59;
            this.TxtBoxSearchOrFilterDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxSearchOrFilterDate_KeyPress);
            // 
            // ListBoxCustomerInfo
            // 
            this.ListBoxCustomerInfo.FormattingEnabled = true;
            this.ListBoxCustomerInfo.HorizontalScrollbar = true;
            this.ListBoxCustomerInfo.ItemHeight = 15;
            this.ListBoxCustomerInfo.Location = new System.Drawing.Point(41, 111);
            this.ListBoxCustomerInfo.Name = "ListBoxCustomerInfo";
            this.ListBoxCustomerInfo.Size = new System.Drawing.Size(390, 154);
            this.ListBoxCustomerInfo.TabIndex = 57;
            // 
            // BtnFilter
            // 
            this.BtnFilter.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFilter.Location = new System.Drawing.Point(226, 67);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(75, 26);
            this.BtnFilter.TabIndex = 60;
            this.BtnFilter.Text = "Filter";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // LblNoteOfFormatOfListBox
            // 
            this.LblNoteOfFormatOfListBox.AutoSize = true;
            this.LblNoteOfFormatOfListBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNoteOfFormatOfListBox.Location = new System.Drawing.Point(31, 274);
            this.LblNoteOfFormatOfListBox.Name = "LblNoteOfFormatOfListBox";
            this.LblNoteOfFormatOfListBox.Size = new System.Drawing.Size(415, 19);
            this.LblNoteOfFormatOfListBox.TabIndex = 61;
            this.LblNoteOfFormatOfListBox.Text = "(Note: The format of the listbox is \"Name\" + \"Date Visited\")";
            // 
            // ContactTracingInfoDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(496, 343);
            this.Controls.Add(this.LblNoteOfFormatOfListBox);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.TxtBoxSearchOrFilterDate);
            this.Controls.Add(this.BtnCheckRecordOrBack);
            this.Controls.Add(this.ListBoxCustomerInfo);
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
        private PictureBox PicBoxFilterIcon;
        private Button BtnDayVisited;
        private Label LblForwardSlash1;
        private TextBox TxtBoxYearVisited;
        private Label LblForwardSlash2;
        private Button BtnMonthVisited;
        private Button BtnCheckRecordOrBack;
        private TextBox TxtBoxSearchOrFilterDate;
        private ListBox ListBoxCustomerInfo;
        private Button BtnFilter;
        private Label LblNoteOfFormatOfListBox;
    }
}