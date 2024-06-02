namespace MyDoc
{
    partial class FrmUpdateDoctor
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDoctorID = new System.Windows.Forms.TextBox();
            this.btnFirstAndLastName = new System.Windows.Forms.TextBox();
            this.btnSpecialization = new System.Windows.Forms.TextBox();
            this.btnContact = new System.Windows.Forms.TextBox();
            this.btnLocation = new System.Windows.Forms.TextBox();
            this.btnAvailability = new System.Windows.Forms.TextBox();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.lblFirstAndLastName = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ažuriraj liječnika";
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(340, 376);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(204, 48);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak na početnu stranicu";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(183, 376);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 47);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Ažuriraj liječnika";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDoctorID
            // 
            this.btnDoctorID.Enabled = false;
            this.btnDoctorID.Location = new System.Drawing.Point(353, 110);
            this.btnDoctorID.Name = "btnDoctorID";
            this.btnDoctorID.Size = new System.Drawing.Size(168, 22);
            this.btnDoctorID.TabIndex = 3;
            this.btnDoctorID.TextChanged += new System.EventHandler(this.btnDoctorID_TextChanged);
            // 
            // btnFirstAndLastName
            // 
            this.btnFirstAndLastName.Location = new System.Drawing.Point(353, 154);
            this.btnFirstAndLastName.Name = "btnFirstAndLastName";
            this.btnFirstAndLastName.Size = new System.Drawing.Size(168, 22);
            this.btnFirstAndLastName.TabIndex = 4;
            this.btnFirstAndLastName.TextChanged += new System.EventHandler(this.btnFirstAndLastName_TextChanged);
            // 
            // btnSpecialization
            // 
            this.btnSpecialization.Location = new System.Drawing.Point(353, 198);
            this.btnSpecialization.Name = "btnSpecialization";
            this.btnSpecialization.Size = new System.Drawing.Size(168, 22);
            this.btnSpecialization.TabIndex = 5;
            this.btnSpecialization.TextChanged += new System.EventHandler(this.btnSpecialization_TextChanged);
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(353, 239);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(168, 22);
            this.btnContact.TabIndex = 6;
            this.btnContact.TextChanged += new System.EventHandler(this.btnContact_TextChanged);
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(353, 279);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(168, 22);
            this.btnLocation.TabIndex = 7;
            this.btnLocation.TextChanged += new System.EventHandler(this.btnLocation_TextChanged);
            // 
            // btnAvailability
            // 
            this.btnAvailability.Location = new System.Drawing.Point(353, 321);
            this.btnAvailability.Name = "btnAvailability";
            this.btnAvailability.Size = new System.Drawing.Size(168, 22);
            this.btnAvailability.TabIndex = 8;
            this.btnAvailability.TextChanged += new System.EventHandler(this.btnAvailability_TextChanged);
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorID.Location = new System.Drawing.Point(222, 110);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(82, 18);
            this.lblDoctorID.TabIndex = 9;
            this.lblDoctorID.Text = "ID liječnika:";
            // 
            // lblFirstAndLastName
            // 
            this.lblFirstAndLastName.AutoSize = true;
            this.lblFirstAndLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstAndLastName.Location = new System.Drawing.Point(222, 154);
            this.lblFirstAndLastName.Name = "lblFirstAndLastName";
            this.lblFirstAndLastName.Size = new System.Drawing.Size(100, 18);
            this.lblFirstAndLastName.TabIndex = 10;
            this.lblFirstAndLastName.Text = "Ime i prezime:";
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialization.Location = new System.Drawing.Point(222, 198);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(104, 18);
            this.lblSpecialization.TabIndex = 11;
            this.lblSpecialization.Text = "Specijalizacija:";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(222, 239);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(63, 18);
            this.lblContact.TabIndex = 12;
            this.lblContact.Text = "Kontakt:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(222, 279);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(67, 18);
            this.lblLocation.TabIndex = 13;
            this.lblLocation.Text = "Lokacija:";
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.Location = new System.Drawing.Point(222, 321);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(85, 18);
            this.lblAvailability.TabIndex = 14;
            this.lblAvailability.Text = "Dostupnost";
            // 
            // FrmUpdateDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 447);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblSpecialization);
            this.Controls.Add(this.lblFirstAndLastName);
            this.Controls.Add(this.lblDoctorID);
            this.Controls.Add(this.btnAvailability);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnSpecialization);
            this.Controls.Add(this.btnFirstAndLastName);
            this.Controls.Add(this.btnDoctorID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUpdateDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDoctor";
            this.Load += new System.EventHandler(this.UpdateDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox btnDoctorID;
        private System.Windows.Forms.TextBox btnFirstAndLastName;
        private System.Windows.Forms.TextBox btnSpecialization;
        private System.Windows.Forms.TextBox btnContact;
        private System.Windows.Forms.TextBox btnLocation;
        private System.Windows.Forms.TextBox btnAvailability;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.Label lblFirstAndLastName;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblAvailability;
    }
}