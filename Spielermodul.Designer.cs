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
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbSHouseNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTeam = new System.Windows.Forms.ComboBox();
            this.btnCreatePlayer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.Vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Geburtstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Strasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefonnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.cbJugendSelector.Location = new System.Drawing.Point(17, 16);
            this.cbJugendSelector.Margin = new System.Windows.Forms.Padding(4);
            this.cbJugendSelector.Name = "cbJugendSelector";
            this.cbJugendSelector.Size = new System.Drawing.Size(407, 24);
            this.cbJugendSelector.Sorted = true;
            this.cbJugendSelector.TabIndex = 0;
            this.cbJugendSelector.SelectedValueChanged += new System.EventHandler(this.cbJugendSelector_SelectedValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.tbFirstname);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.tbLastname);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.tbStreet);
            this.flowLayoutPanel1.Controls.Add(this.tbSHouseNumber);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.tbZipCode);
            this.flowLayoutPanel1.Controls.Add(this.tbCity);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.tbTelephone);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.tbMail);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.dtpBirthday);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.cbTeam);
            this.flowLayoutPanel1.Controls.Add(this.btnCreatePlayer);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 50);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(408, 489);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vorname";
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(4, 20);
            this.tbFirstname.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(399, 22);
            this.tbFirstname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nachname";
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(4, 66);
            this.tbLastname.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(399, 22);
            this.tbLastname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Straße + Hausnummer                                                              " +
    "       ";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(4, 112);
            this.tbStreet.Margin = new System.Windows.Forms.Padding(4);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(335, 22);
            this.tbStreet.TabIndex = 20;
            // 
            // tbSHouseNumber
            // 
            this.tbSHouseNumber.Location = new System.Drawing.Point(347, 112);
            this.tbSHouseNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbSHouseNumber.Name = "tbSHouseNumber";
            this.tbSHouseNumber.Size = new System.Drawing.Size(55, 22);
            this.tbSHouseNumber.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ort                                                                              " +
    "                     ";
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(4, 158);
            this.tbZipCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(100, 22);
            this.tbZipCode.TabIndex = 4;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(112, 158);
            this.tbCity.Margin = new System.Windows.Forms.Padding(4);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(290, 22);
            this.tbCity.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefonnummer";
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(4, 204);
            this.tbTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(399, 22);
            this.tbTelephone.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "E-Mail-Adresse";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(4, 250);
            this.tbMail.Margin = new System.Windows.Forms.Padding(4);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(399, 22);
            this.tbMail.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Geburtstag";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(4, 296);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(399, 22);
            this.dtpBirthday.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 322);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Jugend";
            // 
            // cbTeam
            // 
            this.cbTeam.FormattingEnabled = true;
            this.cbTeam.Items.AddRange(new object[] {
            "A-Jugend",
            "B-Jugend",
            "Bambini",
            "C-Jugend",
            "D-Jugend",
            "E-Jugend",
            "F-Jugend",
            "Archiv"});
            this.cbTeam.Location = new System.Drawing.Point(4, 342);
            this.cbTeam.Margin = new System.Windows.Forms.Padding(4);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Size = new System.Drawing.Size(399, 24);
            this.cbTeam.TabIndex = 15;
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.Location = new System.Drawing.Point(4, 374);
            this.btnCreatePlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(404, 28);
            this.btnCreatePlayer.TabIndex = 17;
            this.btnCreatePlayer.Text = "Anlegen";
            this.btnCreatePlayer.UseVisualStyleBackColor = true;
            this.btnCreatePlayer.Click += new System.EventHandler(this.btnCreatePlayer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 410);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(404, 28);
            this.button2.TabIndex = 18;
            this.button2.Text = "Löschen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 446);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(404, 28);
            this.button3.TabIndex = 19;
            this.button3.Text = "Aktualisieren";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vorname,
            this.Nachname,
            this.Geburtstag,
            this.Strasse,
            this.Ort,
            this.Telefonnummer,
            this.EMail});
            this.dgvPlayers.Location = new System.Drawing.Point(435, 16);
            this.dgvPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersWidth = 51;
            this.dgvPlayers.Size = new System.Drawing.Size(616, 523);
            this.dgvPlayers.TabIndex = 2;
            this.dgvPlayers.SelectionChanged += new System.EventHandler(this.dgvPlayers_SelectionChanged);
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
            // Spielermodul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cbJugendSelector);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Spielermodul";
            this.Text = "Spielermodul";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbJugendSelector;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSHouseNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.ComboBox cbTeam;
        private System.Windows.Forms.Button btnCreatePlayer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Geburtstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Strasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefonnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
    }
}