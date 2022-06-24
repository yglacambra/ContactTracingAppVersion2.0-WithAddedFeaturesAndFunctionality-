using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTracingApp
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {
            TxtBoxPassword.PasswordChar = '*';
        }
        private bool CorrectPasswordInputted = false;
        private void TxtBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtBoxPassword.Text == "BSCOE1-4OOP")
                {
                    CorrectPasswordInputted = true;
                    ContactTracingInfoDatabaseForm Form3 = new();
                    Form3.Show();
                    this.Close();
                }
                else
                {
                    string WrongPasswordMsg = "You entered the wrong password. Please try again.";
                    MessageBox.Show(WrongPasswordMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtBoxPassword.Text = "";
                }
            }
        }

        private void PasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContactTracingAppForm Form1 = new();
            if (CorrectPasswordInputted == true)
            {
                Form1.Visible = false;
            }
            else
            {
                Form1.Visible = true;
            }
        }
    }
}
