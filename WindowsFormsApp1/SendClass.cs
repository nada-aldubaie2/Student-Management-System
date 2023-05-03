using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace WindowsFormsApp1
{
    class SendClass
    {
        DBconnect connect = new DBconnect();
        //create funcion to insert subjects
        public bool sendPhon( int stdNum)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `phonesend`(`studentId`, `studentNumber`) VALUES (@stdId, @stdNum))", connect.GetConnection);
            //command.Parameters.Add("@stdId", MySqlDbType.Int32).Value = stdId;
            command.Parameters.Add("@stdNum", MySqlDbType.Int32).Value = stdNum;

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
        //create function t0 get Send list
        public DataTable getlist(MySqlCommand mySqlCommand)
        {
            //MySqlCommand command = new MySqlCommand("SELECT `Phone` FROM `student`", connect.GetConnection);
            //MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //return table;
            MySqlCommand command = new MySqlCommand("SELECT `Phone` FROM `student`", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}


