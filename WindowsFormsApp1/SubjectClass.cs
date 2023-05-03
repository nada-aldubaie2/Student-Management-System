using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace WindowsFormsApp1
{
    class SubjectClass
    {
        DBconnect connect = new DBconnect();
        //create funcion to insert subjects
        public bool insertSubject(string sudId, string subName)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `subject`(`SubjectId`, `Subject`) VALUES (@subid,@subName)", connect.GetConnection);
            command.Parameters.Add("@subid", MySqlDbType.Int32).Value = sudId;
            command.Parameters.Add("@subName", MySqlDbType.VarChar).Value = subName;

            connect.openconnect();
            if (command.ExecuteNonQuery() == 1)
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
        //create function t0 get subject list
        public DataTable getSubject(MySqlCommand mySqlCommand)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `subject`", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
