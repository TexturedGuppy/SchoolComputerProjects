namespace OrderForm
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.MaskedTextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.chkOvernight = new System.Windows.Forms.CheckBox();
            this.radSigYes = new System.Windows.Forms.RadioButton();
            this.radSigNo = new System.Windows.Forms.RadioButton();
            this.radDonYes = new System.Windows.Forms.RadioButton();
            this.radDonNo = new System.Windows.Forms.RadioButton();
            this.lblDon = new System.Windows.Forms.Label();
            this.lblSig = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tipToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.calDatePicker = new System.Windows.Forms.MonthCalendar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(580, 358);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.TabStop = false;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(92, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Customer Order Form";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(217, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(173, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(12, 72);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(120, 173);
            this.lstCustomers.TabIndex = 4;
            this.lstCustomers.TabStop = false;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(217, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "&Add Customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(181, 101);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(217, 98);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 1;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            this.txtCity.Leave += new System.EventHandler(this.txtCity_Leave);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(173, 127);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "State:";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(217, 124);
            this.txtState.Mask = "LL";
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 2;
            this.txtState.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtState_MaskInputRejected);
            this.txtState.TextChanged += new System.EventHandler(this.txtState_TextChanged);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(173, 39);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(41, 13);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "label1";
            this.lblError.Visible = false;
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "US - United States",
            "AD - Andorra",
            "AE - United Arab Emirates",
            "AF - Afghanistan",
            "AG - Antigua and Barbuda",
            "AI - Anguilla",
            "AL - Albania",
            "AM - Armenia",
            "AO - Angola",
            "AQ - Antarctica",
            "AR - Argentina",
            "AS - American Samoa",
            "AT - Austria",
            "AU - Australia",
            "AW - Aruba",
            "AZ - Azerbaijan",
            "BA - Bosnia and Herzegovina",
            "BB - Barbados",
            "BD - Bangladesh",
            "BE - Belgium",
            "BF - Burkina Faso",
            "BG - Bulgaria",
            "BH - Bahrain",
            "BI - Burundi",
            "BJ - Benin",
            "BL - Saint Barthelemy",
            "BM - Bermuda",
            "BN - Brunei",
            "BO - Bolivia",
            "BR - Brazil",
            "BS - Bahamas, The",
            "BT - Bhutan",
            "BV - Bouvet Island",
            "BW - Botswana",
            "BY - Belarus",
            "BZ - Belize",
            "CA - Canada",
            "CC - Cocos (Keeling) Islands",
            "CD - Congo, Democratic Republic of the",
            "CF - Central African Republic",
            "CG - Congo, Republic of the",
            "CH - Switzerland",
            "CI - Cote d\'Ivoire",
            "CK - Cook Islands",
            "CL - Chile",
            "CM - Cameroon",
            "CN - China",
            "CO - Colombia",
            "CR - Costa Rica",
            "CU - Cuba",
            "CV - Cape Verde",
            "CW - Curacao",
            "CX - Christmas Island",
            "CY - Cyprus",
            "CZ - Czech Republic",
            "DE - Germany",
            "DJ - Djibouti",
            "DK - Denmark",
            "DM - Dominica",
            "DO - Dominican Republic",
            "DZ - Algeria",
            "EC - Ecuador",
            "EE - Estonia",
            "EG - Egypt",
            "EH - Western Sahara",
            "ER - Eritrea",
            "ES - Spain",
            "ET - Ethiopia",
            "FI - Finland",
            "FJ - Fiji",
            "FK - Falkland Islands (Islas Malvinas)",
            "FM - Micronesia, Federated States of",
            "FO - Faroe Islands",
            "FR - France",
            "FX - France, Metropolitan",
            "GA - Gabon",
            "GB - United Kingdom",
            "GD - Grenada",
            "GE - Georgia",
            "GF - French Guiana",
            "GG - Guernsey",
            "GH - Ghana",
            "GI - Gibraltar",
            "GL - Greenland",
            "GM - Gambia, The",
            "GN - Guinea",
            "GP - Guadeloupe",
            "GQ - Equatorial Guinea",
            "GR - Greece",
            "GS - South Georgia and the Islands",
            "GT - Guatemala",
            "GU - Guam",
            "GW - Guinea-Bissau",
            "GY - Guyana",
            "HK - Hong Kong",
            "HM - Heard Island and McDonald Islands",
            "HN - Honduras",
            "HR - Croatia",
            "HT - Haiti",
            "HU - Hungary",
            "ID - Indonesia",
            "IE - Ireland",
            "IL - Israel",
            "IM - Isle of Man",
            "IN - India",
            "IO - British Indian Ocean Territory",
            "IQ - Iraq",
            "IR - Iran",
            "IS - Iceland",
            "IT - Italy",
            "JE - Jersey",
            "JM - Jamaica",
            "JO - Jordan",
            "JP - Japan",
            "KE - Kenya",
            "KG - Kyrgyzstan",
            "KH - Cambodia",
            "KI - Kiribati",
            "KM - Comoros",
            "KN - Saint Kitts and Nevis",
            "KP - Korea, North",
            "KR - Korea, South",
            "KW - Kuwait",
            "KY - Cayman Islands",
            "KZ - Kazakhstan",
            "LA - Laos",
            "LB - Lebanon",
            "LC - Saint Lucia",
            "LI - Liechtenstein",
            "LK - Sri Lanka",
            "LR - Liberia",
            "LS - Lesotho",
            "LT - Lithuania",
            "LU - Luxembourg",
            "LV - Latvia",
            "LY - Libya",
            "MA - Morocco",
            "MC - Monaco",
            "MD - Moldova",
            "ME - Montenegro",
            "MF - Saint Martin",
            "MG - Madagascar",
            "MH - Marshall Islands",
            "MK - Macedonia",
            "ML - Mali",
            "MM - Burma",
            "MN - Mongolia",
            "MO - Macau",
            "MP - Northern Mariana Islands",
            "MQ - Martinique",
            "MR - Mauritania",
            "MS - Montserrat",
            "MT - Malta",
            "MU - Mauritius",
            "MV - Maldives",
            "MW - Malawi",
            "MX - Mexico",
            "MY - Malaysia",
            "MZ - Mozambique",
            "NA - Namibia",
            "NC - New Caledonia",
            "NE - Niger",
            "NF - Norfolk Island",
            "NG - Nigeria",
            "NI - Nicaragua",
            "NL - Netherlands",
            "NO - Norway",
            "NP - Nepal",
            "NR - Nauru",
            "NU - Niue",
            "NZ - New Zealand",
            "OM - Oman",
            "PA - Panama",
            "PE - Peru",
            "PF - French Polynesia",
            "PG - Papua New Guinea",
            "PH - Philippines",
            "PK - Pakistan",
            "PL - Poland",
            "PM - Saint Pierre and Miquelon",
            "PN - Pitcairn Islands",
            "PR - Puerto Rico",
            "PS - Gaza Strip",
            "PS - West Bank",
            "PT - Portugal",
            "PW - Palau",
            "PY - Paraguay",
            "QA - Qatar",
            "RE - Reunion",
            "RO - Romania",
            "RS - Serbia",
            "RU - Russia",
            "RW - Rwanda",
            "SA - Saudi Arabia",
            "SB - Solomon Islands",
            "SC - Seychelles",
            "SD - Sudan",
            "SE - Sweden",
            "SG - Singapore",
            "SH - Saint Helena, Ascension, and Tristan da Cunha",
            "SI - Slovenia",
            "SJ - Svalbard",
            "SK - Slovakia",
            "SL - Sierra Leone",
            "SM - San Marino",
            "SN - Senegal",
            "SO - Somalia",
            "SR - Suriname",
            "SS - South Sudan",
            "ST - Sao Tome and Principe",
            "SV - El Salvador",
            "SX - Sint Maarten",
            "SY - Syria",
            "SZ - Swaziland",
            "TC - Turks and Caicos Islands",
            "TD - Chad",
            "TF - French Southern and Antarctic Lands",
            "TG - Togo",
            "TH - Thailand",
            "TJ - Tajikistan",
            "TK - Tokelau",
            "TL - Timor-Leste",
            "TM - Turkmenistan",
            "TN - Tunisia",
            "TO - Tonga",
            "TR - Turkey",
            "TT - Trinidad and Tobago",
            "TV - Tuvalu",
            "TW - Taiwan",
            "TZ - Tanzania",
            "UA - Ukraine",
            "UG - Uganda",
            "UM - United States Minor Outlying Islands",
            "UY - Uruguay",
            "UZ - Uzbekistan",
            "VA - Holy See (Vatican City)",
            "VC - Saint Vincent and the Grenadines",
            "VE - Venezuela",
            "VG - British Virgin Islands",
            "VI - Virgin Islands",
            "VN - Vietnam",
            "VU - Vanuatu",
            "WF - Wallis and Futuna",
            "WS - Samoa",
            "XK - Kosovo",
            "YE - Yemen",
            "YT - Mayotte",
            "ZA - South Africa",
            "ZM - Zambia",
            "ZW - Zimbabwe"});
            this.cmbCountry.Location = new System.Drawing.Point(217, 150);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(155, 21);
            this.cmbCountry.TabIndex = 11;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(165, 153);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 12;
            this.lblCountry.Text = "Country:";
            // 
            // chkOvernight
            // 
            this.chkOvernight.AutoSize = true;
            this.chkOvernight.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkOvernight.Location = new System.Drawing.Point(168, 177);
            this.chkOvernight.Name = "chkOvernight";
            this.chkOvernight.Size = new System.Drawing.Size(113, 17);
            this.chkOvernight.TabIndex = 13;
            this.chkOvernight.Text = "Overnight Delivery";
            this.chkOvernight.UseVisualStyleBackColor = true;
            this.chkOvernight.CheckedChanged += new System.EventHandler(this.chkOvernight_CheckedChanged);
            // 
            // radSigYes
            // 
            this.radSigYes.AutoSize = true;
            this.radSigYes.Location = new System.Drawing.Point(40, 55);
            this.radSigYes.Name = "radSigYes";
            this.radSigYes.Size = new System.Drawing.Size(43, 17);
            this.radSigYes.TabIndex = 14;
            this.radSigYes.TabStop = true;
            this.radSigYes.Text = "Yes";
            this.radSigYes.UseVisualStyleBackColor = true;
            // 
            // radSigNo
            // 
            this.radSigNo.AutoSize = true;
            this.radSigNo.Location = new System.Drawing.Point(40, 77);
            this.radSigNo.Name = "radSigNo";
            this.radSigNo.Size = new System.Drawing.Size(39, 17);
            this.radSigNo.TabIndex = 15;
            this.radSigNo.TabStop = true;
            this.radSigNo.Text = "No";
            this.radSigNo.UseVisualStyleBackColor = true;
            // 
            // radDonYes
            // 
            this.radDonYes.AutoSize = true;
            this.radDonYes.Location = new System.Drawing.Point(46, 44);
            this.radDonYes.Name = "radDonYes";
            this.radDonYes.Size = new System.Drawing.Size(43, 17);
            this.radDonYes.TabIndex = 16;
            this.radDonYes.TabStop = true;
            this.radDonYes.Text = "Yes";
            this.radDonYes.UseVisualStyleBackColor = true;
            // 
            // radDonNo
            // 
            this.radDonNo.AutoSize = true;
            this.radDonNo.Location = new System.Drawing.Point(46, 67);
            this.radDonNo.Name = "radDonNo";
            this.radDonNo.Size = new System.Drawing.Size(39, 17);
            this.radDonNo.TabIndex = 17;
            this.radDonNo.TabStop = true;
            this.radDonNo.Text = "No";
            this.radDonNo.UseVisualStyleBackColor = true;
            // 
            // lblDon
            // 
            this.lblDon.AutoSize = true;
            this.lblDon.Location = new System.Drawing.Point(11, 28);
            this.lblDon.Name = "lblDon";
            this.lblDon.Size = new System.Drawing.Size(78, 13);
            this.lblDon.TabIndex = 18;
            this.lblDon.Text = "Add Donation?";
            // 
            // lblSig
            // 
            this.lblSig.AutoSize = true;
            this.lblSig.Location = new System.Drawing.Point(49, 39);
            this.lblSig.Name = "lblSig";
            this.lblSig.Size = new System.Drawing.Size(97, 13);
            this.lblSig.TabIndex = 19;
            this.lblSig.Text = "Ask For Signature?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSigYes);
            this.groupBox1.Controls.Add(this.lblSig);
            this.groupBox1.Controls.Add(this.radSigNo);
            this.groupBox1.Location = new System.Drawing.Point(123, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDon);
            this.groupBox2.Controls.Add(this.radDonYes);
            this.groupBox2.Controls.Add(this.radDonNo);
            this.groupBox2.Location = new System.Drawing.Point(123, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.Location = new System.Drawing.Point(0, 3);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(120, 212);
            this.lstOrders.TabIndex = 22;
            this.lstOrders.TabStop = false;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(248, 227);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 23;
            this.btnOrder.Text = "Add Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // pnlOrder
            // 
            this.pnlOrder.Controls.Add(this.calDatePicker);
            this.pnlOrder.Controls.Add(this.lstOrders);
            this.pnlOrder.Controls.Add(this.btnOrder);
            this.pnlOrder.Controls.Add(this.groupBox1);
            this.pnlOrder.Controls.Add(this.groupBox2);
            this.pnlOrder.Location = new System.Drawing.Point(378, 39);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(561, 253);
            this.pnlOrder.TabIndex = 24;
            // 
            // calDatePicker
            // 
            this.calDatePicker.Location = new System.Drawing.Point(325, 53);
            this.calDatePicker.Name = "calDatePicker";
            this.calDatePicker.TabIndex = 24;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(942, 393);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.chkOvernight);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnQuit);
            this.Name = "frmMain";
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlOrder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.MaskedTextBox txtState;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.CheckBox chkOvernight;
        private System.Windows.Forms.RadioButton radSigYes;
        private System.Windows.Forms.RadioButton radSigNo;
        private System.Windows.Forms.RadioButton radDonYes;
        private System.Windows.Forms.RadioButton radDonNo;
        private System.Windows.Forms.Label lblDon;
        private System.Windows.Forms.Label lblSig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip tipToolTip;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.MonthCalendar calDatePicker;
    }
}

