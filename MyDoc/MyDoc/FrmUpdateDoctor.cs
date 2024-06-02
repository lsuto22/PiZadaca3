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
    public partial class FrmUpdateDoctor : Form
    {
        Doctor proslijeden;
        public FrmUpdateDoctor(Doctor doctor)
        {
            InitializeComponent();
            proslijeden = doctor;
            LoadDoctorData(doctor);
        }

        private void UpdateDoctor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoctors frmdoctors = new FrmDoctors();
            Hide();
            
            frmdoctors.ShowDialog();
            Close();
        }

        private void LoadDoctorData(Doctor doctor)
        {
            if (doctor != null)
            {
                btnDoctorID.Text = doctor.Id.ToString();
                btnFirstAndLastName.Text = doctor.FirstAndLastName;
                btnSpecialization.Text = doctor.Specialization;
                btnContact.Text = doctor.Contact;
                btnLocation.Text = doctor.Location;
                btnAvailability.Text = doctor.Availability;
            }
        }

        private void btnDoctorID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFirstAndLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSpecialization_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAvailability_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            proslijeden.Id = int.Parse(btnDoctorID.Text);
            proslijeden.FirstAndLastName = btnFirstAndLastName.Text;
            proslijeden.Specialization = btnSpecialization.Text;
            proslijeden.Contact = btnContact.Text;
            proslijeden.Location = btnLocation.Text;
            proslijeden.Availability = btnAvailability.Text;

            DoctorRepository.UpdateDoctor(proslijeden);
        }
    }
}
