using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public class StudentInfo
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Program { get; set; }
        public string PhotoPath { get; set; }

        public void DisplayStudentInfo(string firtsName, string lastName)
        {
            MessageBox.Show($"Student: {firtsName} {lastName}", "Student Information");
        }

        public void DisplayStudentInfo(string firtsName, string lastName, string gender)
        {
            MessageBox.Show($"Student: {firtsName} {lastName}\nGender: {gender}", "Student Information");
        }

        public void DisplayStudentInfo(string firstName, string lastName, string middleName, string gender, DateTime dateOfBirth, string program, string photoPath)
        {
            MessageBox.Show(
                $"Student: {lastName}, {firstName} {middleName}\n" +
                $"Gender: {gender}\n" +
                $"Date of Birth: {dateOfBirth.ToShortDateString()}\n" +
                $"Program: {program}\n" +
                $"Photo Path: {photoPath}",
                "Student Information"
            );


        }
    }
}
