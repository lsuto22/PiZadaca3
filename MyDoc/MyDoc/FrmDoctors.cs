﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDoc.Models;
using MyDoc.Repositories;

namespace MyDoc
{
    public partial class FrmDoctors : Form
    {
        public FrmDoctors()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmDoctors_Load(object sender, EventArgs e)
        {
            ShowDoctors();
        }
        private void ShowDoctors()
        {
            List<Doctor> doctors = DoctorRepository.GetDoctors();
            dgvDoctors.DataSource = doctors;
            dgvDoctors.Columns["Id"].DisplayIndex = 0;
            dgvDoctors.Columns["FirstAndLastName"].DisplayIndex = 1;
            dgvDoctors.Columns["Specialization"].DisplayIndex = 2;
            dgvDoctors.Columns["Contact"].DisplayIndex = 3;
            dgvDoctors.Columns["Location"].DisplayIndex = 4;
            dgvDoctors.Columns["Availability"].DisplayIndex = 5;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.SelectedRows.Count > 0)
            {
                int doctorId = (int)dgvDoctors.SelectedRows[0].Cells["Id"].Value;

                bool success = DoctorRepository.DeleteDoctorAttributes(doctorId);

                if (success)
                {
                    ShowDoctors();
                    MessageBox.Show("Liječnik je uspješno obrisan.");
                }
                else
                {
                    MessageBox.Show("Greška prilikom brisanja atributa odabranog liječnika.");
                }
            }
            else
            {
                MessageBox.Show("Odaberite liječnika iz popisa.");
            }
        }

        private void cboAvailability_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
