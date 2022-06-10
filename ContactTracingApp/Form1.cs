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

        private void CheckIfMonthOnlyHas30Days()
        {
            if (BtnDayVisited.Text == "31" && (BtnMonthVisited.Text == "April" || BtnMonthVisited.Text == "June" 
                || BtnMonthVisited.Text == "September" || BtnMonthVisited.Text == "November"))
            {
                string DateWrongMsg = "The date you inputted is invalid. Please change it.";
                MessageBox.Show (DateWrongMsg,"Check the Form",MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnDayVisited.Text = "30";
                Day = 30;
            }
        }

        private void CheckIfMonthOnlyHas28Days()
        {
            short Year = short.Parse(TxtBoxYearVisited.Text);
            if (Day >= 29 && BtnMonthVisited.Text == "February" && !(Year % 4 == 0))
            {
                string DateWrongMsg = "The date you inputted is invalid. Please change it.";
                MessageBox.Show(DateWrongMsg, "Check The Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnDayVisited.Text = "28";
                Day = 28;
            }
            else if (Day >= 30 && BtnMonthVisited.Text == "February" && (Year % 4 == 0))
            {
                string DateWroongMsg = "The date you inputted is invalid. Please change it.";
                MessageBox.Show(DateWroongMsg, "Check The Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnDayVisited.Text = "29";
                Day = 29;
            }
        }

        private void CheckIfTheYearIsInThe21stCentury()
        {
            short Year = short.Parse(TxtBoxYearVisited.Text);
            if (Year <= 1999 || Year >= 2100)
            {
                string InvalidYearInputtedMsg = "The year that you inputted is not in the 21st Century. Please change it.";
                MessageBox.Show(InvalidYearInputtedMsg, "Check The Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBoxYearVisited.Text = "";
            }
        }
     
        private byte Day = 0;
        private void BtnDayVisited_Click(object sender, EventArgs e)
        {
            if (Day < 31)
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
                string TooManyCharactersMsg = "You inputted too many characters.";
                string TooManyCharactersMsgBoxTitle = "Maximum Amount Of Characters Reached";
                MessageBox.Show(TooManyCharactersMsg, TooManyCharactersMsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtBoxYearVisited.Text = "";
            }
        }

        private void TxtBoxYearVisited_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                string InvalidCharactersInputtedMsg = "You inputted characters that are not numbers.";
                MessageBox.Show(InvalidCharactersInputtedMsg, "Invalid Characters", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void BtnTimeEnteredAMPM_Click(object sender, EventArgs e)
        {
            if (BtnTimeEnteredAMPM.Text == "AM")
            {
                BtnTimeEnteredAMPM.Text = "PM";
            }
            else
            {
                BtnTimeEnteredAMPM.Text = "AM";
            }
        }
        private void BtnTimeDepartedAMPM_Click(object sender, EventArgs e)
        {
            if (BtnTimeDepartedAMPM.Text == "AM")
            {
                BtnTimeDepartedAMPM.Text = "PM";
            }
            else
            {
                BtnTimeDepartedAMPM.Text = "AM";
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //to ensure that no date gets submitted that has a day that is 0
            if (BtnDayVisited.Text == "0")
            {
                string DateWrongMsg = "The date you inputted is invalid. Please change it.";
                MessageBox.Show(DateWrongMsg, "Check The Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnDayVisited.Text = "0";
                Day = 0;
            }
            CheckIfMonthOnlyHas30Days();
            CheckIfMonthOnlyHas28Days();
            CheckIfTheYearIsInThe21stCentury();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

