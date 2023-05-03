using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Studens_Regsration : Form
    {
        StudentClass student = new StudentClass();
        public Studens_Regsration()
        {
            InitializeComponent();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            int StudentId = Convert.ToInt32(textBox_StudentId.Text);
            string StudentName = textBox_StudentName.Text;
            DateTime birthdate = dateTimePicker_StudentBirhday.Value;
            string address = textBox_StudentAddress.Text;
            int phone = Convert.ToInt32(textBox_StudentPhone.Text);
            string email = textBox_StudentEmail.Text;
            string department = radioButtonCS.Checked ? "Computer Sciece" : "Computer Engneering";
            string geneder = radioButton_male.Checked ? " ذكر" : " أنثى";

            //check the birth year of student
            int born_year = dateTimePicker_StudentBirhday.Value.Year;
            int this_year = DateTime.Now.Year;
            if((this_year - born_year) < 18 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The student age must be between 18 and 100", "Invalid birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(verify())
            {
                if(student.insertStudent(StudentId,StudentName, birthdate, address,phone,email,department,geneder))
                {
                    showTable();
                    MessageBox.Show("New student has added", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error - Student doesn't add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bool verify()
            {
                if ((textBox_StudentId.Text == "") || (textBox_StudentName.Text == "") ||
                    (textBox_StudentAddress.Text == "") || (textBox_StudentPhone.Text == "") ||
                    (textBox_StudentEmail.Text == ""))
                {
                    return false;
                }
                else
                    return true;
            }
        }
      
        private void Studens_Regsration_Load(object sender, EventArgs e)
        {
            showTable();
        }

        //to show student list in Datagridview
        public void showTable()
        {
            DataGridView_Resteration.DataSource = student.getlist(new MySqlCommand("SELECT * FROM `student`"));
            //DataGridView_Resteration.RowTemplate.Height = 80;
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            textBox_StudentName.Clear();
            textBox_StudentId.Clear();
            textBox_StudentAddress.Clear();
            textBox_StudentPhone.Clear();
            textBox_StudentEmail.Clear();
        }

       

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

      
    }
}
