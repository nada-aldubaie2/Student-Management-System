using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class ResultForm : Form
    {
        ResultClass scor = new ResultClass();
        SubjectClass subject = new SubjectClass();
        StudentClass student = new StudentClass();
        public ResultForm()
        {
            InitializeComponent();
        }

        //create function to show data in dataGridView
        private void showResult()
        {
            guna2DataGridView_socer.DataSource = scor.getlist(new MySqlCommand("SELECT * FROM `results`"));
        }
        private void ResultForm_Load(object sender, EventArgs e)
        {
            //link comboBox wiht subjects
            comboBox_chooseSub.DataSource = subject.getSubject(new MySqlCommand("SELECT * FROM `subject`"));
            comboBox_chooseSub.DisplayMember = "Subject";
            comboBox_chooseSub.ValueMember = "Subject";
            //to show data in result dataGridview
            showResult();
            //to disply studen list on data grdi view

            DataGridView_Students.DataSource = student.getlist(new MySqlCommand("SELECT `StudentId`,`StudentName`,`Department` FROM `student`"));
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
           
            if (comboBox_chooseSub.Text == "" || textBox_stdDegree.Text == "")
            {
                MessageBox.Show("Insert subject data", "Error Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int StudentId = Convert.ToInt32(textBox_stdId.Text);
                string SubjectName = comboBox_chooseSub.Text;
                double score = Convert.ToInt32(textBox_stdDegree.Text);
               
                if (scor.insertScore(StudentId,SubjectName, score))
                {
                    showResult();
                    button_Clear.PerformClick();
                    MessageBox.Show("New score inserted", "Add the score of the subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Score have not Added", "Insert the score of the subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            textBox_stdDegree.Clear();
            comboBox_chooseSub.SelectedIndex = 0;
        }

        private void TextBox_stdId_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}

