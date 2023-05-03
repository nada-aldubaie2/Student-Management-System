using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace WindowsFormsApp1
{
    class ResultClass
    {
        DBconnect connect = new DBconnect();

        //create a function to add score of the subjects
        public bool insertScore(int StudentId, string SubjectName, double score)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `results`(`StudentId`, `Subject Name`, `Score`) VALUES (@stdId,@subName,@score)", connect.GetConnection);
            command.Parameters.Add("@stdId", MySqlDbType.Int32).Value = StudentId;
            command.Parameters.Add("@subName", MySqlDbType.VarChar).Value = SubjectName;
            command.Parameters.Add("@score", MySqlDbType.Double).Value = score;
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

        //crreate function to get the list 
        public DataTable getlist(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    } 
 
}
