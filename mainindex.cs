using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class mainindex : Form
    {
        public mainindex()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
           
        }

        private void Accident_and_emergencymain_Click(object sender, EventArgs e)
        {
            
        }

        private void mainindex_Load(object sender, EventArgs e)
        {

        }

        private void Accidentbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void mainpanel_Load(object sender, PaintEventArgs e)
        {
            
        }

        

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Accident_and_emergency_doctors mForm = new Accident_and_emergency_doctors();
            mForm.Show();
            this.Hide();
        }

        private void Doctorsmain_Click(object sender, EventArgs e)
        {
            doctormain mForm = new doctormain();
            mForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nursesmain_Click(object sender, EventArgs e)
        {
            nursemain mForm = new nursemain();
            mForm.Show();
            this.Hide();
        }

        private void Trainingmain_Click(object sender, EventArgs e)
        {
            trainingmain mForm = new trainingmain();
            mForm.Show();
            this.Hide();
        }

        private void Patientsmain_Click(object sender, EventArgs e)
        {
            patientmain mForm = new patientmain();
            mForm.Show();
            this.Hide();
        }

        private void Clinicsmain_Click(object sender, EventArgs e)
        {
            clinicmain mForm = new clinicmain();
            mForm.Show();
            this.Hide();
        }

        private void Office_Workersmain_Click(object sender, EventArgs e)
        {
            Office_Workersmain mForm = new Office_Workersmain();
            mForm.Show();
            this.Hide();
        }

        private void Attendantsmain_Click(object sender, EventArgs e)
        {
            Attendantsmain mForm = new Attendantsmain();
            mForm.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Cardiology_doctors mForm = new Cardiology_doctors();
            mForm.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Diagnostic_Imaging_doctors mForm = new Diagnostic_Imaging_doctors();
            mForm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Gastroenterology_doctors mForm = new Gastroenterology_doctors();
            mForm.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            General_Surgery_doctors mForm = new General_Surgery_doctors();
            mForm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Microbiology_doctors mForm = new Microbiology_doctors();
            mForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Critical_Care_doctors mForm = new Critical_Care_doctors();
            mForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Radiology_doctors mForm = new Radiology_doctors();
            mForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Radiotherapy_doctors mForm = new Radiotherapy_doctors();
            mForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Neonatal_doctors mForm = new Neonatal_doctors();
            mForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Occupational_Therapy_doctors mForm = new Occupational_Therapy_doctors();
            mForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Burn_Center_doctors mForm = new Burn_Center_doctors();
            mForm.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            Endoscopy_doctors mForm = new Endoscopy_doctors();
            mForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Pharmacy_drugs mForm = new Pharmacy_drugs();
            mForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                Human_Resources_office mForm = new Human_Resources_office();
            mForm.Show();
            this.Hide();
        }
    }
}
