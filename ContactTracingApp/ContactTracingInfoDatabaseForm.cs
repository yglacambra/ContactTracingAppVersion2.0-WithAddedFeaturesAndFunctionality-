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
        List<string> CustomerInfoList = new List<string>();
        private void ContactTracingInfoDatabaseForm_Load(object sender, EventArgs e)
        {
            int LineCount = 0;
            StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
            while (!ContactTracingInfoFileReader.EndOfStream)
            {
                string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                LineCount++;
                if (LineCount == 1 || ((LineCount - 1) % 10 == 0))
                {
                   CustomerInfoList.AddRange(new string[]{LineOnTheTextFile});
                    foreach (string CustomerInfo in CustomerInfoList)
                    {
                        if (LineCount == 1 || ((LineCount - 1) % 10 == 0))
                        ListBoxCustomerInfo.Items.Add(CustomerInfo);
                    }
                }

            }
            ContactTracingInfoFileReader.Close();
        }
        private void BtnCheckRecordOrBack_Click(object sender, EventArgs e)
        {
            int ListBoxItemIndexNumber = ListBoxCustomerInfo.SelectedIndex;
            if (ListBoxCustomerInfo.SelectedIndex == -1 && BtnCheckRecordOrBack.Text == "Check Record")
            {
                string NoneSelectedMsg = "You have not selected anything from the textbox. Please select an item.";
                MessageBox.Show(NoneSelectedMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (ListBoxItemIndexNumber == 0 && BtnCheckRecordOrBack.Text == "Check Record")
            {
                ChangeBtnTextToBack();
                int LineCount = 0;
                StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
                while (!ContactTracingInfoFileReader.EndOfStream)
                {
                    string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                    LineCount++;
                    if ((!(LineCount == 1 || ((LineCount - 1) % 10 == 0))) && LineCount < 11 && !(LineCount==4))
                    {
                        ListBoxCustomerInfo.Items.Add(LineOnTheTextFile);
                    }
                    else if (LineCount == 4)
                    {
                        ListBoxCustomerInfo.Items.Add("Date Visited: " + LineOnTheTextFile);
                    }
                }
                ContactTracingInfoFileReader.Close();
            }
            else if (ListBoxItemIndexNumber == 1 && BtnCheckRecordOrBack.Text == "Check Record")
            {
                ChangeBtnTextToBack();
                int LineCount = 0;
                StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
                while (!ContactTracingInfoFileReader.EndOfStream)
                {
                    string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                    LineCount++;
                    if ((!(LineCount == 1 || ((LineCount - 1) % 10 == 0))) && LineCount > 11 && LineCount < 21 && !((LineCount - 4) % 10 == 0))
                    {
                        ListBoxCustomerInfo.Items.Add(LineOnTheTextFile);
                    }
                    if ((!(LineCount == 1 || ((LineCount - 1) % 10 == 0))) && LineCount > 11 && LineCount < 21 && ((LineCount - 4) % 10 == 0))
                    {
                        ListBoxCustomerInfo.Items.Add("Date Visited: " + LineOnTheTextFile);
                    }
                }
                ContactTracingInfoFileReader.Close();
            }

            else if (BtnCheckRecordOrBack.Text == "Back")
            {
                if (ListBoxCustomerInfo.Items.Count > 0)
                {
                    ListBoxCustomerInfo.Items.Clear();
                    BtnCheckRecordOrBack.Text = "Check Record";
                    if (ListBoxCustomerInfo.Items.Count == 0)
                    {
                        int LineCount = 0;
                        StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
                        while (!ContactTracingInfoFileReader.EndOfStream)
                        {
                            string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                            LineCount++;
                            if (LineCount == 1 || ((LineCount - 1) % 10 == 0))
                            {
                                ListBoxCustomerInfo.Items.Add(LineOnTheTextFile);
                            }
                        }
                        ContactTracingInfoFileReader.Close();
                    }
                }
            }
            else if (ListBoxItemIndexNumber > 1)
            {
                ChangeBtnTextToBack();
                int LineCount = 0;
                StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
                while (!ContactTracingInfoFileReader.EndOfStream)
                {
                    string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                    LineCount++;
                    if ((!(LineCount == 1 || (((LineCount - 1) % 10 == 0)))) && (LineCount <= ((ListBoxItemIndexNumber + 1) * 10)) && (LineCount > ((ListBoxItemIndexNumber * 11) - (ListBoxItemIndexNumber - 1))) 
                        && !(ListBoxItemIndexNumber == 1) && !((LineCount - 4) % 10 == 0))
                    {
                        ListBoxCustomerInfo.Items.Add(LineOnTheTextFile);
                    }
                    if (((LineCount - 4) % 10 == 0) && (!(LineCount == 1 || (((LineCount - 1) % 10 == 0)))) && (LineCount <= ((ListBoxItemIndexNumber + 1) * 10)) 
                        && (LineCount > ((ListBoxItemIndexNumber * 11) - (ListBoxItemIndexNumber - 1))))
                    {
                        ListBoxCustomerInfo.Items.Add("Date Visited: " + LineOnTheTextFile);
                    }
                }
                ContactTracingInfoFileReader.Close();
            }
        }
        private void ChangeBtnTextToBack()
        {
            if (BtnCheckRecordOrBack.Text == "Check Record")
            {
                BtnCheckRecordOrBack.Text = "Back";
                if (ListBoxCustomerInfo.Items.Count > 0)
                {
                    ListBoxCustomerInfo.Items.Clear();
                }
            }
        }

        private void BtnFilterByDate_Click(object sender, EventArgs e)
        {
            ListBoxCustomerInfo.Items.Clear();
            int LineCount = 0;
            int TotalItems = ListBoxCustomerInfo.Items.Count;
            StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
            while (!ContactTracingInfoFileReader.EndOfStream)
            {
                string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                LineCount++;
                if (LineCount == 4 || (((LineCount - 4) % 10 == 0)))
                {
                    ListBoxCustomerInfo.Items.Add((LineOnTheTextFile));
                    for (int i = 0; i < TotalItems; ++i)
                    {
                        string ListBoxItemIndexString = ListBoxCustomerInfo.Items[i].ToString();
                        if (ListBoxItemIndexString.Contains(TxtBoxSearchOrFilterDate.Text))
                        {
                            int Dateindex = i;
                            ListBoxCustomerInfo.Items.Clear();
                        }
                    }
                }
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            ListBoxCustomerInfo.Items.Clear();
            foreach (string CustomerInfo in CustomerInfoList)
            {
                if (CustomerInfo.Contains(TxtBoxSearchOrFilterDate.Text))
                {
                   ListBoxCustomerInfo.Items.Add(CustomerInfo);
                }
            }
        }
    }           
}
          
        






