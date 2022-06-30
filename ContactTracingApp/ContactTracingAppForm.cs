namespace ContactTracingApp
{
    public partial class ContactTracingAppForm : Form
    {
        public ContactTracingAppForm()
        {
            InitializeComponent();
        }
        //changes the month (in ascending order) when the button is pressed
        private byte MonthVisited = 1;
        private void BtnMonthVisited_Click(object sender, EventArgs e)
        {
            if (MonthVisited < 9)
            {
                MonthVisited++;
                BtnMonthVisited.Text = "0" + MonthVisited.ToString();
            }
            else if (MonthVisited <= 11 && !(MonthVisited < 9))
            {
                MonthVisited++;
                BtnMonthVisited.Text = MonthVisited.ToString();
            }
            else if (MonthVisited == 12)
            {
                BtnMonthVisited.Text = "01";
                MonthVisited = 1;
            }
        }

        private void CheckIfMonthOnlyHas30Days()
        {
            if (BtnDayVisited.Text == "31" && (BtnMonthVisited.Text == "April" || BtnMonthVisited.Text == "June"
                || BtnMonthVisited.Text == "September" || BtnMonthVisited.Text == "November"))
            {
                string DateWrongMsg = "The date you inputted is invalid. Please change it.";
                MessageBox.Show(DateWrongMsg, "Check the Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private byte Day = 1;
        private void BtnDayVisited_Click(object sender, EventArgs e)
        {
            if (Day < 9)
            {
                Day++;
                BtnDayVisited.Text = "0" + Day.ToString();
            }
            else if (!(Day < 9) && Day <= 30)
            {
                Day++;
                BtnDayVisited.Text = Day.ToString();
            }
            else
            {
                BtnDayVisited.Text = "01";
                Day = 1;
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
            if (BtnTimeEnteredAMPM.Text == "A.M.")
            {
                BtnTimeEnteredAMPM.Text = "P.M.";
            }
            else
            {
                BtnTimeEnteredAMPM.Text = "A.M.";
            }
        }
        private void BtnTimeDepartedAMPM_Click(object sender, EventArgs e)
        {
            if (BtnTimeDepartedAMPM.Text == "A.M.")
            {
                BtnTimeDepartedAMPM.Text = "P.M.";
            }
            else
            {
                BtnTimeDepartedAMPM.Text = "A.M.";
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
            if (TxtBoxHomeAddress.TextLength >= 105)
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
        }
        private void CheckIfEverythingHasBeenFilledUp()
        {
            bool EverythingHasBeenFilledUp;
            bool GenderRadioButtonsChecked = false;
            bool Q1RadioButtonsChecked = false;
            bool Q2RadioButtonsChecked = false;
            bool Q3RadioButtonsChecked = false;
            if (RdioBtnMale.Checked == true || RdioBtnFemale.Checked == true || (RdioBtnOtherGenders.Checked == true &&
                TxtBoxOtherGenders.Text != "") || RdioBtnDidntDisclose.Checked == true)
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
            if (RdioBtnQ3YesFirstDose.Checked == true || RdioBtnQ3YesSecondDose.Checked == true
                || RdioBtnQ3YesBooster.Checked == true || RdioBtnQ3No.Checked == true)
            {
                Q3RadioButtonsChecked = true;
            }
            if (TxtBoxName.Text == "" || TxtBoxHomeAddress.Text == "" || TxtBoxContactNum.Text == ""
                || TxtBoxYearVisited.Text == "" || GenderRadioButtonsChecked == false || Q1RadioButtonsChecked == false
                || Q2RadioButtonsChecked == false || Q3RadioButtonsChecked == false)
            {
                EverythingHasBeenFilledUp = false;
                string NotEverythingIsFilledUpMsg = "You haven't answered everything on the form. Please kindly answer them.";
                MessageBox.Show(NotEverythingIsFilledUpMsg, "Check the Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EverythingHasBeenFilledUp = true;
            }
            // to reset the form after a submission has been done
            if (EverythingHasBeenFilledUp == true)
            {
                string ConfirmationMsg = "Are you sure that everything you inputted in the form is correct?";
                string ConfirmationMsgTitle = "Confirmation Message";
                DialogResult ConfirmationMsgResult = MessageBox.Show(ConfirmationMsg, ConfirmationMsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ConfirmationMsgResult == DialogResult.Yes)
                {
                    ContactTracingAppForm ResettedForm = new();
                    ResettedForm.Show();
                    this.Dispose(false);
                    WriteTheInfoCollectedOnTheTextFile();
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
            StreamWriter ContactTracingFormInfoFileWriter;
            ContactTracingFormInfoFileWriter = File.AppendText("Contact Tracing Information from Customers.txt");
            ContactTracingFormInfoFileWriter.WriteLine(TxtBoxName.Text + " - " + BtnMonthVisited.Text + "/" + BtnDayVisited.Text + "/" + TxtBoxYearVisited.Text);
            ContactTracingFormInfoFileWriter.WriteLine("Address: " + TxtBoxHomeAddress.Text);
            ContactTracingFormInfoFileWriter.WriteLine("Contact Number: " + TxtBoxContactNum.Text);
            ContactTracingFormInfoFileWriter.WriteLine("Date Visited: " + BtnMonthVisited.Text + "/" + BtnDayVisited.Text + "/" + TxtBoxYearVisited.Text);
            ContactTracingFormInfoFileWriter.WriteLine("Time Entered: " + BtnHourEntered.Text + ":" + BtnMinuteEntered.Text + BtnTimeEnteredAMPM.Text);
            ContactTracingFormInfoFileWriter.WriteLine("Time Departed: " + BtnHourDeparted.Text + ":" + BtnMinuteDeparted.Text + BtnTimeDepartedAMPM.Text);
            // to determine what gender is to be inputted on the text file
            if (RdioBtnMale.Checked == true)
            {
                ContactTracingFormInfoFileWriter.WriteLine("Gender: " + RdioBtnMale.Text);
            }
            else if (RdioBtnFemale.Checked == true)
            {
                ContactTracingFormInfoFileWriter.WriteLine("Gender: " + RdioBtnFemale.Text);
            }
            else if (RdioBtnOtherGenders.Checked == true)
            {
                ContactTracingFormInfoFileWriter.WriteLine("Gender: " + TxtBoxOtherGenders.Text);
            }
            else if (RdioBtnDidntDisclose.Checked == true)
            {
                ContactTracingFormInfoFileWriter.WriteLine("Gender: Didn't Disclose");
            }
            // to determine what the user answered in question 1
            if (RdioBtnQ1Yes.Checked == true)
            {
                ContactTracingFormInfoFileWriter.WriteLine("Has COVID symptoms: Yes");
            }
            else if (RdioBtnQ1No.Checked == true)
            {
                ContactTracingFormInfoFileWriter.WriteLine("Has COVID symptoms: No");
            }
            // to determine what the user answered in question 2
            if (RdioBtnQ2Yes.Checked == true)
            {
                ContactTracingFormInfoFileWriter.WriteLine("Had contact with a COVID positive person: Yes");
            }
            else if (RdioBtnQ2No.Checked == true)
            {
                ContactTracingFormInfoFileWriter.WriteLine("Had contact with a COVID positive person: No");
            }
            // to determine what the user answered in question 3
            if (RdioBtnQ3YesFirstDose.Checked == true)
            {
                ContactTracingFormInfoFileWriter.WriteLine("Is Vaccinated: Yes, First Dose");
            }
            else if (RdioBtnQ3YesSecondDose.Checked == true)
            {
                ContactTracingFormInfoFileWriter.WriteLine("Is Vaccinated: Yes, Second Dose");
            }
            else if (RdioBtnQ3YesBooster.Checked == true)
            {
                ContactTracingFormInfoFileWriter.WriteLine("Is Vaccinated: Yes, Booster");
            }
            else if (RdioBtnQ3No.Checked == true)
            {
                ContactTracingFormInfoFileWriter.WriteLine("Is Vaccinated: No");
            }
            ContactTracingFormInfoFileWriter.Close();
        }
        
        private void BtnAccessTheDatabase_Click(object sender, EventArgs e)
        {
            string AuthorizationQuestionMsg = "Do you have the appropriate authorization to access this?";
            DialogResult AuthroizationQuestionMsgResult = MessageBox.Show(AuthorizationQuestionMsg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (AuthroizationQuestionMsgResult == DialogResult.Yes)
            {
                PasswordForm Form2 = new();
                Form2.Show();
                this.Visible = false;
            }
        }

        private void BtnAutoFill_Click(object sender, EventArgs e)
        {
            QRCodeScannerForm Form4 = new();
            Form4.Show();
            this.Visible = false;
        }

        public bool ThereIsAResultFromTheQRCodeScannerForm = false;

        private void ContactTracingAppForm_VisibleChanged(object sender, EventArgs e)
        {
            if (ThereIsAResultFromTheQRCodeScannerForm == true)
            {
                MessageBox.Show("Yay!");
                int LineCount = 0;
                StreamReader InfoToBeAutoFilledOnTheFormFileReader = new StreamReader(@"C:\Users\Stefani\source\repos\ContactTracingApp\ContactTracingApp\bin\Debug\net6.0-windows\Information that will be used to fill up the Form automatically.txt");
                while (!InfoToBeAutoFilledOnTheFormFileReader.EndOfStream)
                {
                    string LineOnTheTextFile = InfoToBeAutoFilledOnTheFormFileReader.ReadLine();
                    LineCount++;
                    if (LineCount == 1)
                    {
                        TxtBoxName.Text = LineOnTheTextFile;
                    }
                    else if (LineCount == 2)
                    {
                        TxtBoxHomeAddress.Text = LineOnTheTextFile;
                    }
                    else if (LineCount == 3)
                    {
                        TxtBoxContactNum.Text = LineOnTheTextFile;
                    }
                    else if (LineCount == 4)
                    {
                        BtnMonthVisited.Text = LineOnTheTextFile;
                    }
                    else if (LineCount == 5)
                    {
                        BtnDayVisited.Text = LineOnTheTextFile;
                    }
                    else if (LineCount == 6)
                    {
                        TxtBoxYearVisited.Text = LineOnTheTextFile;
                    }
                    else if (LineCount == 7)
                    {
                        BtnHourEntered.Text = LineOnTheTextFile;
                    }
                    else if (LineCount == 8)
                    {
                        BtnMinuteEntered.Text = LineOnTheTextFile;
                    }
                    else if (LineCount == 9)
                    {
                        BtnTimeEnteredAMPM.Text = LineOnTheTextFile;
                    }
                    else if (LineCount == 10)
                    {
                        BtnHourDeparted.Text = LineOnTheTextFile;
                    }
                    else if (LineCount == 11)
                    {
                        BtnMinuteDeparted.Text = LineOnTheTextFile;
                    }
                    else if (LineCount == 12)
                    {
                        BtnTimeDepartedAMPM.Text = LineOnTheTextFile;
                    }
                    else if (LineCount == 13)
                    {
                        if (LineOnTheTextFile == "Male")
                        {
                            RdioBtnMale.Checked = true;
                        }
                        else if (LineOnTheTextFile == "Female")
                        {
                            RdioBtnFemale.Checked = true;
                        }
                        else if (LineOnTheTextFile == "Others")
                        {
                            RdioBtnOtherGenders.Checked = true;
                        }
                    }
                    else if (LineCount == 14)
                    {
                        if (RdioBtnOtherGenders.Checked == true)
                        {
                            LineOnTheTextFile = TxtBoxOtherGenders.Text;
                        }
                        else
                        {
                            if (LineOnTheTextFile == "Yes")
                            {
                                RdioBtnQ1Yes.Checked = true;
                            }
                            else if (LineOnTheTextFile == "No")
                            {
                                RdioBtnQ1No.Checked = true;
                            }
                        }
                    }
                    else if (LineCount == 15)
                    {
                        if (RdioBtnOtherGenders.Checked == true)
                        {
                            if (LineOnTheTextFile == "Yes")
                            {
                                RdioBtnQ1Yes.Checked = true;
                            }
                            else if (LineOnTheTextFile == "No")
                            {
                                RdioBtnQ1No.Checked = true;
                            }
                        }
                        else
                        {
                            if (LineOnTheTextFile == "Yes")
                            {
                                RdioBtnQ2Yes.Checked = true;
                            }
                            else if (LineOnTheTextFile == "No")
                            {
                                RdioBtnQ2No.Checked = true;
                            }
                        }
                    }
                    else if (LineCount == 16)
                    {
                        if (RdioBtnOtherGenders.Checked == true)
                        {
                            if (LineOnTheTextFile == "Yes")
                            {
                                RdioBtnQ2Yes.Checked = true;
                            }
                            else if (LineOnTheTextFile == "No")
                            {
                                RdioBtnQ2No.Checked = true;
                            }
                        }
                        else
                        {
                            if (LineOnTheTextFile == "First Dose")
                            {
                                RdioBtnQ3YesFirstDose.Checked = true;
                            }
                            else if (LineOnTheTextFile == "Second Dose")
                            {
                                RdioBtnQ3YesSecondDose.Checked = true;
                            }
                            else if (LineOnTheTextFile == "Booster")
                            {
                                RdioBtnQ3YesBooster.Checked = true;
                            }
                            else if (LineOnTheTextFile == "No")
                            {
                                RdioBtnQ3No.Checked = true;
                            }
                        }
                    }
                    else if (LineCount == 17)
                    {
                        if (RdioBtnOtherGenders.Checked == true)
                        {
                            if (LineOnTheTextFile == "First Dose")
                            {
                                RdioBtnQ3YesFirstDose.Checked = true;
                            }
                            else if (LineOnTheTextFile == "Second Dose")
                            {
                                RdioBtnQ3YesSecondDose.Checked = true;
                            }
                            else if (LineOnTheTextFile == "Booster")
                            {
                                RdioBtnQ3YesBooster.Checked = true;
                            }
                            else if (LineOnTheTextFile == "No")
                            {
                                RdioBtnQ3No.Checked = true;
                            }
                        }
                    }
                }
            }
        }
    }
}

