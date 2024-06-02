namespace MyDoc
{
    partial class FrmDoctors
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
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.txtAvailability = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.cboAvailability = new System.Windows.Forms.ComboBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(671, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upravljanje podacima o liječnicima";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Location = new System.Drawing.Point(0, 244);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.RowHeadersWidth = 51;
            this.dgvDoctors.RowTemplate.Height = 24;
            this.dgvDoctors.Size = new System.Drawing.Size(864, 340);
            this.dgvDoctors.TabIndex = 3;
            this.dgvDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtAvailability
            // 
            this.txtAvailability.AutoSize = true;
            this.txtAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailability.Location = new System.Drawing.Point(413, 194);
            this.txtAvailability.Name = "txtAvailability";
            this.txtAvailability.Size = new System.Drawing.Size(92, 18);
            this.txtAvailability.TabIndex = 5;
            this.txtAvailability.Text = "Dostupnosti:";
            this.txtAvailability.Click += new System.EventHandler(this.txtAvailability_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.AutoSize = true;
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(413, 140);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(62, 18);
            this.txtLocation.TabIndex = 6;
            this.txtLocation.Text = "Lokaciji:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pretraži liječnike po";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(34, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 73);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Dodaj liječnika";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(217, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 72);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Obriši liječnika";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Button2_Click);
            // 
            // cboLocation
            // 
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Items.AddRange(new object[] {
            "",
            "Varazdin ",
            "Zagreb",
            "Split"});
            this.cboLocation.Location = new System.Drawing.Point(520, 139);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(121, 24);
            this.cboLocation.TabIndex = 10;
            this.cboLocation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // cboAvailability
            // 
            this.cboAvailability.FormattingEnabled = true;
            this.cboAvailability.Items.AddRange(new object[] {
            "",
            "Da",
            "Ne"});
            this.cboAvailability.Location = new System.Drawing.Point(520, 193);
            this.cboAvailability.Name = "cboAvailability";
            this.cboAvailability.Size = new System.Drawing.Size(121, 24);
            this.cboAvailability.TabIndex = 11;
            this.cboAvailability.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlaz.Location = new System.Drawing.Point(679, 156);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(149, 42);
            this.btnIzlaz.TabIndex = 12;
            this.btnIzlaz.Text = "Izlaz iz programa";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Opcije za dodavanje i brisanje liječnika";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(864, 586);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.cboAvailability);
            this.Controls.Add(this.cboLocation);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtAvailability);
            this.Controls.Add(this.dgvDoctors);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podaci o liječnicima";
            this.Load += new System.EventHandler(this.FrmDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.Label txtAvailability;
        private System.Windows.Forms.Label txtLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cboLocation;
        private System.Windows.Forms.ComboBox cboAvailability;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label label2;
    }
}