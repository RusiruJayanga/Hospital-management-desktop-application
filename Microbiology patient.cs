using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital
{
    public partial class Microbiology_patient : Form
    {
        SqlConnection connect
        = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");

        public Microbiology_patient()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* data enter to doctor table */

        private void button2_Click(object sender, EventArgs e)
        {

            if (id.Text == ""
                || name.Text == ""
                || gender.Text == ""
                || phone.Text == ""
                || address.Text == ""
                || dob.Text == ""
                )
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmID = "SELECT COUNT(*) FROM patient WHERE id = @employeeID";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@employeeID", id.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(id.Text.Trim() + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "SET IDENTITY_INSERT patient ON; " +
                    "INSERT INTO patient " +
                    "(id, name, phone, department, address, dob, gender) " +
                    "VALUES (@employeeID, @fullName, @contactNum, 'Microbiology', @position, @status, @gender); " +
                    "SET IDENTITY_INSERT patient OFF;";




                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullName", name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactNum", phone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", address.Text.Trim());
                                    cmd.Parameters.AddWithValue("@insertDate", today);
                                    cmd.Parameters.AddWithValue("@status", dob.Text.Trim());

                                    cmd.ExecuteNonQuery();



                                    MessageBox.Show("Added successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }

        /* end of data entry */

        /* delete data from table */

        private void button15_Click(object sender, EventArgs e)
        {
            if (id.Text == ""
               )
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Employee ID: " + id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "DELETE FROM patient WHERE id = @employeeID;";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@employeeID", id.Text.Trim());

                            cmd.ExecuteNonQuery();



                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        /* end of delete data */

        /* update existing data in table */

        private void button3_Click(object sender, EventArgs e)
        {
            if (id.Text == ""
                || name.Text == ""
                || gender.Text == ""
                || phone.Text == ""
                || address.Text == ""
                || dob.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Employee ID: " + id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE patient SET name = @fullName" +
                            ", gender = @gender, phone = @contactNum" +
                            ", department = 'Microbiology', address = @position, dob = @status " +
                            "WHERE id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@employeeID", id.Text.Trim());
                            cmd.Parameters.AddWithValue("@fullName", name.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@contactNum", phone.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", address.Text.Trim());
                            cmd.Parameters.AddWithValue("@insertDate", today);
                            cmd.Parameters.AddWithValue("@status", dob.Text.Trim());

                            cmd.ExecuteNonQuery();



                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        /* end of updating data */


        public void clearFields()
        {
            id.Text = "";
            name.Text = "";
            gender.Text = "";
            phone.Text = "";
            address.Text = "";
            dob.Text = "";
        }

        /* display data in data gride viwe */

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("select * from patient WHERE department = 'Microbiology';", connect);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /* end display data in data gride viwe */
        private void Clinicsnav_Click(object sender, EventArgs e)
        {
            Microbiology_clinics mForm = new Microbiology_clinics();
            mForm.Show();
            this.Hide();
        }

        private void Office_Workersnav_Click(object sender, EventArgs e)
        {
            Microbiology_office mForm = new Microbiology_office();
            mForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainindex mForm = new mainindex();
            mForm.Show();
            this.Hide();
        }

        private void Doctornav_Click(object sender, EventArgs e)
        {
            Microbiology_doctors mForm = new Microbiology_doctors();
            mForm.Show();
            this.Hide();
        }

        private void Nursesnav_Click(object sender, EventArgs e)
        {
            Microbiology_nurses mForm = new Microbiology_nurses();
            mForm.Show();
            this.Hide();
        }

        private void Trainingnav_Click(object sender, EventArgs e)
        {
            Microbiology_training mForm = new Microbiology_training();
            mForm.Show();
            this.Hide();
        }

        private void Attendantsnav_Click(object sender, EventArgs e)
        {
            Microbiology_attendants mForm = new Microbiology_attendants();
            mForm.Show();
            this.Hide();
        }


        private void Doctorsmain_Click(object sender, EventArgs e)
        {
            doctormain mForm = new doctormain();
            mForm.Show();
            this.Hide();
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
    }
}
