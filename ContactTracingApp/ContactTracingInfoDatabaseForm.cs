using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Text.RegularExpressions;


namespace ContactTracingApp
{
    public partial class ContactTracingInfoDatabaseForm : Form
    {
        public ContactTracingInfoDatabaseForm()
        {
            InitializeComponent();
        }

        private void ContactTracingInfoDatabaseForm_Load(object sender, EventArgs e)
        {
            int LineCount = 0;
            StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
            List<string> NameList = new List<string>();
            while (!ContactTracingInfoFileReader.EndOfStream)
            {
                string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                LineCount++;
                if (LineCount == 1 || ((LineCount - 1) % 9 == 0))
                {
                    ListBoxCustomerNames.Items.Add(LineOnTheTextFile);
                }
            }
        }
    }         
}

