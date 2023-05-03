using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace WindowsFormsApp1
{
    public partial class SendForm : Form
    {
        StudentClass student = new StudentClass();
        SendClass phone = new SendClass();
        public SendForm()
        {
            InitializeComponent();
        }

        private void SendForm_Load(object sender, EventArgs e)
        {
            //to disply studen list on data grdi view
            DataGridView_phoneSend.DataSource = student.getlist(new MySqlCommand("SELECT `StudentId`,`StudentName`,`Phone`, `Email` FROM `student`"));

            //DataGridView_phoneSend.DataSource = phone.getlist(new MySqlCommand("SELECT `studentId`, `studentName`, `studentNumber` FROM `phonesend`"));
        }

       

        private async Task Button_phoneSend_Click_1Async(object sender, EventArgs e)
        {
            // Define the API endpoint and your API key
            string apiUrl = "https://www.itemxmo.com/php_api/api.php";
            string apiKey = "your-api-key";

            // Send a GET request to the API endpoint with your API key as a parameter
            using (HttpClient client = new HttpClient())
            {
                string requestUrl = $"{apiUrl}?key={apiKey}";
                HttpResponseMessage response = await client.GetAsync(requestUrl);
                response.EnsureSuccessStatusCode(); // Throw an exception if the response is not successful
                string responseBody = await response.Content.ReadAsStringAsync();

                // Parse the response JSON data into a DataTable
                DataTable table = JsonConvert.DeserializeObject<DataTable>(responseBody);

                // Set the DataGridView's DataSource property to the resulting DataTable
                DataGridView_phoneSend.DataSource = table;
            }
            //    //https://www.itemxmo.com/php_api/api.php
            //    WebClient webClient = new WebClient();
            //    NameValueCollection nameValueCollection = new NameValueCollection();
            //    nameValueCollection.Add("1", "textBox_stdNum");
            //    nameValueCollection.Add("2", "textBox_Message");
            //    nameValueCollection.Add("3", "TR-BRAYAN348390_UMXCP");
            //    nameValueCollection.Add("passwd", "Int)#{}5v");
            //    byte[] send = webClient.UploadValues("https://www.itemxmo.com/php_api/api.php", "POST", nameValueCollection);
            //    System.Text.UTF8Encoding.UTF8.GetString(send);


            // Connect to the MySQL database
            //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=studentdb";
            //    MySqlConnection connection = new MySqlConnection(connectionString);
            //    connection.Open();

            //    // Execute a SELECT query to retrieve the phone numbers of the students
            //    string query = "SELECT `Phone` FROM `student`";
            //    MySqlCommand command = new MySqlCommand(query, connection);
            //    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            //    DataTable table = new DataTable();
            //    adapter.Fill(table);

            //    // Send a message to each phone number using the Twilio API
            //    foreach (DataRow row in table.Rows)
            //    {
            //        string phoneNumber = row["Phone"].ToString();
            //        SendMessag("+1415xxxxxxx", phoneNumber, "This is a message from the school.");
            //    }

            //    // Close the database connection
            //    connection.Close();
        }

            //private void SendMessage(string from, string to, string body)
            //{
            //    // Replace these values with your Twilio account SID and auth token
            //    const string accountSid = "your-account-sid";
            //    const string authToken = "your-auth-token";

            //    // Initialize the Twilio client with your account SID and auth token
            //    TwilioClient.Init(accountSid, authToken);

            //    // Send the SMS message using the Twilio API
            //    var message = MessageResource.Create(
            //        from: new Twilio.Types.PhoneNumber(from),
            //        to: new Twilio.Types.PhoneNumber(to),
            //        body: body);
            //}

            private void SendMessag(string from, string to, string body)
        {
            // Replace these values with your Twilio account SID and auth token
            const string accountSid = "your-account-sid";
            const string authToken = "your-auth-token";

            // Initialize the Twilio client with your account SID and auth token
            TwilioClient.Init(accountSid, authToken);

            // Send the SMS message using the Twilio API
            var message = MessageResource.Create(
                from: new Twilio.Types.PhoneNumber(from),
                to: new Twilio.Types.PhoneNumber(to),
                body: body);
            if (/*textBox_stdId.Text == "" ||*/ textBox_stdNum.Text == "" || textBox_Message.Text == "")
            {
                MessageBox.Show("You should write number to send!", "Error Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //int studentId = Convert.ToInt32(textBox_stdId.Text);
                int studentNumber = Convert.ToInt32(textBox_stdNum.Text);
                string messag = textBox_Message.Text;
                if (phone.sendPhon(/*studentId,*/ studentNumber))
                {
                    MessageBox.Show("Message sent ssucessfully", "Sending", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You should write number to send and select Id!", "Write number!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_phoneSend_Click(object sender, EventArgs e)
        {

        }

        private void Button_sendEmail_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient("smtp.mail.yahoo.com", 587);
            client.Credentials = new NetworkCredential(textBox_Message.Text,textBox_email.Text);
            client.EnableSsl = true;
            MailMessage message1 = new MailMessage(textBox_email.Text, textBox_Message.Text)
            {
                IsBodyHtml = false
            };
            client.Send(message1);
            MessageBox.Show("The message send to the email successfully");
            
        }
    }
}
