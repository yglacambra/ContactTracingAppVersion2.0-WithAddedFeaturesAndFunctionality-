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
        List<string> CustomerNameList = new List<string>();
        private bool FilterButtonClicked = false;
        private void ContactTracingInfoDatabaseForm_Load(object sender, EventArgs e)
        {
            int LineCount = 0;
            StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
            while (!ContactTracingInfoFileReader.EndOfStream)
            {
                string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                LineCount++;
                if ((LineCount == 1 || ((LineCount - 1) % 10 == 0)))
                {
                    ListBoxCustomerInfo.Items.Add(LineOnTheTextFile);
                    CustomerNameList.Add(LineOnTheTextFile);
                }

            }
            ContactTracingInfoFileReader.Close();
            FilterButtonClicked = false;
        }

        private void BtnCheckRecordOrBack_Click(object sender, EventArgs e)
        {
            int ListBoxItemIndexNumber = ListBoxCustomerInfo.SelectedIndex;
            if (ListBoxCustomerInfo.SelectedIndex == -1 && BtnCheckRecordOrBack.Text == "Check Record")
            {
                string NoneSelectedMsg = "You have not selected anything from the textbox. Please select an item.";
                MessageBox.Show(NoneSelectedMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (ListBoxItemIndexNumber == 0 && BtnCheckRecordOrBack.Text == "Check Record" && FilterButtonClicked == false)
            {
                ChangeBtnTextToBack();
                int LineCount = 0;
                StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
                while (!ContactTracingInfoFileReader.EndOfStream)
                {
                    List<string> FirstCustomerInfoList = new List<string>();
                    string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                    LineCount++;
                    if ((!(LineCount == 1 || ((LineCount - 1) % 10 == 0))) && LineCount < 11)
                    {
                        FirstCustomerInfoList.Add(LineOnTheTextFile);
                        ListBoxCustomerInfo.Items.Add(LineOnTheTextFile);
                    }
                }
                ContactTracingInfoFileReader.Close();
            }
            else if (ListBoxItemIndexNumber == 1 && BtnCheckRecordOrBack.Text == "Check Record" && FilterButtonClicked == false)
            {
                ChangeBtnTextToBack();
                int LineCount = 0;
                StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
                while (!ContactTracingInfoFileReader.EndOfStream)
                {
                    string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                    LineCount++;
                    if ((!(LineCount == 1 || ((LineCount - 1) % 10 == 0))) && LineCount > 11 && LineCount < 21)
                    {
                        ListBoxCustomerInfo.Items.Add(LineOnTheTextFile);
                    }
                }
                ContactTracingInfoFileReader.Close();
            }

            else if (BtnCheckRecordOrBack.Text == "Back")
            {
                FilterButtonClicked = false;
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
            else if (ListBoxItemIndexNumber > 1 && FilterButtonClicked == false)
            {
                ChangeBtnTextToBack();
                int LineCount = 0;
                StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
                while (!ContactTracingInfoFileReader.EndOfStream)
                {
                    string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                    LineCount++;
                    if ((!(LineCount == 1 || (((LineCount - 1) % 10 == 0)))) && (LineCount <= ((ListBoxItemIndexNumber + 1) * 10)) && (LineCount > ((ListBoxItemIndexNumber * 11) - (ListBoxItemIndexNumber - 1)))
                        && !(ListBoxItemIndexNumber == 1))
                    {
                        ListBoxCustomerInfo.Items.Add(LineOnTheTextFile);
                    }
                }
                ContactTracingInfoFileReader.Close();
            }
            else if (FilterButtonClicked == true)
            {
                string ListBoxItemName = ListBoxCustomerInfo.GetItemText(ListBoxCustomerInfo.SelectedItem);
                if (CustomerNameList.Contains(ListBoxItemName))
                {
                    ChangeBtnTextToBack();
                    foreach (string CustomerNameWithDateVisited in CustomerNameList) 
                    {
                        if (CustomerNameWithDateVisited.Contains(ListBoxItemName))
                        {
                            int CustomerNameListItemIndex = CustomerNameList.IndexOf(CustomerNameWithDateVisited);
                            if (CustomerNameListItemIndex == 0)
                            {
                                int LineCount = 0;
                                StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
                                while (!ContactTracingInfoFileReader.EndOfStream)
                                {
                                    string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                                    LineCount++;
                                    if (LineCount > 1 && LineCount < 10)
                                    {
                                        ListBoxCustomerInfo.Items.Add(LineOnTheTextFile);
                                    }
                                }
                                ContactTracingInfoFileReader.Close();
                            }
                            else if (CustomerNameListItemIndex > 0)
                            {
                                int LineCount = 0;
                                StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
                                while (!ContactTracingInfoFileReader.EndOfStream)
                                {
                                    string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                                    LineCount++;
                                    if (LineCount > (CustomerNameListItemIndex * 10) && LineCount < ((CustomerNameListItemIndex * 10) + 10))
                                    {
                                        ListBoxCustomerInfo.Items.Add(LineOnTheTextFile);
                                    }
                                }
                                ContactTracingInfoFileReader.Close();
                            }

                        }
                    }
                }
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
        private void BtnFilter_Click(object sender, EventArgs e)
        {
            FilterButtonClicked = true;
            ListBoxCustomerInfo.Items.Clear();
            if (TxtBoxSearchOrFilterDate.Text == "")
            {
                string NoInputtedMsg = "You have not inputted anything on the textbox. Please type the date you want to search for";
                MessageBox.Show(NoInputtedMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                int LineCount = 0;
                StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
                while (!ContactTracingInfoFileReader.EndOfStream)
                {
                    string LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                    LineCount++;
                    if ((LineCount == 1 || ((LineCount - 1) % 10 == 0)))
                    {
                        ListBoxCustomerInfo.Items.Add(LineOnTheTextFile);
                    }
                }
                ContactTracingInfoFileReader.Close();
            }
            foreach (string CustomerNameWithDateVisited in CustomerNameList)
                if (CustomerNameWithDateVisited.Contains(TxtBoxSearchOrFilterDate.Text))
                {
                    ListBoxCustomerInfo.Items.Add(CustomerNameWithDateVisited);
                }
        }
    }
}
          
        






