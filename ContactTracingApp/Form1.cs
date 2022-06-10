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
        private byte Day = 0;
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
        private byte HourEntered = 0;
        private void BtnHourEntered_Click(object sender, EventArgs e)
        {
            if (HourEntered < 9)
            {
                HourEntered++;
                BtnHourEntered.Text = "0" + HourEntered.ToString();
            }
            else if (HourEntered <= 11 && !(HourEntered < 9))
            {
                HourEntered++;
                BtnHourEntered.Text = HourEntered.ToString();
            }
            else if (HourEntered == 12)
            {
                BtnHourEntered.Text = "01";
                HourEntered = 1;
            }
        }
        private byte MinuteEntered = 0;
        private void BtnMinuteEntered_Click(object sender, EventArgs e)
        {
            if (MinuteEntered < 9)
            {
                MinuteEntered++;
                BtnMinuteEntered.Text = "0" + MinuteEntered.ToString();
            }
            else if (MinuteEntered < 59)
            {
                MinuteEntered++;
                BtnMinuteEntered.Text = MinuteEntered.ToString();
            }
            else
            {
                MinuteEntered = 0;
                BtnMinuteEntered.Text = "00";
            }
        }
        private byte HourDeparted = 0;
        private void BtnHourDeparted_Click(object sender, EventArgs e)
        {
            if (HourDeparted < 9)
            {
                HourDeparted++;
                BtnHourDeparted.Text = "0" + HourDeparted.ToString();
            }
            else if (HourDeparted <= 11 && !(HourDeparted < 9))
            {
                HourDeparted++;
                BtnHourDeparted.Text = HourDeparted.ToString();
            }
            else if (HourDeparted == 12)
            {
                BtnHourDeparted.Text = "01";
                HourDeparted = 1;
            }
        }
        private byte MinuteDeparted = 0;
        private void BtnMinuteDeparted_Click(object sender, EventArgs e)
        {
            if (MinuteDeparted < 9)
            {
                MinuteDeparted++;
                BtnMinuteDeparted.Text = "0" + MinuteDeparted.ToString();
            }
            else if (MinuteDeparted < 59)
            {
                MinuteDeparted++;
                BtnMinuteDeparted.Text = MinuteDeparted.ToString();
            }
            else
            {
                MinuteDeparted = 0;
                BtnMinuteDeparted.Text = "00";
            }
        }
    }
}

