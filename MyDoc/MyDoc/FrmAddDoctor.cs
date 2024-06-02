using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
