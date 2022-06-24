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
            while (!ContactTracingInfoFileReader.EndOfStream)
            {
                string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                LineCount++;
                if (LineCount == 1 || ((LineCount - 1) % 9 == 0))
                {
                    ListBoxCustomerInformation.Items.Add(LineOnTheTextFile);
                }
            }
            ContactTracingInfoFileReader.Close();
        }

        private void BtnCheckRecord_Click(object sender, EventArgs e)
        {
            int IndexNumber = ListBoxCustomerInformation.SelectedIndex;
            if (IndexNumber == 0)
            {
                ChangeBtnTextToBack();
                int LineCount = 0;
                StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
                while (!ContactTracingInfoFileReader.EndOfStream)
                {
                    string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                    LineCount++;
                    if (!(LineCount == 1 || ((LineCount - 1) % 9 == 0)) && LineCount < 9)
                    {
                        ListBoxCustomerInformation.Items.Add(LineOnTheTextFile);
                    }
                }
                ContactTracingInfoFileReader.Close();
            }
            else if (BtnCheckRecord.Text == "Back")
            {
                if (ListBoxCustomerInformation.Items.Count > 0)
                {
                    ListBoxCustomerInformation.Items.Clear();
                    BtnCheckRecord.Text = "Check Record";
                    if (ListBoxCustomerInformation.Items.Count == 0)
                    {
                        int LineCount = 0;
                        StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
                        while (!ContactTracingInfoFileReader.EndOfStream)
                        {
                            string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                            LineCount++;
                            if (LineCount == 1 || ((LineCount - 1) % 9 == 0))
                            {
                                ListBoxCustomerInformation.Items.Add(LineOnTheTextFile);
                            }
                        }
                        ContactTracingInfoFileReader.Close();
                    }
                }
            }
            else
            {
                ChangeBtnTextToBack();
                int LineCount = 0;
                StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
                while (!ContactTracingInfoFileReader.EndOfStream)
                {
                    string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                    LineCount++;
                    if (!(LineCount == 1 || ((LineCount - 1) % 9 == 0)) && (LineCount < (IndexNumber + 1) * 9) && (LineCount > IndexNumber * 9))
                    {
                        ListBoxCustomerInformation.Items.Add(LineOnTheTextFile);
                    }
                }
                ContactTracingInfoFileReader.Close();
            }
        }
        private void ChangeBtnTextToBack()
        {
            if (BtnCheckRecord.Text == "Check Record")
            {
                BtnCheckRecord.Text = "Back";
                if (ListBoxCustomerInformation.Items.Count > 0)
                {
                    ListBoxCustomerInformation.Items.Clear();
                }
           }
        }
    }
}


