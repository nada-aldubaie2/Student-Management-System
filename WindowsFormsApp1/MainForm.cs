using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        StudentClass student = new StudentClass();
        public MainForm()
        {
            InitializeComponent();
        }

        //visiblity of panel
        private void customizeDesign()
        {
            panel_studentmenu.Visible = false;
            panel_studendMenu2.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panel_studentmenu.Visible == true)
                panel_studentmenu.Visible = false;
            if (panel_studendMenu2.Visible == true)
                panel_studentmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }


        //buttons of submenus



        private void Btn_Subjects_Click(object sender, EventArgs e)
        {
            SubjectForm sub = new SubjectForm();
            sub.Show();
            this.Hide();
            hideSubmenu();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //openChildForm(new Studens_Regsration());
        }

        private void Btn_marks_Click(object sender, EventArgs e)
        {
            Studens_Regsration form2 = new Studens_Regsration();
            form2.Show();
            this.Hide();
            hideSubmenu();
        }

        private void Btn_university_Click(object sender, EventArgs e)
        {
            openChildForm(new Studens_Regsration());
            hideSubmenu();
        }

        private void Btn_resultCommunicate_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_studendMenu2);
        }

        private void Btn_stdresult_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

      

        private void Btn_PhoneSend_Click(object sender, EventArgs e)
        {
            SendForm phone = new SendForm();
            phone.Show();
            this.Hide();
            hideSubmenu();
        }

        private void Btn_GmailSend_Click(object sender, EventArgs e)
        {
            SendForm phone = new SendForm();
            phone.Show();
            this.Hide();
            hideSubmenu();

            hideSubmenu();
        }

        private void Btn_studentRegstration_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_studentmenu);
           
        }


    //to show resteration in mainForm
    private Form activeForm = null;
    private void openChildForm(Form childForm)
    {
        if (activeForm != null)
            activeForm.Close();
        activeForm = childForm;
        activeForm.TopLevel = false;
        activeForm.FormBorderStyle = FormBorderStyle.None;
        activeForm.Dock = DockStyle.Fill;
        panel_main.Controls.Add(childForm);
        panel_main.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
        }

      

        private void Bt_Result_Click(object sender, EventArgs e)
        {
            openChildForm(new ResultForm());
        }

        private void Bt_Result_Click_1(object sender, EventArgs e)
        {
            ResultForm scor = new ResultForm();
            scor.Show();
            this.Hide();
            hideSubmenu();
        }

        private void Btn_studentRegstration_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panel_studentmenu);
        }

        private void Btn_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
