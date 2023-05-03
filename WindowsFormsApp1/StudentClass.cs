using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace WindowsFormsApp1
{
    class StudentClass
    {
        DBconnect connect = new DBconnect();
        //create a function to add a new student to the database
        public bool insertStudent(int StudentId, string StudentName, DateTime birthdate, string aaddress, int phone, string email, string department, string geneder )
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`StudentId`, `StudentName`, `Birthdate`, `Address`, `Phone`, `Email`, `Department`,`Geneder`) VALUES (@id,@name,@birth,@address,@phone,@email,@depart,@geneder)", connect.GetConnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = StudentId;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = StudentName;
            command.Parameters.Add("@birth", MySqlDbType.Date).Value = birthdate;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = aaddress;
            command.Parameters.Add("@phone", MySqlDbType.Int32).Value = phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@depart", MySqlDbType.VarChar).Value = department;
            command.Parameters.Add("@geneder", MySqlDbType.VarChar).Value = geneder;

            connect.openconnect();
            if(command.ExecuteNonQuery()==1)
            {
                connect.closeconnect();
                return true;
            }
            else
            {
                connect.closeconnect();
                return false;
            }
        }

        //tol get student table
        //public DataTable getlist(MySqlCommand mySqlCommand)
        //{
        //    MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.GetConnection);
        //    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;
            //}
        public DataTable getlist(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        //  create function to excute the count of query "Total of male and female
        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            connect.openconnect();
            string count = command.ExecuteScalar().ToString(); //run time error
            connect.closeconnect();
            return count;
        }
       // to get total student
        public string totalStudent()
        {
            return exeCount("SELECT COUNT(*)FROM student");
        }
        //to get male student
        public string maleStudent()
        {
            return exeCount("SELECT * FROM `student` WHERE `Geneder`='Male'");
        }
        //to get female student
        public string femaleStudent()
        {
            return exeCount("SELECT * FROM `student` WHERE `Geneder`='Female'");
        }
    }

}
