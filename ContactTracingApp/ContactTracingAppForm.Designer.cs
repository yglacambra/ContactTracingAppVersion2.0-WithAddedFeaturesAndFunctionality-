namespace ContactTracingApp
{
    partial class ContactTracingAppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactTracingAppForm));
            this.LblName = new System.Windows.Forms.Label();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.LblHomeAddress = new System.Windows.Forms.Label();
            this.TxtBoxHomeAddress = new System.Windows.Forms.TextBox();
            this.LblContactNum = new System.Windows.Forms.Label();
            this.TxtBoxContactNum = new System.Windows.Forms.TextBox();
            this.LblGender = new System.Windows.Forms.Label();
            this.RdioBtnMale = new System.Windows.Forms.RadioButton();
            this.RdioBtnFemale = new System.Windows.Forms.RadioButton();
            this.RdioBtnOtherGenders = new System.Windows.Forms.RadioButton();
            this.TxtBoxOtherGenders = new System.Windows.Forms.TextBox();
            this.LblSpecify = new System.Windows.Forms.Label();
            this.RdioBtnQ1Yes = new System.Windows.Forms.RadioButton();
            this.RdioBtnQ1No = new System.Windows.Forms.RadioButton();
            this.LblQuestion1 = new System.Windows.Forms.Label();
            this.LblQuestion2 = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.PnlGender = new System.Windows.Forms.Panel();
            this.RdioBtnDidntDisclose = new System.Windows.Forms.RadioButton();
            this.PnlQ1YesNo = new System.Windows.Forms.Panel();
            this.PnlQ2YesNo = new System.Windows.Forms.Panel();
            this.RdioBtnQ2No = new System.Windows.Forms.RadioButton();
            this.RdioBtnQ2Yes = new System.Windows.Forms.RadioButton();
            this.LblMallName = new System.Windows.Forms.Label();
            this.PicBoxPalmTree = new System.Windows.Forms.PictureBox();
            this.MenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.ComboBtnSettings = new System.Windows.Forms.ToolStripSplitButton();
            this.BtnAccessTheDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.LblQuestion3 = new System.Windows.Forms.Label();
            this.PanelQ3VaccinationQuestion = new System.Windows.Forms.Panel();
            this.RdioBtnQ3YesBooster = new System.Windows.Forms.RadioButton();
            this.RdioBtnQ3No = new System.Windows.Forms.RadioButton();
            this.RdioBtnQ3YesSecondDose = new System.Windows.Forms.RadioButton();
            this.RdioBtnQ3YesFirstDose = new System.Windows.Forms.RadioButton();
            this.BtnTimeDepartedAMPM = new System.Windows.Forms.Button();
            this.BtnMinuteDeparted = new System.Windows.Forms.Button();
            this.LblTLColon = new System.Windows.Forms.Label();
            this.BtnHourDeparted = new System.Windows.Forms.Button();
            this.LblTimeDeparted = new System.Windows.Forms.Label();
            this.BtnTimeEnteredAMPM = new System.Windows.Forms.Button();
            this.BtnMinuteEntered = new System.Windows.Forms.Button();
            this.LbllTEColon = new System.Windows.Forms.Label();
            this.BtnHourEntered = new System.Windows.Forms.Button();
            this.LblTimeEntered = new System.Windows.Forms.Label();
            this.LblForwardSlash2 = new System.Windows.Forms.Label();
            this.TxtBoxYearVisited = new System.Windows.Forms.TextBox();
            this.BtnDayVisited = new System.Windows.Forms.Button();
            this.LblForwardSlash1 = new System.Windows.Forms.Label();
            this.BtnMonthVisited = new System.Windows.Forms.Button();
            this.LblDateVisited = new System.Windows.Forms.Label();
            this.PnlGender.SuspendLayout();
            this.PnlQ1YesNo.SuspendLayout();
            this.PnlQ2YesNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPalmTree)).BeginInit();
            this.MenuToolStrip.SuspendLayout();
            this.PanelQ3VaccinationQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.LightSalmon;
            this.LblName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblName.Location = new System.Drawing.Point(12, 100);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(72, 23);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name:";
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxName.Location = new System.Drawing.Point(23, 126);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(283, 27);
            this.TxtBoxName.TabIndex = 1;
            this.TxtBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxName_KeyPress);
            // 
            // LblHomeAddress
            // 
            this.LblHomeAddress.AutoSize = true;
            this.LblHomeAddress.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblHomeAddress.Location = new System.Drawing.Point(12, 164);
            this.LblHomeAddress.Name = "LblHomeAddress";
            this.LblHomeAddress.Size = new System.Drawing.Size(155, 23);
            this.LblHomeAddress.TabIndex = 2;
            this.LblHomeAddress.Text = "Home Address:";
            // 
            // TxtBoxHomeAddress
            // 
            this.TxtBoxHomeAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxHomeAddress.Location = new System.Drawing.Point(23, 190);
            this.TxtBoxHomeAddress.Name = "TxtBoxHomeAddress";
            this.TxtBoxHomeAddress.Size = new System.Drawing.Size(283, 27);
            this.TxtBoxHomeAddress.TabIndex = 3;
            // 
            // LblContactNum
            // 
            this.LblContactNum.AutoSize = true;
            this.LblContactNum.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblContactNum.Location = new System.Drawing.Point(12, 225);
            this.LblContactNum.Name = "LblContactNum";
            this.LblContactNum.Size = new System.Drawing.Size(173, 23);
            this.LblContactNum.TabIndex = 4;
            this.LblContactNum.Text = "Contact Number:";
            // 
            // TxtBoxContactNum
            // 
            this.TxtBoxContactNum.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxContactNum.Location = new System.Drawing.Point(23, 251);
            this.TxtBoxContactNum.Name = "TxtBoxContactNum";
            this.TxtBoxContactNum.Size = new System.Drawing.Size(283, 27);
            this.TxtBoxContactNum.TabIndex = 5;
            this.TxtBoxContactNum.TextChanged += new System.EventHandler(this.TxtBoxContactNum_TextChanged);
            this.TxtBoxContactNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxContactNum_KeyPress);
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblGender.Location = new System.Drawing.Point(12, 303);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(85, 23);
            this.LblGender.TabIndex = 23;
            this.LblGender.Text = "Gender:";
            // 
            // RdioBtnMale
            // 
            this.RdioBtnMale.AutoSize = true;
            this.RdioBtnMale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioBtnMale.Location = new System.Drawing.Point(4, 2);
            this.RdioBtnMale.Name = "RdioBtnMale";
            this.RdioBtnMale.Size = new System.Drawing.Size(60, 23);
            this.RdioBtnMale.TabIndex = 24;
            this.RdioBtnMale.TabStop = true;
            this.RdioBtnMale.Text = "Male";
            this.RdioBtnMale.UseVisualStyleBackColor = true;
            this.RdioBtnMale.CheckedChanged += new System.EventHandler(this.RdioBtnMale_CheckedChanged);
            // 
            // RdioBtnFemale
            // 
            this.RdioBtnFemale.AutoSize = true;
            this.RdioBtnFemale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioBtnFemale.Location = new System.Drawing.Point(4, 31);
            this.RdioBtnFemale.Name = "RdioBtnFemale";
            this.RdioBtnFemale.Size = new System.Drawing.Size(74, 23);
            this.RdioBtnFemale.TabIndex = 25;
            this.RdioBtnFemale.TabStop = true;
            this.RdioBtnFemale.Text = "Female";
            this.RdioBtnFemale.UseVisualStyleBackColor = true;
            this.RdioBtnFemale.CheckedChanged += new System.EventHandler(this.RdioBtnFemale_CheckedChanged);
            // 
            // RdioBtnOtherGenders
            // 
            this.RdioBtnOtherGenders.AutoSize = true;
            this.RdioBtnOtherGenders.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioBtnOtherGenders.Location = new System.Drawing.Point(4, 60);
            this.RdioBtnOtherGenders.Name = "RdioBtnOtherGenders";
            this.RdioBtnOtherGenders.Size = new System.Drawing.Size(75, 23);
            this.RdioBtnOtherGenders.TabIndex = 28;
            this.RdioBtnOtherGenders.TabStop = true;
            this.RdioBtnOtherGenders.Text = "Others:";
            this.RdioBtnOtherGenders.UseVisualStyleBackColor = true;
            this.RdioBtnOtherGenders.CheckedChanged += new System.EventHandler(this.RdioBttonOtherGenders_CheckedChanged);
            // 
            // TxtBoxOtherGenders
            // 
            this.TxtBoxOtherGenders.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxOtherGenders.Location = new System.Drawing.Point(133, 83);
            this.TxtBoxOtherGenders.Name = "TxtBoxOtherGenders";
            this.TxtBoxOtherGenders.Size = new System.Drawing.Size(89, 27);
            this.TxtBoxOtherGenders.TabIndex = 29;
            // 
            // LblSpecify
            // 
            this.LblSpecify.AutoSize = true;
            this.LblSpecify.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSpecify.Location = new System.Drawing.Point(21, 86);
            this.LblSpecify.Name = "LblSpecify";
            this.LblSpecify.Size = new System.Drawing.Size(106, 19);
            this.LblSpecify.TabIndex = 30;
            this.LblSpecify.Text = "Please Specify:";
            // 
            // RdioBtnQ1Yes
            // 
            this.RdioBtnQ1Yes.AutoSize = true;
            this.RdioBtnQ1Yes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioBtnQ1Yes.Location = new System.Drawing.Point(8, 3);
            this.RdioBtnQ1Yes.Name = "RdioBtnQ1Yes";
            this.RdioBtnQ1Yes.Size = new System.Drawing.Size(49, 23);
            this.RdioBtnQ1Yes.TabIndex = 31;
            this.RdioBtnQ1Yes.TabStop = true;
            this.RdioBtnQ1Yes.Text = "Yes";
            this.RdioBtnQ1Yes.UseVisualStyleBackColor = true;
            // 
            // RdioBtnQ1No
            // 
            this.RdioBtnQ1No.AutoSize = true;
            this.RdioBtnQ1No.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioBtnQ1No.Location = new System.Drawing.Point(8, 32);
            this.RdioBtnQ1No.Name = "RdioBtnQ1No";
            this.RdioBtnQ1No.Size = new System.Drawing.Size(45, 23);
            this.RdioBtnQ1No.TabIndex = 32;
            this.RdioBtnQ1No.TabStop = true;
            this.RdioBtnQ1No.Text = "No";
            this.RdioBtnQ1No.UseVisualStyleBackColor = true;
            // 
            // LblQuestion1
            // 
            this.LblQuestion1.AutoSize = true;
            this.LblQuestion1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblQuestion1.Location = new System.Drawing.Point(410, 303);
            this.LblQuestion1.Name = "LblQuestion1";
            this.LblQuestion1.Size = new System.Drawing.Size(449, 19);
            this.LblQuestion1.TabIndex = 33;
            this.LblQuestion1.Text = "Are you experiencing COVID-like symptoms for the past 14 days?";
            // 
            // LblQuestion2
            // 
            this.LblQuestion2.AutoSize = true;
            this.LblQuestion2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblQuestion2.Location = new System.Drawing.Point(410, 395);
            this.LblQuestion2.Name = "LblQuestion2";
            this.LblQuestion2.Size = new System.Drawing.Size(496, 19);
            this.LblQuestion2.TabIndex = 34;
            this.LblQuestion2.Text = "Did you have contact with a COVID-positive person in the past 14 days?";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnSubmit.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSubmit.ForeColor = System.Drawing.Color.Black;
            this.BtnSubmit.Location = new System.Drawing.Point(422, 616);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(113, 36);
            this.BtnSubmit.TabIndex = 37;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // PnlGender
            // 
            this.PnlGender.Controls.Add(this.RdioBtnDidntDisclose);
            this.PnlGender.Controls.Add(this.LblSpecify);
            this.PnlGender.Controls.Add(this.TxtBoxOtherGenders);
            this.PnlGender.Controls.Add(this.RdioBtnOtherGenders);
            this.PnlGender.Controls.Add(this.RdioBtnFemale);
            this.PnlGender.Controls.Add(this.RdioBtnMale);
            this.PnlGender.Location = new System.Drawing.Point(19, 327);
            this.PnlGender.Name = "PnlGender";
            this.PnlGender.Size = new System.Drawing.Size(284, 140);
            this.PnlGender.TabIndex = 38;
            // 
            // RdioBtnDidntDisclose
            // 
            this.RdioBtnDidntDisclose.AutoSize = true;
            this.RdioBtnDidntDisclose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioBtnDidntDisclose.Location = new System.Drawing.Point(4, 114);
            this.RdioBtnDidntDisclose.Name = "RdioBtnDidntDisclose";
            this.RdioBtnDidntDisclose.Size = new System.Drawing.Size(165, 23);
            this.RdioBtnDidntDisclose.TabIndex = 31;
            this.RdioBtnDidntDisclose.TabStop = true;
            this.RdioBtnDidntDisclose.Text = "Prefer not to disclose";
            this.RdioBtnDidntDisclose.UseVisualStyleBackColor = true;
            this.RdioBtnDidntDisclose.CheckedChanged += new System.EventHandler(this.RdioBtnDidntDisclose_CheckedChanged);
            // 
            // PnlQ1YesNo
            // 
            this.PnlQ1YesNo.Controls.Add(this.RdioBtnQ1No);
            this.PnlQ1YesNo.Controls.Add(this.RdioBtnQ1Yes);
            this.PnlQ1YesNo.Location = new System.Drawing.Point(410, 327);
            this.PnlQ1YesNo.Name = "PnlQ1YesNo";
            this.PnlQ1YesNo.Size = new System.Drawing.Size(65, 63);
            this.PnlQ1YesNo.TabIndex = 39;
            // 
            // PnlQ2YesNo
            // 
            this.PnlQ2YesNo.BackColor = System.Drawing.Color.LightSalmon;
            this.PnlQ2YesNo.Controls.Add(this.RdioBtnQ2No);
            this.PnlQ2YesNo.Controls.Add(this.RdioBtnQ2Yes);
            this.PnlQ2YesNo.Location = new System.Drawing.Point(410, 422);
            this.PnlQ2YesNo.Name = "PnlQ2YesNo";
            this.PnlQ2YesNo.Size = new System.Drawing.Size(65, 63);
            this.PnlQ2YesNo.TabIndex = 40;
            // 
            // RdioBtnQ2No
            // 
            this.RdioBtnQ2No.AutoSize = true;
            this.RdioBtnQ2No.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioBtnQ2No.Location = new System.Drawing.Point(8, 34);
            this.RdioBtnQ2No.Name = "RdioBtnQ2No";
            this.RdioBtnQ2No.Size = new System.Drawing.Size(45, 23);
            this.RdioBtnQ2No.TabIndex = 38;
            this.RdioBtnQ2No.TabStop = true;
            this.RdioBtnQ2No.Text = "No";
            this.RdioBtnQ2No.UseVisualStyleBackColor = true;
            // 
            // RdioBtnQ2Yes
            // 
            this.RdioBtnQ2Yes.AutoSize = true;
            this.RdioBtnQ2Yes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioBtnQ2Yes.Location = new System.Drawing.Point(8, 5);
            this.RdioBtnQ2Yes.Name = "RdioBtnQ2Yes";
            this.RdioBtnQ2Yes.Size = new System.Drawing.Size(49, 23);
            this.RdioBtnQ2Yes.TabIndex = 37;
            this.RdioBtnQ2Yes.TabStop = true;
            this.RdioBtnQ2Yes.Text = "Yes";
            this.RdioBtnQ2Yes.UseVisualStyleBackColor = true;
            // 
            // LblMallName
            // 
            this.LblMallName.AutoSize = true;
            this.LblMallName.Font = new System.Drawing.Font("Sylfaen", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblMallName.ForeColor = System.Drawing.Color.IndianRed;
            this.LblMallName.Location = new System.Drawing.Point(0, 38);
            this.LblMallName.Name = "LblMallName";
            this.LblMallName.Size = new System.Drawing.Size(231, 62);
            this.LblMallName.TabIndex = 55;
            this.LblMallName.Text = "YGL Mall";
            // 
            // PicBoxPalmTree
            // 
            this.PicBoxPalmTree.Enabled = false;
            this.PicBoxPalmTree.Image = global::ContactTracingApp.Properties.Resources.fd6323c1bde78172ef5f9c3b509e0b2f;
            this.PicBoxPalmTree.Location = new System.Drawing.Point(237, 29);
            this.PicBoxPalmTree.Name = "PicBoxPalmTree";
            this.PicBoxPalmTree.Size = new System.Drawing.Size(84, 71);
            this.PicBoxPalmTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxPalmTree.TabIndex = 56;
            this.PicBoxPalmTree.TabStop = false;
            // 
            // MenuToolStrip
            // 
            this.MenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComboBtnSettings});
            this.MenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuToolStrip.Name = "MenuToolStrip";
            this.MenuToolStrip.Size = new System.Drawing.Size(918, 25);
            this.MenuToolStrip.TabIndex = 57;
            // 
            // ComboBtnSettings
            // 
            this.ComboBtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ComboBtnSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAccessTheDatabase});
            this.ComboBtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("ComboBtnSettings.Image")));
            this.ComboBtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ComboBtnSettings.Name = "ComboBtnSettings";
            this.ComboBtnSettings.Size = new System.Drawing.Size(32, 22);
            this.ComboBtnSettings.Text = "toolStripSplitButton1";
            this.ComboBtnSettings.ToolTipText = "Settings";
            // 
            // BtnAccessTheDatabase
            // 
            this.BtnAccessTheDatabase.Name = "BtnAccessTheDatabase";
            this.BtnAccessTheDatabase.Size = new System.Drawing.Size(391, 22);
            this.BtnAccessTheDatabase.Text = "Access the Database Containing the Informattion Submitted";
            this.BtnAccessTheDatabase.Click += new System.EventHandler(this.BtnAccessTheDatabase_Click);
            // 
            // LblQuestion3
            // 
            this.LblQuestion3.AutoSize = true;
            this.LblQuestion3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblQuestion3.Location = new System.Drawing.Point(351, 507);
            this.LblQuestion3.Name = "LblQuestion3";
            this.LblQuestion3.Size = new System.Drawing.Size(148, 19);
            this.LblQuestion3.TabIndex = 58;
            this.LblQuestion3.Text = "Are you vaccinated?";
            this.LblQuestion3.Click += new System.EventHandler(this.LblQuestion3_Click);
            // 
            // PanelQ3VaccinationQuestion
            // 
            this.PanelQ3VaccinationQuestion.BackColor = System.Drawing.Color.LightSalmon;
            this.PanelQ3VaccinationQuestion.Controls.Add(this.RdioBtnQ3YesBooster);
            this.PanelQ3VaccinationQuestion.Controls.Add(this.RdioBtnQ3No);
            this.PanelQ3VaccinationQuestion.Controls.Add(this.RdioBtnQ3YesSecondDose);
            this.PanelQ3VaccinationQuestion.Controls.Add(this.RdioBtnQ3YesFirstDose);
            this.PanelQ3VaccinationQuestion.Location = new System.Drawing.Point(353, 529);
            this.PanelQ3VaccinationQuestion.Name = "PanelQ3VaccinationQuestion";
            this.PanelQ3VaccinationQuestion.Size = new System.Drawing.Size(275, 71);
            this.PanelQ3VaccinationQuestion.TabIndex = 41;
            // 
            // RdioBtnQ3YesBooster
            // 
            this.RdioBtnQ3YesBooster.AutoSize = true;
            this.RdioBtnQ3YesBooster.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioBtnQ3YesBooster.Location = new System.Drawing.Point(160, 5);
            this.RdioBtnQ3YesBooster.Name = "RdioBtnQ3YesBooster";
            this.RdioBtnQ3YesBooster.Size = new System.Drawing.Size(107, 23);
            this.RdioBtnQ3YesBooster.TabIndex = 40;
            this.RdioBtnQ3YesBooster.TabStop = true;
            this.RdioBtnQ3YesBooster.Text = "Yes, Booster";
            this.RdioBtnQ3YesBooster.UseVisualStyleBackColor = true;
            // 
            // RdioBtnQ3No
            // 
            this.RdioBtnQ3No.AutoSize = true;
            this.RdioBtnQ3No.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioBtnQ3No.Location = new System.Drawing.Point(160, 34);
            this.RdioBtnQ3No.Name = "RdioBtnQ3No";
            this.RdioBtnQ3No.Size = new System.Drawing.Size(45, 23);
            this.RdioBtnQ3No.TabIndex = 39;
            this.RdioBtnQ3No.TabStop = true;
            this.RdioBtnQ3No.Text = "No";
            this.RdioBtnQ3No.UseVisualStyleBackColor = true;
            // 
            // RdioBtnQ3YesSecondDose
            // 
            this.RdioBtnQ3YesSecondDose.AutoSize = true;
            this.RdioBtnQ3YesSecondDose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioBtnQ3YesSecondDose.Location = new System.Drawing.Point(8, 34);
            this.RdioBtnQ3YesSecondDose.Name = "RdioBtnQ3YesSecondDose";
            this.RdioBtnQ3YesSecondDose.Size = new System.Drawing.Size(140, 23);
            this.RdioBtnQ3YesSecondDose.TabIndex = 38;
            this.RdioBtnQ3YesSecondDose.TabStop = true;
            this.RdioBtnQ3YesSecondDose.Text = "Yes, Second Dose";
            this.RdioBtnQ3YesSecondDose.UseVisualStyleBackColor = true;
            // 
            // RdioBtnQ3YesFirstDose
            // 
            this.RdioBtnQ3YesFirstDose.AutoSize = true;
            this.RdioBtnQ3YesFirstDose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioBtnQ3YesFirstDose.Location = new System.Drawing.Point(8, 5);
            this.RdioBtnQ3YesFirstDose.Name = "RdioBtnQ3YesFirstDose";
            this.RdioBtnQ3YesFirstDose.Size = new System.Drawing.Size(122, 23);
            this.RdioBtnQ3YesFirstDose.TabIndex = 37;
            this.RdioBtnQ3YesFirstDose.TabStop = true;
            this.RdioBtnQ3YesFirstDose.Text = "Yes, First Dose";
            this.RdioBtnQ3YesFirstDose.UseVisualStyleBackColor = true;
            // 
            // BtnTimeDepartedAMPM
            // 
            this.BtnTimeDepartedAMPM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnTimeDepartedAMPM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnTimeDepartedAMPM.Location = new System.Drawing.Point(546, 258);
            this.BtnTimeDepartedAMPM.Name = "BtnTimeDepartedAMPM";
            this.BtnTimeDepartedAMPM.Size = new System.Drawing.Size(46, 29);
            this.BtnTimeDepartedAMPM.TabIndex = 54;
            this.BtnTimeDepartedAMPM.Text = "AM";
            this.BtnTimeDepartedAMPM.UseVisualStyleBackColor = true;
            this.BtnTimeDepartedAMPM.Click += new System.EventHandler(this.BtnTimeDepartedAMPM_Click);
            // 
            // BtnMinuteDeparted
            // 
            this.BtnMinuteDeparted.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMinuteDeparted.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnMinuteDeparted.Location = new System.Drawing.Point(505, 258);
            this.BtnMinuteDeparted.Name = "BtnMinuteDeparted";
            this.BtnMinuteDeparted.Size = new System.Drawing.Size(35, 29);
            this.BtnMinuteDeparted.TabIndex = 50;
            this.BtnMinuteDeparted.Text = "00";
            this.BtnMinuteDeparted.UseVisualStyleBackColor = true;
            this.BtnMinuteDeparted.Click += new System.EventHandler(this.BtnMinuteDeparted_Click);
            // 
            // LblTLColon
            // 
            this.LblTLColon.AutoSize = true;
            this.LblTLColon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTLColon.Location = new System.Drawing.Point(484, 258);
            this.LblTLColon.Name = "LblTLColon";
            this.LblTLColon.Size = new System.Drawing.Size(15, 23);
            this.LblTLColon.TabIndex = 13;
            this.LblTLColon.Text = ":";
            // 
            // BtnHourDeparted
            // 
            this.BtnHourDeparted.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnHourDeparted.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnHourDeparted.Location = new System.Drawing.Point(443, 258);
            this.BtnHourDeparted.Name = "BtnHourDeparted";
            this.BtnHourDeparted.Size = new System.Drawing.Size(35, 29);
            this.BtnHourDeparted.TabIndex = 49;
            this.BtnHourDeparted.Text = "01";
            this.BtnHourDeparted.UseVisualStyleBackColor = true;
            this.BtnHourDeparted.Click += new System.EventHandler(this.BtnHourDeparted_Click);
            // 
            // LblTimeDeparted
            // 
            this.LblTimeDeparted.AutoSize = true;
            this.LblTimeDeparted.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTimeDeparted.Location = new System.Drawing.Point(410, 228);
            this.LblTimeDeparted.Name = "LblTimeDeparted";
            this.LblTimeDeparted.Size = new System.Drawing.Size(157, 23);
            this.LblTimeDeparted.TabIndex = 12;
            this.LblTimeDeparted.Text = "Time Departed:";
            // 
            // BtnTimeEnteredAMPM
            // 
            this.BtnTimeEnteredAMPM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnTimeEnteredAMPM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnTimeEnteredAMPM.Location = new System.Drawing.Point(546, 194);
            this.BtnTimeEnteredAMPM.Name = "BtnTimeEnteredAMPM";
            this.BtnTimeEnteredAMPM.Size = new System.Drawing.Size(46, 29);
            this.BtnTimeEnteredAMPM.TabIndex = 52;
            this.BtnTimeEnteredAMPM.Text = "AM";
            this.BtnTimeEnteredAMPM.UseVisualStyleBackColor = true;
            this.BtnTimeEnteredAMPM.Click += new System.EventHandler(this.BtnTimeEnteredAMPM_Click);
            // 
            // BtnMinuteEntered
            // 
            this.BtnMinuteEntered.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMinuteEntered.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnMinuteEntered.Location = new System.Drawing.Point(505, 194);
            this.BtnMinuteEntered.Name = "BtnMinuteEntered";
            this.BtnMinuteEntered.Size = new System.Drawing.Size(35, 29);
            this.BtnMinuteEntered.TabIndex = 51;
            this.BtnMinuteEntered.Text = "00";
            this.BtnMinuteEntered.UseVisualStyleBackColor = true;
            this.BtnMinuteEntered.Click += new System.EventHandler(this.BtnMinuteEntered_Click);
            // 
            // LbllTEColon
            // 
            this.LbllTEColon.AutoSize = true;
            this.LbllTEColon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbllTEColon.Location = new System.Drawing.Point(484, 194);
            this.LbllTEColon.Name = "LbllTEColon";
            this.LbllTEColon.Size = new System.Drawing.Size(15, 23);
            this.LbllTEColon.TabIndex = 9;
            this.LbllTEColon.Text = ":";
            // 
            // BtnHourEntered
            // 
            this.BtnHourEntered.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnHourEntered.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnHourEntered.Location = new System.Drawing.Point(443, 194);
            this.BtnHourEntered.Name = "BtnHourEntered";
            this.BtnHourEntered.Size = new System.Drawing.Size(35, 29);
            this.BtnHourEntered.TabIndex = 48;
            this.BtnHourEntered.Text = "01";
            this.BtnHourEntered.UseVisualStyleBackColor = true;
            this.BtnHourEntered.Click += new System.EventHandler(this.BtnHourEntered_Click);
            // 
            // LblTimeEntered
            // 
            this.LblTimeEntered.AutoSize = true;
            this.LblTimeEntered.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTimeEntered.Location = new System.Drawing.Point(410, 164);
            this.LblTimeEntered.Name = "LblTimeEntered";
            this.LblTimeEntered.Size = new System.Drawing.Size(144, 23);
            this.LblTimeEntered.TabIndex = 6;
            this.LblTimeEntered.Text = "Time Entered:";
            // 
            // LblForwardSlash2
            // 
            this.LblForwardSlash2.AutoSize = true;
            this.LblForwardSlash2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblForwardSlash2.Location = new System.Drawing.Point(574, 131);
            this.LblForwardSlash2.Name = "LblForwardSlash2";
            this.LblForwardSlash2.Size = new System.Drawing.Size(18, 23);
            this.LblForwardSlash2.TabIndex = 18;
            this.LblForwardSlash2.Text = "/";
            // 
            // TxtBoxYearVisited
            // 
            this.TxtBoxYearVisited.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxYearVisited.Location = new System.Drawing.Point(590, 130);
            this.TxtBoxYearVisited.Name = "TxtBoxYearVisited";
            this.TxtBoxYearVisited.Size = new System.Drawing.Size(59, 27);
            this.TxtBoxYearVisited.TabIndex = 20;
            this.TxtBoxYearVisited.TextChanged += new System.EventHandler(this.TxtBoxYearVisited_TextChanged);
            this.TxtBoxYearVisited.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxYearVisited_KeyPress);
            // 
            // BtnDayVisited
            // 
            this.BtnDayVisited.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDayVisited.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnDayVisited.Location = new System.Drawing.Point(542, 129);
            this.BtnDayVisited.Name = "BtnDayVisited";
            this.BtnDayVisited.Size = new System.Drawing.Size(35, 29);
            this.BtnDayVisited.TabIndex = 47;
            this.BtnDayVisited.Text = "0";
            this.BtnDayVisited.UseVisualStyleBackColor = true;
            this.BtnDayVisited.Click += new System.EventHandler(this.BtnDayVisited_Click);
            // 
            // LblForwardSlash1
            // 
            this.LblForwardSlash1.AutoSize = true;
            this.LblForwardSlash1.BackColor = System.Drawing.Color.Transparent;
            this.LblForwardSlash1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblForwardSlash1.Location = new System.Drawing.Point(529, 131);
            this.LblForwardSlash1.Name = "LblForwardSlash1";
            this.LblForwardSlash1.Size = new System.Drawing.Size(18, 23);
            this.LblForwardSlash1.TabIndex = 41;
            this.LblForwardSlash1.Text = "/";
            // 
            // BtnMonthVisited
            // 
            this.BtnMonthVisited.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMonthVisited.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnMonthVisited.Location = new System.Drawing.Point(429, 128);
            this.BtnMonthVisited.Name = "BtnMonthVisited";
            this.BtnMonthVisited.Size = new System.Drawing.Size(101, 29);
            this.BtnMonthVisited.TabIndex = 17;
            this.BtnMonthVisited.Text = "January";
            this.BtnMonthVisited.UseVisualStyleBackColor = true;
            this.BtnMonthVisited.Click += new System.EventHandler(this.BtnMonthVisited_Click);
            // 
            // LblDateVisited
            // 
            this.LblDateVisited.AutoSize = true;
            this.LblDateVisited.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDateVisited.Location = new System.Drawing.Point(410, 100);
            this.LblDateVisited.Name = "LblDateVisited";
            this.LblDateVisited.Size = new System.Drawing.Size(133, 23);
            this.LblDateVisited.TabIndex = 16;
            this.LblDateVisited.Text = "Date Visited:";
            // 
            // ContactTracingAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(918, 665);
            this.Controls.Add(this.PanelQ3VaccinationQuestion);
            this.Controls.Add(this.LblQuestion3);
            this.Controls.Add(this.MenuToolStrip);
            this.Controls.Add(this.PicBoxPalmTree);
            this.Controls.Add(this.LblMallName);
            this.Controls.Add(this.BtnTimeDepartedAMPM);
            this.Controls.Add(this.BtnTimeEnteredAMPM);
            this.Controls.Add(this.BtnMinuteEntered);
            this.Controls.Add(this.BtnMinuteDeparted);
            this.Controls.Add(this.BtnHourDeparted);
            this.Controls.Add(this.BtnHourEntered);
            this.Controls.Add(this.BtnDayVisited);
            this.Controls.Add(this.LblForwardSlash1);
            this.Controls.Add(this.PnlQ2YesNo);
            this.Controls.Add(this.PnlQ1YesNo);
            this.Controls.Add(this.PnlGender);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.LblQuestion2);
            this.Controls.Add(this.LblQuestion1);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.TxtBoxYearVisited);
            this.Controls.Add(this.LblForwardSlash2);
            this.Controls.Add(this.BtnMonthVisited);
            this.Controls.Add(this.LblDateVisited);
            this.Controls.Add(this.LblTLColon);
            this.Controls.Add(this.LblTimeDeparted);
            this.Controls.Add(this.LbllTEColon);
            this.Controls.Add(this.LblTimeEntered);
            this.Controls.Add(this.TxtBoxContactNum);
            this.Controls.Add(this.LblContactNum);
            this.Controls.Add(this.TxtBoxHomeAddress);
            this.Controls.Add(this.LblHomeAddress);
            this.Controls.Add(this.TxtBoxName);
            this.Controls.Add(this.LblName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ContactTracingAppForm";
            this.Text = "YGL Mall Contact Tracing Form";
            this.Load += new System.EventHandler(this.ContactTracingAppForm_Load);
            this.PnlGender.ResumeLayout(false);
            this.PnlGender.PerformLayout();
            this.PnlQ1YesNo.ResumeLayout(false);
            this.PnlQ1YesNo.PerformLayout();
            this.PnlQ2YesNo.ResumeLayout(false);
            this.PnlQ2YesNo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPalmTree)).EndInit();
            this.MenuToolStrip.ResumeLayout(false);
            this.MenuToolStrip.PerformLayout();
            this.PanelQ3VaccinationQuestion.ResumeLayout(false);
            this.PanelQ3VaccinationQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblName;
        private TextBox TxtBoxName;
        private Label LblHomeAddress;
        private TextBox TxtBoxHomeAddress;
        private Label LblContactNum;
        private TextBox TxtBoxContactNum;
        private Label LblGender;
        private RadioButton RdioBtnMale;
        private RadioButton RdioBtnFemale;
        private RadioButton RdioBtnOtherGenders;
        private TextBox TxtBoxOtherGenders;
        private Label LblSpecify;
        private RadioButton RdioBtnQ1Yes;
        private RadioButton RdioBtnQ1No;
        private Label LblQuestion1;
        private Label LblQuestion2;
        private Button BtnSubmit;
        private Panel PnlGender;
        private Panel PnlQ1YesNo;
        private Panel PnlQ2YesNo;
        private RadioButton RdioBtnQ2No;
        private RadioButton RdioBtnQ2Yes;
        private Label LblMallName;
        private PictureBox PicBoxPalmTree;
        private RadioButton RdioBtnDidntDisclose;
        private ToolStrip MenuToolStrip;
        private ToolStripSplitButton ComboBtnSettings;
        private ToolStripMenuItem BtnAccessTheDatabase;
        private Label LblQuestion3;
        private Panel PanelQ3VaccinationQuestion;
        private RadioButton RdioBtnQ3YesSecondDose;
        private RadioButton RdioBtnQ3YesFirstDose;
        private Button BtnTimeDepartedAMPM;
        private Button BtnMinuteDeparted;
        private Label LblTLColon;
        private Button BtnHourDeparted;
        private Label LblTimeDeparted;
        private Button BtnTimeEnteredAMPM;
        private Button BtnMinuteEntered;
        private Label LbllTEColon;
        private Button BtnHourEntered;
        private Label LblTimeEntered;
        private Label LblForwardSlash2;
        private TextBox TxtBoxYearVisited;
        private Button BtnDayVisited;
        private Label LblForwardSlash1;
        private Button BtnMonthVisited;
        private Label LblDateVisited;
        private RadioButton RdioBtnQ3YesBooster;
        private RadioButton RdioBtnQ3No;
    }
}