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
            string LineOnTheTextFile;
            StreamReader ContactTracingInfoFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Contact Tracing Information from Customers.txt");
                while (!ContactTracingInfoFileReader.EndOfStream)
                {
                    LineCount++;
                    LineOnTheTextFile = ContactTracingInfoFileReader.ReadLine();
                List<string> NameList = new List<string>();
                if (LineCount == 1 && LineCount % 10 == 1)
                {
                    NameList.Add(LineOnTheTextFile);
                    ListBoxCustomerNames.DataSource = NameList;
                }
                }
        }
    }
}
