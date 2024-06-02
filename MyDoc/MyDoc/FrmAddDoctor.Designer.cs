namespace MyDoc
{
    partial class FrmAddDoctor
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
            this.btnPovratak = new System.Windows.Forms.Button();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.txtFirstAndLastName = new System.Windows.Forms.TextBox();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtAvailability = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLijecnikID = new System.Windows.Forms.Label();
            this.lblFirstAndLastName = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.lblDostupnost = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(325, 390);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(199, 48);
            this.btnPovratak.TabIndex = 0;
            this.btnPovratak.Text = "Povratak na početnu stranicu";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Location = new System.Drawing.Point(325, 126);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(165, 22);
            this.txtDoctorID.TabIndex = 1;
            this.txtDoctorID.TextChanged += new System.EventHandler(this.txtDoctorID_TextChanged);
            // 
            // txtFirstAndLastName
            // 
            this.txtFirstAndLastName.Location = new System.Drawing.Point(325, 172);
            this.txtFirstAndLastName.Name = "txtFirstAndLastName";
            this.txtFirstAndLastName.Size = new System.Drawing.Size(165, 22);
            this.txtFirstAndLastName.TabIndex = 2;
            this.txtFirstAndLastName.TextChanged += new System.EventHandler(this.txtFirstAndLastName_TextChanged);
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.Location = new System.Drawing.Point(325, 218);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.Size = new System.Drawing.Size(165, 22);
            this.txtSpecialization.TabIndex = 3;
            this.txtSpecialization.TextChanged += new System.EventHandler(this.txtSpecialization_TextChanged);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(325, 260);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(165, 22);
            this.txtContact.TabIndex = 4;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(325, 303);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(165, 22);
            this.txtLocation.TabIndex = 5;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // txtAvailability
            // 
            this.txtAvailability.Location = new System.Drawing.Point(325, 345);
            this.txtAvailability.Name = "txtAvailability";
            this.txtAvailability.Size = new System.Drawing.Size(165, 22);
            this.txtAvailability.TabIndex = 6;
            this.txtAvailability.TextChanged += new System.EventHandler(this.txtAvailability_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Dodaj liječnika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLijecnikID
            // 
            this.lblLijecnikID.AutoSize = true;
            this.lblLijecnikID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLijecnikID.Location = new System.Drawing.Point(197, 127);
            this.lblLijecnikID.Name = "lblLijecnikID";
            this.lblLijecnikID.Size = new System.Drawing.Size(82, 18);
            this.lblLijecnikID.TabIndex = 8;
            this.lblLijecnikID.Text = "ID liječnika:";
            this.lblLijecnikID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFirstAndLastName
            // 
            this.lblFirstAndLastName.AutoSize = true;
            this.lblFirstAndLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstAndLastName.Location = new System.Drawing.Point(197, 172);
            this.lblFirstAndLastName.Name = "lblFirstAndLastName";
            this.lblFirstAndLastName.Size = new System.Drawing.Size(100, 18);
            this.lblFirstAndLastName.TabIndex = 9;
            this.lblFirstAndLastName.Text = "Ime I prezime:";
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialization.Location = new System.Drawing.Point(197, 218);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(104, 18);
            this.lblSpecialization.TabIndex = 10;
            this.lblSpecialization.Text = "Specijalizacija:";
            this.lblSpecialization.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(197, 260);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(63, 18);
            this.lblContact.TabIndex = 11;
            this.lblContact.Text = "Kontakt:";
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokacija.Location = new System.Drawing.Point(197, 303);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(67, 18);
            this.lblLokacija.TabIndex = 12;
            this.lblLokacija.Text = "Lokacija:";
            // 
            // lblDostupnost
            // 
            this.lblDostupnost.AutoSize = true;
            this.lblDostupnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDostupnost.Location = new System.Drawing.Point(197, 346);
            this.lblDostupnost.Name = "lblDostupnost";
            this.lblDostupnost.Size = new System.Drawing.Size(89, 18);
            this.lblDostupnost.TabIndex = 13;
            this.lblDostupnost.Text = "Dostupnost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(226, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 36);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dodaj liječnika";
            // 
            // FrmAddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(677, 455);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDostupnost);
            this.Controls.Add(this.lblLokacija);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblSpecialization);
            this.Controls.Add(this.lblFirstAndLastName);
            this.Controls.Add(this.lblLijecnikID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAvailability);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtSpecialization);
            this.Controls.Add(this.txtFirstAndLastName);
            this.Controls.Add(this.txtDoctorID);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje i uređivanje liječnika";
            this.Load += new System.EventHandler(this.AddDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.TextBox txtFirstAndLastName;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtAvailability;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLijecnikID;
        private System.Windows.Forms.Label lblFirstAndLastName;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.Label lblDostupnost;
        private System.Windows.Forms.Label label7;
    }
}