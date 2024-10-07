using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();

            cmbProgram.Items.Add("BSCS");
            cmbProgram.Items.Add("BSIT");
            cmbProgram.Items.Add("BSMMA");
            cmbProgram.Items.Add("BSBA");
            cmbProgram.Items.Add("BSTM");
            cmbProgram.Items.Add("BSHM");
            cmbProgram.Items.Add("BSEWAN");
        }

        private void chkMale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMale.Checked)
            {
                chkFemale.Checked = false;
            }
        }

        private void chkFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFemale.Checked)
            {
                chkMale.Checked = false;
            }
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            openFileDialog1.Title = "Select a Student Photo";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picStudentPhoto.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            StudentInfo stupijante = new StudentInfo();

            stupijante.FirstName = txtFirstName.Text;
            stupijante.LastName = txtLastName.Text;
            stupijante.MiddleName = txtMiddleName.Text;

            if (chkMale.Checked)
            {
                stupijante.Gender = "Male";
            } else if (chkFemale.Checked)
            {
                stupijante.Gender = "Female";
            }

            stupijante.DateOfBirth = dtpDateOfBirth.Value;
            stupijante.Program = cmbProgram.SelectedItem?.ToString();
            stupijante.PhotoPath = picStudentPhoto.ImageLocation;

            stupijante.DisplayStudentInfo(stupijante.FirstName, stupijante.LastName);
            stupijante.DisplayStudentInfo(stupijante.FirstName, stupijante.LastName, stupijante.Gender);
            stupijante.DisplayStudentInfo(stupijante.FirstName, stupijante.LastName, stupijante.MiddleName, stupijante.Gender, stupijante.DateOfBirth, stupijante.Program, stupijante.PhotoPath);

        }
    }
}
