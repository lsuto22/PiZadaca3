using System;
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
    public partial class FrmAddDoctor : Form
    {
        public FrmAddDoctor()
        {
            InitializeComponent();
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmDoctors frmdoctors = new FrmDoctors();
            Hide();
            frmdoctors.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDoctorID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstAndLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSpecialization_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAvailability_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                int doctorID;
                if (!int.TryParse(txtDoctorID.Text, out doctorID))
                {
                    MessageBox.Show("Molimo popunite sva polja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DoctorRepository.IfDoctorIdExists(doctorID))
                {
                    MessageBox.Show("Liječnik s unesenim ID-om već postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string firstAndLastName = txtFirstAndLastName.Text;
                string specialization = txtSpecialization.Text;
                string contact = txtContact.Text;
                string location = txtLocation.Text;
                string availability = txtAvailability.Text;


                if (string.IsNullOrWhiteSpace(firstAndLastName) || string.IsNullOrWhiteSpace(specialization) ||
                    string.IsNullOrWhiteSpace(contact) || string.IsNullOrWhiteSpace(location) || string.IsNullOrWhiteSpace(availability))
                {
                    MessageBox.Show("Molimo popunite sva polja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                Doctor noviLijecnik = new Doctor
                {
                    Id = doctorID,
                    FirstAndLastName = firstAndLastName,
                    Specialization = specialization,
                    Contact = contact,
                    Location = location,
                    Availability = availability
                };


                DoctorRepository.InsertDoctor(noviLijecnik);

                MessageBox.Show("Novi liječnik je uspješno dodan!", "Uspješno dodavanje liječnika!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}