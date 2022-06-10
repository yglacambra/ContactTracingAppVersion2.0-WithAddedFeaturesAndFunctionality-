namespace ContactTracingApp
{
    public partial class ContactTracingAppForm : Form
    {
        public ContactTracingAppForm()
        {
            InitializeComponent();
        }
        private void BtnMonthVisited_Click(object sender, EventArgs e)
        {
            byte MonthVisited = 1;
            if (BtnMonthVisited.Text == "January")
            {
                BtnMonthVisited.Text = "February";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "February")
            {
                BtnMonthVisited.Text = "March";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "March")
            {
                BtnMonthVisited.Text = "April";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "April")
            {
                BtnMonthVisited.Text = "May";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "May")
            {
                BtnMonthVisited.Text = "June";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "June")
            {
                BtnMonthVisited.Text = "July";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "July")
            {
                BtnMonthVisited.Text = "August";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "August")
            {
                BtnMonthVisited.Text = "September";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "September")
            {
                BtnMonthVisited.Text = "October";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "October")
            {
                BtnMonthVisited.Text = "November";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "November")
            {
                BtnMonthVisited.Text = "December";
                ++MonthVisited;
            }
            else
            {
                BtnMonthVisited.Text = "January";
                ++MonthVisited;
            }
        }
        private int Day = 0;
        private void BtnDayVisited_Click(object sender, EventArgs e)
        {
            if (BtnDayVisited.Text != "31" || BtnDayVisited.Text == "0")
            {
                Day++;
                BtnDayVisited.Text = Day.ToString();
            }
            else
            {
                BtnDayVisited.Text = "0";
                Day = 0;
            }
        }

        private void TxtBoxYearVisited_TextChanged(object sender, EventArgs e)
        {
            if (TxtBoxYearVisited.TextLength > 4)
            {
                string TooManyCharactersMsg = "The year that you inputted has too many characters. Please change it.";
                MessageBox.Show(TooManyCharactersMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtBoxYearVisited.Text = "";
            }
        }
        private void TxtBoxYearVisited_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                string InvalidCharactersInputtedMsg = "The year that you inputted has characters that are not numbers. Please change it.";
                MessageBox.Show(InvalidCharactersInputtedMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private byte Hour = 1;
        private void BtnHourEntered_Click(object sender, EventArgs e)
        {
            if (Hour < 9)
            {
                Hour++;
                BtnHourEntered.Text = "0" + Hour.ToString();
            }
            else if (Hour <= 11 && !(Hour < 9))
            {
                Hour++;
                BtnHourEntered.Text = Hour.ToString();
            }
            else if (Hour == 12)
            {
                BtnHourEntered.Text = "01";
                Hour = 1;
            }
        }
        private byte Minute = 0;
        private void BtnMinuteEntered_Click(object sender, EventArgs e)
        {
            if (Minute < 9)
            {
                Minute++;
                BtnMinuteEntered.Text = "0" + Minute.ToString();
            }
            else if (Minute < 59)
            {
                Minute++;
                BtnMinuteEntered.Text = Minute.ToString();
            }
            else
            {
                Minute = 0;
                BtnMinuteEntered.Text = "00";
            }
        }
    }
}

