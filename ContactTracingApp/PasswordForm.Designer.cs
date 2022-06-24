namespace ContactTracingApp
{
    partial class PasswordForm
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
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPassword.Location = new System.Drawing.Point(10, 12);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(78, 19);
            this.LblPassword.TabIndex = 0;
            this.LblPassword.Text = "Password:";
            // 
            // TxtBoxPassword
            // 
            this.TxtBoxPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxPassword.Location = new System.Drawing.Point(94, 12);
            this.TxtBoxPassword.Name = "TxtBoxPassword";
            this.TxtBoxPassword.Size = new System.Drawing.Size(129, 27);
            this.TxtBoxPassword.TabIndex = 1;
            this.TxtBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBoxPassword_KeyDown);
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 45);
            this.Controls.Add(this.TxtBoxPassword);
            this.Controls.Add(this.LblPassword);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "PasswordForm";
            this.ShowIcon = false;
            this.Text = "Password";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PasswordForm_FormClosed);
            this.Load += new System.EventHandler(this.PasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblPassword;
        private TextBox TxtBoxPassword;
    }
}