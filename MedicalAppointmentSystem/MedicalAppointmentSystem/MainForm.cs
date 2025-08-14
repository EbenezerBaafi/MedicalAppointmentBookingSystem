using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalAppointmentSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void BtnViewDoctors_Click(object sender, EventArgs e)
        {
            DoctorListForm doctorListForm = new DoctorListForm();
            doctorListForm.ShowDialog();
        }

        private void BtnBookAppointment_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.ShowDialog();

        }

        private void BtnManageAppointment_Click(object sender, EventArgs e)
        {
            ManageAppointmentsForm manageAppointmentsFormsForm = new ManageAppointmentsForm();
            manageAppointmentsFormsForm.ShowDialog();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
