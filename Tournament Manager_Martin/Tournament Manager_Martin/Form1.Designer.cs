namespace Tournament_Manager_Martin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHead = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbCreatedby = new System.Windows.Forms.TextBox();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.tbContactNumber = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbAddressLine2 = new System.Windows.Forms.TextBox();
            this.tbAddressLine1 = new System.Windows.Forms.TextBox();
            this.tbTeamID = new System.Windows.Forms.TextBox();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblCreatedby = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblTeamID = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbCreatedby2 = new System.Windows.Forms.TextBox();
            this.tbDirector2 = new System.Windows.Forms.TextBox();
            this.tbEmail2 = new System.Windows.Forms.TextBox();
            this.tbPostalCode2 = new System.Windows.Forms.TextBox();
            this.tbContactNumber2 = new System.Windows.Forms.TextBox();
            this.tbCity2 = new System.Windows.Forms.TextBox();
            this.tbAddressLine4 = new System.Windows.Forms.TextBox();
            this.tbAddressLine3 = new System.Windows.Forms.TextBox();
            this.tbTeamID2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCoach = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.tbTeamName = new System.Windows.Forms.TextBox();
            this.tbCoach = new System.Windows.Forms.TextBox();
            this.lblOK = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbTeamsExport = new System.Windows.Forms.ListBox();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblErrorSearch = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblExport = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(13, 13);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(318, 25);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Tournament Management Team";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(221, 172);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(253, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(18, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(310, 227);
            this.tabControl1.TabIndex = 99;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblOK);
            this.tabPage1.Controls.Add(this.lblError);
            this.tabPage1.Controls.Add(this.btnCreate);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.tbCreatedby);
            this.tabPage1.Controls.Add(this.tbDirector);
            this.tabPage1.Controls.Add(this.tbEmail);
            this.tabPage1.Controls.Add(this.tbPostalCode);
            this.tabPage1.Controls.Add(this.tbContactNumber);
            this.tabPage1.Controls.Add(this.tbCity);
            this.tabPage1.Controls.Add(this.tbAddressLine2);
            this.tabPage1.Controls.Add(this.tbAddressLine1);
            this.tabPage1.Controls.Add(this.tbTeamID);
            this.tabPage1.Controls.Add(this.lblAddressLine2);
            this.tabPage1.Controls.Add(this.lblCreatedby);
            this.tabPage1.Controls.Add(this.lblDirector);
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.lblPostalCode);
            this.tabPage1.Controls.Add(this.lblContactNumber);
            this.tabPage1.Controls.Add(this.lblCity);
            this.tabPage1.Controls.Add(this.lblAddressLine1);
            this.tabPage1.Controls.Add(this.lblTeamID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(302, 201);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(137, 168);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(218, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "C&lear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // tbCreatedby
            // 
            this.tbCreatedby.Location = new System.Drawing.Point(211, 127);
            this.tbCreatedby.Name = "tbCreatedby";
            this.tbCreatedby.Size = new System.Drawing.Size(82, 20);
            this.tbCreatedby.TabIndex = 11;
            // 
            // tbDirector
            // 
            this.tbDirector.Location = new System.Drawing.Point(110, 127);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(82, 20);
            this.tbDirector.TabIndex = 10;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(7, 127);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(82, 20);
            this.tbEmail.TabIndex = 9;
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(211, 79);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(82, 20);
            this.tbPostalCode.TabIndex = 8;
            // 
            // tbContactNumber
            // 
            this.tbContactNumber.Location = new System.Drawing.Point(111, 79);
            this.tbContactNumber.Name = "tbContactNumber";
            this.tbContactNumber.Size = new System.Drawing.Size(82, 20);
            this.tbContactNumber.TabIndex = 7;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(7, 79);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(82, 20);
            this.tbCity.TabIndex = 6;
            // 
            // tbAddressLine2
            // 
            this.tbAddressLine2.Location = new System.Drawing.Point(211, 31);
            this.tbAddressLine2.Name = "tbAddressLine2";
            this.tbAddressLine2.Size = new System.Drawing.Size(82, 20);
            this.tbAddressLine2.TabIndex = 5;
            // 
            // tbAddressLine1
            // 
            this.tbAddressLine1.Location = new System.Drawing.Point(110, 31);
            this.tbAddressLine1.Name = "tbAddressLine1";
            this.tbAddressLine1.Size = new System.Drawing.Size(82, 20);
            this.tbAddressLine1.TabIndex = 4;
            // 
            // tbTeamID
            // 
            this.tbTeamID.Location = new System.Drawing.Point(7, 31);
            this.tbTeamID.Name = "tbTeamID";
            this.tbTeamID.Size = new System.Drawing.Size(82, 20);
            this.tbTeamID.TabIndex = 3;
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(215, 14);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(54, 13);
            this.lblAddressLine2.TabIndex = 9;
            this.lblAddressLine2.Text = "Address 2";
            // 
            // lblCreatedby
            // 
            this.lblCreatedby.AutoSize = true;
            this.lblCreatedby.Location = new System.Drawing.Point(215, 111);
            this.lblCreatedby.Name = "lblCreatedby";
            this.lblCreatedby.Size = new System.Drawing.Size(58, 13);
            this.lblCreatedby.TabIndex = 8;
            this.lblCreatedby.Text = "Created by";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(108, 111);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(44, 13);
            this.lblDirector.TabIndex = 7;
            this.lblDirector.Text = "Director";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 111);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(215, 63);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(64, 13);
            this.lblPostalCode.TabIndex = 5;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(108, 63);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 4;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(7, 63);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(108, 14);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(54, 13);
            this.lblAddressLine1.TabIndex = 1;
            this.lblAddressLine1.Text = "Address 1";
            // 
            // lblTeamID
            // 
            this.lblTeamID.AutoSize = true;
            this.lblTeamID.Location = new System.Drawing.Point(7, 14);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(48, 13);
            this.lblTeamID.TabIndex = 0;
            this.lblTeamID.Text = "Team ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.lblErrorSearch);
            this.tabPage2.Controls.Add(this.btnClear2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.tbCreatedby2);
            this.tabPage2.Controls.Add(this.tbDirector2);
            this.tabPage2.Controls.Add(this.tbEmail2);
            this.tabPage2.Controls.Add(this.tbPostalCode2);
            this.tabPage2.Controls.Add(this.tbContactNumber2);
            this.tabPage2.Controls.Add(this.tbCity2);
            this.tabPage2.Controls.Add(this.tbAddressLine4);
            this.tabPage2.Controls.Add(this.tbAddressLine3);
            this.tabPage2.Controls.Add(this.tbTeamID2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(302, 201);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "City";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(137, 168);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // tbCreatedby2
            // 
            this.tbCreatedby2.Location = new System.Drawing.Point(211, 127);
            this.tbCreatedby2.Name = "tbCreatedby2";
            this.tbCreatedby2.Size = new System.Drawing.Size(82, 20);
            this.tbCreatedby2.TabIndex = 11;
            // 
            // tbDirector2
            // 
            this.tbDirector2.Location = new System.Drawing.Point(110, 127);
            this.tbDirector2.Name = "tbDirector2";
            this.tbDirector2.Size = new System.Drawing.Size(82, 20);
            this.tbDirector2.TabIndex = 10;
            // 
            // tbEmail2
            // 
            this.tbEmail2.Location = new System.Drawing.Point(7, 127);
            this.tbEmail2.Name = "tbEmail2";
            this.tbEmail2.Size = new System.Drawing.Size(82, 20);
            this.tbEmail2.TabIndex = 9;
            // 
            // tbPostalCode2
            // 
            this.tbPostalCode2.Location = new System.Drawing.Point(211, 79);
            this.tbPostalCode2.Name = "tbPostalCode2";
            this.tbPostalCode2.Size = new System.Drawing.Size(82, 20);
            this.tbPostalCode2.TabIndex = 24;
            // 
            // tbContactNumber2
            // 
            this.tbContactNumber2.Location = new System.Drawing.Point(111, 79);
            this.tbContactNumber2.Name = "tbContactNumber2";
            this.tbContactNumber2.Size = new System.Drawing.Size(82, 20);
            this.tbContactNumber2.TabIndex = 23;
            // 
            // tbCity2
            // 
            this.tbCity2.Location = new System.Drawing.Point(7, 79);
            this.tbCity2.Name = "tbCity2";
            this.tbCity2.Size = new System.Drawing.Size(82, 20);
            this.tbCity2.TabIndex = 21;
            // 
            // tbAddressLine4
            // 
            this.tbAddressLine4.Location = new System.Drawing.Point(211, 31);
            this.tbAddressLine4.Name = "tbAddressLine4";
            this.tbAddressLine4.Size = new System.Drawing.Size(82, 20);
            this.tbAddressLine4.TabIndex = 20;
            // 
            // tbAddressLine3
            // 
            this.tbAddressLine3.Location = new System.Drawing.Point(110, 31);
            this.tbAddressLine3.Name = "tbAddressLine3";
            this.tbAddressLine3.Size = new System.Drawing.Size(82, 20);
            this.tbAddressLine3.TabIndex = 18;
            // 
            // tbTeamID2
            // 
            this.tbTeamID2.Location = new System.Drawing.Point(7, 31);
            this.tbTeamID2.Name = "tbTeamID2";
            this.tbTeamID2.Size = new System.Drawing.Size(82, 20);
            this.tbTeamID2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Address 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Created by";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Director";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Postal Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Contact Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Address 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Team ID";
            // 
            // lblCoach
            // 
            this.lblCoach.AutoSize = true;
            this.lblCoach.Location = new System.Drawing.Point(20, 74);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(41, 13);
            this.lblCoach.TabIndex = 4;
            this.lblCoach.Text = "Coach:";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(19, 52);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(68, 13);
            this.lblTeamName.TabIndex = 3;
            this.lblTeamName.Text = "Team Name:";
            // 
            // tbTeamName
            // 
            this.tbTeamName.Location = new System.Drawing.Point(90, 49);
            this.tbTeamName.Name = "tbTeamName";
            this.tbTeamName.Size = new System.Drawing.Size(100, 20);
            this.tbTeamName.TabIndex = 1;
            // 
            // tbCoach
            // 
            this.tbCoach.Location = new System.Drawing.Point(90, 71);
            this.tbCoach.Name = "tbCoach";
            this.tbCoach.Size = new System.Drawing.Size(100, 20);
            this.tbCoach.TabIndex = 2;
            // 
            // lblOK
            // 
            this.lblOK.AutoSize = true;
            this.lblOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOK.ForeColor = System.Drawing.Color.Green;
            this.lblOK.Location = new System.Drawing.Point(7, 178);
            this.lblOK.Name = "lblOK";
            this.lblOK.Size = new System.Drawing.Size(0, 13);
            this.lblOK.TabIndex = 37;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(7, 159);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 36;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblExport);
            this.tabPage3.Controls.Add(this.btnGenerate);
            this.tabPage3.Controls.Add(this.lbTeamsExport);
            this.tabPage3.Controls.Add(this.btnExport);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(302, 201);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Export";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbTeamsExport
            // 
            this.lbTeamsExport.FormattingEnabled = true;
            this.lbTeamsExport.Location = new System.Drawing.Point(7, 7);
            this.lbTeamsExport.Name = "lbTeamsExport";
            this.lbTeamsExport.Size = new System.Drawing.Size(289, 160);
            this.lbTeamsExport.TabIndex = 15;
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(218, 168);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(75, 23);
            this.btnClear2.TabIndex = 34;
            this.btnClear2.Text = "C&lear";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.BtnClear2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(7, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 39;
            // 
            // lblErrorSearch
            // 
            this.lblErrorSearch.AutoSize = true;
            this.lblErrorSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSearch.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSearch.Location = new System.Drawing.Point(7, 159);
            this.lblErrorSearch.Name = "lblErrorSearch";
            this.lblErrorSearch.Size = new System.Drawing.Size(0, 13);
            this.lblErrorSearch.TabIndex = 38;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(140, 172);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 100;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExport.ForeColor = System.Drawing.Color.Green;
            this.lblExport.Location = new System.Drawing.Point(7, 178);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(0, 13);
            this.lblExport.TabIndex = 101;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 380);
            this.Controls.Add(this.tbCoach);
            this.Controls.Add(this.tbTeamName);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblCoach);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHead);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblCreatedby;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblTeamID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbCreatedby;
        private System.Windows.Forms.TextBox tbDirector;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.TextBox tbContactNumber;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbAddressLine2;
        private System.Windows.Forms.TextBox tbAddressLine1;
        private System.Windows.Forms.TextBox tbTeamID;
        private System.Windows.Forms.Label lblCoach;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.TextBox tbTeamName;
        private System.Windows.Forms.TextBox tbCoach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbCreatedby2;
        private System.Windows.Forms.TextBox tbDirector2;
        private System.Windows.Forms.TextBox tbEmail2;
        private System.Windows.Forms.TextBox tbPostalCode2;
        private System.Windows.Forms.TextBox tbContactNumber2;
        private System.Windows.Forms.TextBox tbCity2;
        private System.Windows.Forms.TextBox tbAddressLine4;
        private System.Windows.Forms.TextBox tbAddressLine3;
        private System.Windows.Forms.TextBox tbTeamID2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOK;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lbTeamsExport;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblErrorSearch;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblExport;
    }
}

