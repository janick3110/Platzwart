namespace Vereinsmanager
{
    partial class Spielermodul
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
            this.cbJugendSelector = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblVorname = new System.Windows.Forms.Label();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.lNachname = new System.Windows.Forms.Label();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.lBirthday = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lStreet = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudHouseNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudZipCode = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTeam = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.btnCreatePlayer = new System.Windows.Forms.Button();
            this.btnEditPlayer = new System.Windows.Forms.Button();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.Aktiv = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Geburtstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Strasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefonnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAutoImport = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHouseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZipCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // cbJugendSelector
            // 
            this.cbJugendSelector.FormattingEnabled = true;
            this.cbJugendSelector.Items.AddRange(new object[] {
            "A-Jugend",
            "Archiv",
            "B-Jugend",
            "Bambini",
            "C-Jugend",
            "D-Jugend",
            "E-Jugend",
            "F-Jugend"});
            this.cbJugendSelector.Location = new System.Drawing.Point(13, 13);
            this.cbJugendSelector.Name = "cbJugendSelector";
            this.cbJugendSelector.Size = new System.Drawing.Size(306, 21);
            this.cbJugendSelector.Sorted = true;
            this.cbJugendSelector.TabIndex = 0;
            this.cbJugendSelector.SelectedValueChanged += new System.EventHandler(this.cbJugendSelector_SelectedValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblVorname);
            this.flowLayoutPanel1.Controls.Add(this.tbFirstname);
            this.flowLayoutPanel1.Controls.Add(this.lNachname);
            this.flowLayoutPanel1.Controls.Add(this.tbLastname);
            this.flowLayoutPanel1.Controls.Add(this.lBirthday);
            this.flowLayoutPanel1.Controls.Add(this.dtpBirthday);
            this.flowLayoutPanel1.Controls.Add(this.lStreet);
            this.flowLayoutPanel1.Controls.Add(this.tbStreet);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.nudHouseNumber);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.tbCity);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.nudZipCode);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.tbTelephone);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.tbMail);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.cbTeam);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.cbActive);
            this.flowLayoutPanel1.Controls.Add(this.btnCreatePlayer);
            this.flowLayoutPanel1.Controls.Add(this.btnEditPlayer);
            this.flowLayoutPanel1.Controls.Add(this.btnDeletePlayer);
            this.flowLayoutPanel1.Controls.Add(this.btnAutoImport);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(306, 550);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Location = new System.Drawing.Point(3, 0);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(49, 13);
            this.lblVorname.TabIndex = 0;
            this.lblVorname.Text = "Vorname";
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(3, 16);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(296, 20);
            this.tbFirstname.TabIndex = 1;
            // 
            // lNachname
            // 
            this.lNachname.AutoSize = true;
            this.lNachname.Location = new System.Drawing.Point(3, 39);
            this.lNachname.Name = "lNachname";
            this.lNachname.Size = new System.Drawing.Size(59, 13);
            this.lNachname.TabIndex = 2;
            this.lNachname.Text = "Nachname";
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(3, 55);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(296, 20);
            this.tbLastname.TabIndex = 3;
            // 
            // lBirthday
            // 
            this.lBirthday.AutoSize = true;
            this.lBirthday.Location = new System.Drawing.Point(3, 78);
            this.lBirthday.Name = "lBirthday";
            this.lBirthday.Size = new System.Drawing.Size(59, 13);
            this.lBirthday.TabIndex = 4;
            this.lBirthday.Text = "Geburtstag";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(3, 94);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(296, 20);
            this.dtpBirthday.TabIndex = 5;
            // 
            // lStreet
            // 
            this.lStreet.AutoSize = true;
            this.lStreet.Location = new System.Drawing.Point(3, 117);
            this.lStreet.Name = "lStreet";
            this.lStreet.Size = new System.Drawing.Size(38, 13);
            this.lStreet.TabIndex = 6;
            this.lStreet.Text = "Straße";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(3, 133);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(296, 20);
            this.tbStreet.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hausnummer";
            // 
            // nudHouseNumber
            // 
            this.nudHouseNumber.Location = new System.Drawing.Point(3, 172);
            this.nudHouseNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudHouseNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHouseNumber.Name = "nudHouseNumber";
            this.nudHouseNumber.Size = new System.Drawing.Size(120, 20);
            this.nudHouseNumber.TabIndex = 12;
            this.nudHouseNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ort";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(3, 211);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(296, 20);
            this.tbCity.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Postleitzahl";
            // 
            // nudZipCode
            // 
            this.nudZipCode.Location = new System.Drawing.Point(3, 250);
            this.nudZipCode.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudZipCode.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudZipCode.Name = "nudZipCode";
            this.nudZipCode.Size = new System.Drawing.Size(120, 20);
            this.nudZipCode.TabIndex = 14;
            this.nudZipCode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefon";
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(3, 289);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(296, 20);
            this.tbTelephone.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "E-Mail";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(3, 328);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(296, 20);
            this.tbMail.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Jugend";
            // 
            // cbTeam
            // 
            this.cbTeam.FormattingEnabled = true;
            this.cbTeam.Items.AddRange(new object[] {
            "A-Jugend",
            "Archiv",
            "B-Jugend",
            "Bambini",
            "C-Jugend",
            "D-Jugend",
            "E-Jugend",
            "F-Jugend"});
            this.cbTeam.Location = new System.Drawing.Point(3, 367);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Size = new System.Drawing.Size(296, 21);
            this.cbTeam.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Aktiv";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(3, 407);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(62, 17);
            this.cbActive.TabIndex = 22;
            this.cbActive.Text = "ist aktiv";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.Location = new System.Drawing.Point(3, 430);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(296, 23);
            this.btnCreatePlayer.TabIndex = 23;
            this.btnCreatePlayer.Text = "Spieler anlegen";
            this.btnCreatePlayer.UseVisualStyleBackColor = true;
            this.btnCreatePlayer.Click += new System.EventHandler(this.btnCreatePlayer_Click);
            // 
            // btnEditPlayer
            // 
            this.btnEditPlayer.Location = new System.Drawing.Point(3, 459);
            this.btnEditPlayer.Name = "btnEditPlayer";
            this.btnEditPlayer.Size = new System.Drawing.Size(296, 23);
            this.btnEditPlayer.TabIndex = 24;
            this.btnEditPlayer.Text = "Spieler ändern";
            this.btnEditPlayer.UseVisualStyleBackColor = true;
            this.btnEditPlayer.Click += new System.EventHandler(this.btnEditPlayer_Click);
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Location = new System.Drawing.Point(3, 488);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(296, 23);
            this.btnDeletePlayer.TabIndex = 25;
            this.btnDeletePlayer.Text = "Spieler löschen";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aktiv,
            this.Vorname,
            this.Nachname,
            this.Geburtstag,
            this.Strasse,
            this.Ort,
            this.Telefonnummer,
            this.EMail});
            this.dgvPlayers.Location = new System.Drawing.Point(326, 13);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersWidth = 20;
            this.dgvPlayers.Size = new System.Drawing.Size(558, 578);
            this.dgvPlayers.TabIndex = 2;
            this.dgvPlayers.SelectionChanged += new System.EventHandler(this.dgvPlayers_SelectionChanged);
            // 
            // Aktiv
            // 
            this.Aktiv.HeaderText = "Aktiv";
            this.Aktiv.Name = "Aktiv";
            this.Aktiv.ReadOnly = true;
            this.Aktiv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Aktiv.Width = 50;
            // 
            // Vorname
            // 
            this.Vorname.HeaderText = "Vorname";
            this.Vorname.MinimumWidth = 6;
            this.Vorname.Name = "Vorname";
            this.Vorname.ReadOnly = true;
            this.Vorname.Width = 125;
            // 
            // Nachname
            // 
            this.Nachname.HeaderText = "Nachname";
            this.Nachname.MinimumWidth = 6;
            this.Nachname.Name = "Nachname";
            this.Nachname.ReadOnly = true;
            this.Nachname.Width = 125;
            // 
            // Geburtstag
            // 
            this.Geburtstag.HeaderText = "Geburtstag";
            this.Geburtstag.MinimumWidth = 6;
            this.Geburtstag.Name = "Geburtstag";
            this.Geburtstag.ReadOnly = true;
            this.Geburtstag.Width = 125;
            // 
            // Strasse
            // 
            this.Strasse.HeaderText = "Straße";
            this.Strasse.MinimumWidth = 6;
            this.Strasse.Name = "Strasse";
            this.Strasse.ReadOnly = true;
            this.Strasse.Width = 125;
            // 
            // Ort
            // 
            this.Ort.HeaderText = "Ort";
            this.Ort.MinimumWidth = 6;
            this.Ort.Name = "Ort";
            this.Ort.ReadOnly = true;
            this.Ort.Width = 125;
            // 
            // Telefonnummer
            // 
            this.Telefonnummer.HeaderText = "Telefonnummer";
            this.Telefonnummer.MinimumWidth = 6;
            this.Telefonnummer.Name = "Telefonnummer";
            this.Telefonnummer.ReadOnly = true;
            this.Telefonnummer.Width = 125;
            // 
            // EMail
            // 
            this.EMail.HeaderText = "Email-Adresse";
            this.EMail.MinimumWidth = 6;
            this.EMail.Name = "EMail";
            this.EMail.ReadOnly = true;
            this.EMail.Width = 125;
            // 
            // btnAutoImport
            // 
            this.btnAutoImport.Location = new System.Drawing.Point(3, 517);
            this.btnAutoImport.Name = "btnAutoImport";
            this.btnAutoImport.Size = new System.Drawing.Size(296, 23);
            this.btnAutoImport.TabIndex = 26;
            this.btnAutoImport.Text = "AutoImport DFBnet";
            this.btnAutoImport.UseVisualStyleBackColor = true;
            this.btnAutoImport.Click += new System.EventHandler(this.btnAutoImport_Click);
            // 
            // Spielermodul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 602);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cbJugendSelector);
            this.Name = "Spielermodul";
            this.Text = "Spielermodul";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHouseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZipCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbJugendSelector;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.Label lNachname;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.Label lBirthday;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lStreet;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.NumericUpDown nudHouseNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudZipCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTeam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Button btnCreatePlayer;
        private System.Windows.Forms.Button btnEditPlayer;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Geburtstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Strasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefonnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.Button btnAutoImport;
    }
}