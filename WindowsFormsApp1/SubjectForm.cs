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
    public partial class SubjectForm : Form
    {
        SubjectClass subject = new SubjectClass();
        StudentClass stdDepart = new StudentClass();
        public SubjectForm()
        {
            InitializeComponent();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            string sudId = textBox_subId.Text;
            string subName = textBox_subName.Text;
            string department = radioButtonCS.Checked ? "Computer Sciece" : "Computer Engneering";
            if (textBox_subName.Text == "" || textBox_subId.Text == "")
            {
                MessageBox.Show("Insert subject data", "Error Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (subject.insertSubject(sudId, subName))
                {
                    MessageBox.Show("New subject inserted", "Add subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Subject have not inserted", "Insert subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            textBox_subId.Clear();
            textBox_subName.Clear();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            showData();

                // Connect to the MySQL database
            //    string connectionString = "datasource=localhost;port=3306;username=root;password=;database=studentdb";
            //    MySqlConnection connection = new MySqlConnection(connectionString);
            //    connection.Open();

            //// Execute an SQL SELECT statement with a JOIN clause to retrieve the data from the two tables
            //string query = "SELECT subject.SubjectId, subject.Subject, .StudentId, student.StudentName FROM subject INNER JOIN student ON subject.Subject = student.StudentName";
            //MySqlCommand command = new MySqlCommand(query, connection); 
            //MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            //DataTable table = new DataTable();
            //adapter.Fill(table);

            //// Set the DataGridView's DataSource property to the resulting DataTable
            //guna2DataGridView_depart.DataSource = table;

            //// Close the database connection
            //connection.Close();

        }
        private void showData()
        {
            //to show subject list in data grid view
            DataGridView_Subject.DataSource = subject.getSubject(new MySqlCommand("SELECT * FROM `subject`"));
            guna2DataGridView_depart.DataSource = stdDepart.getlist(new MySqlCommand("SELECT `StudentId`,`StudentName`,`Department` FROM `student`"));
        }
    }
}
