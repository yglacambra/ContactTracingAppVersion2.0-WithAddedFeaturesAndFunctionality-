namespace ContactTracingApp
{
    public partial class ContactTracingAppForm : Form
    {
        public ContactTracingAppForm()
        {
            InitializeComponent();
        }
        //changes the month (in ascending order) when the button is pressed
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
            short Year = 0;
            if (TxtBoxYearVisited.Text != "")
            {
                Year = short.Parse(TxtBoxYearVisited.Text); ;
            }
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
            short Year = 0;
            if (TxtBoxYearVisited.Text != "")
            {
                Year = short.Parse(TxtBoxYearVisited.Text); ;
            }
            if (Year <= 1999 || Year >= 2100)
            {
                string InvalidYearInputtedMsg = "The year that you inputted is not in the 21st Century. Please change it.";
                MessageBox.Show(InvalidYearInputtedMsg, "Check The Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBoxYearVisited.Text = "";
            }
        }
        //changing the day when the button is pressed
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
        //restricts the input on the yar textbox
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
        //changes the hour when the button is pressed
        private byte HourEntered = 1;
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
        //changes the minute when the button is pressed
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

        private byte HourDeparted = 1;
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
        //changes Am to Pm and vice versa when the button is pressed
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

        //restricts the input on thw contact number textbox
        private void TxtBoxContactNum_TextChanged(object sender, EventArgs e)
        {
            if (TxtBoxContactNum.TextLength > 11)
            {
                string TooManyCharactersMsg = "You inputted too many characters.";
                string TooManyCharactersMsgBoxTitle = "Maximum Amount Of Characters Reached. Only mobile numbers are accepted.";
                MessageBox.Show(TooManyCharactersMsg, TooManyCharactersMsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtBoxContactNum.Text = "";
            }
        }

        private void TxtBoxContactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                string InvalidCharactersInputtedMsg = "You inputted characters that are not numbers.";
                MessageBox.Show(InvalidCharactersInputtedMsg, "Invalid Characters", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //restricts input on the name textbox
        private void TxtBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) 
                && e.KeyChar != '.' && e.KeyChar != ' ')
            {
                string InvalidCharactersInputtedMsg = "You inputted characters that are not letters or dots.";
                MessageBox.Show(InvalidCharactersInputtedMsg, "Invalid Characters", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // message box that will appear when press is submitted and everything has been filled up
           
            //to ensure that no date gets submitted that has a day that is 0
            if (BtnDayVisited.Text == "0")
            {
                string DateWrongMsg = "The date you inputted is invalid. Please change it.";
                MessageBox.Show(DateWrongMsg, "Check The Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnDayVisited.Text = "0";
                Day = 0;
            }
            //restricts input on the name textbox
            if (TxtBoxName.TextLength >= 45)
            {
                string TooManyCharactersMsg = "You inputted too many characters on the name textbox.";
                string TooManyCharactersMsgBoxTitle = "Check The Form";
                MessageBox.Show(TooManyCharactersMsg, TooManyCharactersMsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //restricts the input on the address textbox
            if (TxtBoxHomeAddress.TextLength >= 70)
            {
                string TooManyCharactersMsg = "You inputted too many characters on the address textbox.";
                string TooManyCharactersMsgBoxTitle = "Check The Form";
                MessageBox.Show(TooManyCharactersMsg, TooManyCharactersMsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //restricts the input on the other genders textbox
            if (TxtBoxOtherGenders.TextLength >= 30)
            {
                string TooManyCharactersMsg = "You inputted too many characters on the other genders textbox.";
                string TooManyCharactersMsgBoxTitle = "Check The Form";
                MessageBox.Show(TooManyCharactersMsg, TooManyCharactersMsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CheckIfMonthOnlyHas30Days();
            CheckIfMonthOnlyHas28Days();
            CheckIfTheYearIsInThe21stCentury();
            CheckIfEverythingHasBeenFilledUp();
            WriteTheInfoCollectedOnTheTextFile();
        }
        private void CheckIfEverythingHasBeenFilledUp()
        {
            bool EverythingHasBeenFilledUp = false;
            bool GenderRadioButtonsChecked = false;
            bool Q1RadioButtonsChecked = false;
            bool Q2RadioButtonsChecked = false;
            if (RdioBtnMale.Checked == true || RdioBtnFemale.Checked == true || (RdioBtnOtherGenders.Checked == true &&
                TxtBoxOtherGenders.Text != "")|| RdioBtnDidntDisclose.Checked == true)
            {
                GenderRadioButtonsChecked = true;
            }
            if (RdioBtnQ1No.Checked == true || RdioBtnQ1Yes.Checked == true)
            {
                Q1RadioButtonsChecked = true;
            }
            if (RdioBtnQ2No.Checked == true || RdioBtnQ2Yes.Checked == true)
            {
                Q2RadioButtonsChecked = true;
            }
            if (TxtBoxName.Text == "" || TxtBoxHomeAddress.Text == "" || TxtBoxContactNum.Text == ""
                || TxtBoxYearVisited.Text == "" || GenderRadioButtonsChecked == false || Q1RadioButtonsChecked == false
                || Q2RadioButtonsChecked == false)
            {
                EverythingHasBeenFilledUp = false;
                string NotEverythingIsFilledUpMsg = "You haven't answered everything on the form. Please kindly answer them.";
                MessageBox.Show (NotEverythingIsFilledUpMsg, "Check the Form",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EverythingHasBeenFilledUp = true;
            }
            // to reset the form after a submission has been done
            if(EverythingHasBeenFilledUp == true)
            {
                string ConfirmationMsg = "Are you sure that everything you inputted in the form is correct?";
                string ConfirmationMsgTitle = "Confirmation Message";
                DialogResult ConfirmationMsgResult = MessageBox.Show (ConfirmationMsg,ConfirmationMsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ConfirmationMsgResult == DialogResult.Yes)
                {
                    ContactTracingAppForm ResettedForm = new ContactTracingAppForm();
                    ResettedForm.Show();
                    this.Dispose(false);
                }
            }
        }
        
        //locks out the other gender buttons textbox if the other genders radio button is not checked
        private void ContactTracingAppForm_Load(object sender, EventArgs e)
        {
            TxtBoxOtherGenders.Enabled = false;
        }

        private void RdioBttonOtherGenders_CheckedChanged(object sender, EventArgs e)
        {
            TxtBoxOtherGenders.Enabled = true;
        }

        private void RdioBtnMale_CheckedChanged(object sender, EventArgs e)
        {
            TxtBoxOtherGenders.Enabled = false;
        }

        private void RdioBtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            TxtBoxOtherGenders.Enabled = false;
        }

        private void RdioBtnDidntDisclose_CheckedChanged(object sender, EventArgs e)
        {
            TxtBoxOtherGenders.Enabled = false;
        }
        private void WriteTheInfoCollectedOnTheTextFile()
        {
            StreamWriter ContactTracingFormInfoFile = new StreamWriter(@"C:\Users\Public\Documents\Contact Tracing Info.txt", true);
            ContactTracingFormInfoFile.WriteLine("Name: " + TxtBoxName.Text);
            ContactTracingFormInfoFile.WriteLine("Address: " + TxtBoxHomeAddress.Text); 
            ContactTracingFormInfoFile.WriteLine("Contact Number: " + TxtBoxContactNum.Text);
            ContactTracingFormInfoFile.WriteLine("Date Visited: " + BtnMonthVisited.Text + " " + BtnDayVisited.Text + "," + TxtBoxYearVisited.Text);
            ContactTracingFormInfoFile.WriteLine("Time Entered: " + BtnHourEntered.Text + ":" + BtnMinuteEntered.Text);
            ContactTracingFormInfoFile.WriteLine("Time Departed: " + BtnHourDeparted.Text + ":" + BtnMinuteDeparted.Text);
            // to determine what gender is to be inputted on the text file
            if (RdioBtnMale.Checked == true)
            {
                ContactTracingFormInfoFile.WriteLine("Gender: " + RdioBtnMale.Text);
            }
            else if (RdioBtnFemale.Checked == true)
            {
                ContactTracingFormInfoFile.WriteLine("Gender: " + RdioBtnFemale.Text);
            }
            else if (RdioBtnOtherGenders.Checked == true)
            {
                ContactTracingFormInfoFile.WriteLine("Gender: " + TxtBoxOtherGenders.Text);
            }
            else if (RdioBtnDidntDisclose.Checked == true)
            {
                ContactTracingFormInfoFile.WriteLine("Gender: Didn't Disclose");
            }
            // to determine what the user answered in question 1
            if (RdioBtnQ1Yes.Checked == true)
            {
                ContactTracingFormInfoFile.WriteLine("Has COVID symptoms: Yes");
            }
            else if (RdioBtnQ1No.Checked == true)
            {
                ContactTracingFormInfoFile.WriteLine("Has COVID symptoms: No");
            }
            // to determine what the user answered in question 2
            if (RdioBtnQ2Yes.Checked == true)
            {
                ContactTracingFormInfoFile.WriteLine("Had contact with a COVID positive person: Yes");
            }
            else if (RdioBtnQ2No.Checked == true)
            {
                ContactTracingFormInfoFile.WriteLine("Had contact with a COVID positive person: No");
            }
            ContactTracingFormInfoFile.Close();
        }
      
    }
}

