namespace ContactTracingApp
{
    partial class ContactTracingAppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactTracingAppForm));
            this.LblName = new System.Windows.Forms.Label();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.LblHomeAddress = new System.Windows.Forms.Label();
            this.TxtBoxHomeAddress = new System.Windows.Forms.TextBox();
            this.LblContactNum = new System.Windows.Forms.Label();
            this.TxtBoxContactNum = new System.Windows.Forms.TextBox();
            this.LblTimeEntered = new System.Windows.Forms.Label();
            this.TxtBoxHourTimeEntered = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblName.Location = new System.Drawing.Point(12, 24);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(72, 23);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name:";
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxName.Location = new System.Drawing.Point(23, 50);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(283, 26);
            this.TxtBoxName.TabIndex = 1;
            // 
            // LblHomeAddress
            // 
            this.LblHomeAddress.AutoSize = true;
            this.LblHomeAddress.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblHomeAddress.Location = new System.Drawing.Point(12, 88);
            this.LblHomeAddress.Name = "LblHomeAddress";
            this.LblHomeAddress.Size = new System.Drawing.Size(155, 23);
            this.LblHomeAddress.TabIndex = 2;
            this.LblHomeAddress.Text = "Home Address:";
            // 
            // TxtBoxHomeAddress
            // 
            this.TxtBoxHomeAddress.Location = new System.Drawing.Point(23, 114);
            this.TxtBoxHomeAddress.Name = "TxtBoxHomeAddress";
            this.TxtBoxHomeAddress.Size = new System.Drawing.Size(283, 23);
            this.TxtBoxHomeAddress.TabIndex = 3;
            // 
            // LblContactNum
            // 
            this.LblContactNum.AutoSize = true;
            this.LblContactNum.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblContactNum.Location = new System.Drawing.Point(12, 149);
            this.LblContactNum.Name = "LblContactNum";
            this.LblContactNum.Size = new System.Drawing.Size(173, 23);
            this.LblContactNum.TabIndex = 4;
            this.LblContactNum.Text = "Contact Number:";
            // 
            // TxtBoxContactNum
            // 
            this.TxtBoxContactNum.Location = new System.Drawing.Point(23, 175);
            this.TxtBoxContactNum.Name = "TxtBoxContactNum";
            this.TxtBoxContactNum.Size = new System.Drawing.Size(283, 23);
            this.TxtBoxContactNum.TabIndex = 5;
            // 
            // LblTimeEntered
            // 
            this.LblTimeEntered.AutoSize = true;
            this.LblTimeEntered.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTimeEntered.Location = new System.Drawing.Point(410, 24);
            this.LblTimeEntered.Name = "LblTimeEntered";
            this.LblTimeEntered.Size = new System.Drawing.Size(144, 23);
            this.LblTimeEntered.TabIndex = 6;
            this.LblTimeEntered.Text = "Time Entered:";
            // 
            // TxtBoxHourTimeEntered
            // 
            this.TxtBoxHourTimeEntered.Location = new System.Drawing.Point(446, 50);
            this.TxtBoxHourTimeEntered.Name = "TxtBoxHourTimeEntered";
            this.TxtBoxHourTimeEntered.Size = new System.Drawing.Size(32, 23);
            this.TxtBoxHourTimeEntered.TabIndex = 7;
            // 
            // ContactTracingAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBoxHourTimeEntered);
            this.Controls.Add(this.LblTimeEntered);
            this.Controls.Add(this.TxtBoxContactNum);
            this.Controls.Add(this.LblContactNum);
            this.Controls.Add(this.TxtBoxHomeAddress);
            this.Controls.Add(this.LblHomeAddress);
            this.Controls.Add(this.TxtBoxName);
            this.Controls.Add(this.LblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactTracingAppForm";
            this.Text = "Contact Tracing Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblName;
        private TextBox TxtBoxName;
        private Label LblHomeAddress;
        private TextBox TxtBoxHomeAddress;
        private Label LblContactNum;
        private TextBox TxtBoxContactNum;
        private Label LblTimeEntered;
        private TextBox TxtBoxHourTimeEntered;
    }
}