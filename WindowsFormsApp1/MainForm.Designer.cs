namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_slide = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_studentRegstration = new System.Windows.Forms.Button();
            this.panel_studentmenu = new System.Windows.Forms.Panel();
            this.btn_stdReglist = new System.Windows.Forms.Button();
            this.bt_Result = new System.Windows.Forms.Button();
            this.btn_registerStd = new System.Windows.Forms.Button();
            this.btn_Subjects = new System.Windows.Forms.Button();
            this.btn_resultCommunicate = new System.Windows.Forms.Button();
            this.panel_studendMenu2 = new System.Windows.Forms.Panel();
            this.btn_GmailSend = new System.Windows.Forms.Button();
            this.btn_PhoneSend = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_university = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تصديرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استعادةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_femalestd = new System.Windows.Forms.Label();
            this.label_malestd = new System.Windows.Forms.Label();
            this.label_totalstd = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_logo.SuspendLayout();
            this.Panel_slide.SuspendLayout();
            this.panel_studentmenu.SuspendLayout();
            this.panel_studendMenu2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.label2);
            this.panel_logo.Controls.Add(this.label1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(3, 3);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(233, 122);
            this.panel_logo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "نظام قاعدة بيانات شؤون الطلاب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "SDBS";
            // 
            // Panel_slide
            // 
            this.Panel_slide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_slide.AutoScroll = true;
            this.Panel_slide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Panel_slide.Controls.Add(this.panel_logo);
            this.Panel_slide.Controls.Add(this.btn_studentRegstration);
            this.Panel_slide.Controls.Add(this.panel_studentmenu);
            this.Panel_slide.Controls.Add(this.btn_resultCommunicate);
            this.Panel_slide.Controls.Add(this.panel_studendMenu2);
            this.Panel_slide.Controls.Add(this.btn_Exit);
            this.Panel_slide.Location = new System.Drawing.Point(1210, 4);
            this.Panel_slide.Name = "Panel_slide";
            this.Panel_slide.Size = new System.Drawing.Size(240, 787);
            this.Panel_slide.TabIndex = 1;
            // 
            // btn_studentRegstration
            // 
            this.btn_studentRegstration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_studentRegstration.FlatAppearance.BorderSize = 0;
            this.btn_studentRegstration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_studentRegstration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_studentRegstration.ForeColor = System.Drawing.Color.White;
            this.btn_studentRegstration.Location = new System.Drawing.Point(3, 131);
            this.btn_studentRegstration.Name = "btn_studentRegstration";
            this.btn_studentRegstration.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btn_studentRegstration.Size = new System.Drawing.Size(233, 55);
            this.btn_studentRegstration.TabIndex = 0;
            this.btn_studentRegstration.Text = "التسجيل";
            this.btn_studentRegstration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_studentRegstration.UseVisualStyleBackColor = true;
            this.btn_studentRegstration.Click += new System.EventHandler(this.Btn_studentRegstration_Click_1);
            // 
            // panel_studentmenu
            // 
            this.panel_studentmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(175)))));
            this.panel_studentmenu.Controls.Add(this.btn_stdReglist);
            this.panel_studentmenu.Controls.Add(this.bt_Result);
            this.panel_studentmenu.Controls.Add(this.btn_registerStd);
            this.panel_studentmenu.Controls.Add(this.btn_Subjects);
            this.panel_studentmenu.Location = new System.Drawing.Point(3, 192);
            this.panel_studentmenu.Name = "panel_studentmenu";
            this.panel_studentmenu.Size = new System.Drawing.Size(233, 199);
            this.panel_studentmenu.TabIndex = 1;
            // 
            // btn_stdReglist
            // 
            this.btn_stdReglist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_stdReglist.FlatAppearance.BorderSize = 0;
            this.btn_stdReglist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stdReglist.ForeColor = System.Drawing.Color.White;
            this.btn_stdReglist.Location = new System.Drawing.Point(0, 150);
            this.btn_stdReglist.Name = "btn_stdReglist";
            this.btn_stdReglist.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btn_stdReglist.Size = new System.Drawing.Size(233, 50);
            this.btn_stdReglist.TabIndex = 3;
            this.btn_stdReglist.Text = "سجل الطلبة";
            this.btn_stdReglist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_stdReglist.UseVisualStyleBackColor = true;
            this.btn_stdReglist.Click += new System.EventHandler(this.Btn_university_Click);
            // 
            // bt_Result
            // 
            this.bt_Result.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Result.FlatAppearance.BorderSize = 0;
            this.bt_Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Result.ForeColor = System.Drawing.Color.White;
            this.bt_Result.Location = new System.Drawing.Point(0, 100);
            this.bt_Result.Name = "bt_Result";
            this.bt_Result.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.bt_Result.Size = new System.Drawing.Size(233, 50);
            this.bt_Result.TabIndex = 2;
            this.bt_Result.Text = "النتيجة";
            this.bt_Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Result.UseVisualStyleBackColor = true;
            this.bt_Result.Click += new System.EventHandler(this.Bt_Result_Click_1);
            // 
            // btn_registerStd
            // 
            this.btn_registerStd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_registerStd.FlatAppearance.BorderSize = 0;
            this.btn_registerStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registerStd.ForeColor = System.Drawing.Color.White;
            this.btn_registerStd.Location = new System.Drawing.Point(0, 50);
            this.btn_registerStd.Name = "btn_registerStd";
            this.btn_registerStd.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btn_registerStd.Size = new System.Drawing.Size(233, 50);
            this.btn_registerStd.TabIndex = 1;
            this.btn_registerStd.Text = "تسجيل طالب جديد";
            this.btn_registerStd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_registerStd.UseVisualStyleBackColor = true;
            this.btn_registerStd.Click += new System.EventHandler(this.Btn_marks_Click);
            // 
            // btn_Subjects
            // 
            this.btn_Subjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Subjects.FlatAppearance.BorderSize = 0;
            this.btn_Subjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Subjects.ForeColor = System.Drawing.Color.White;
            this.btn_Subjects.Location = new System.Drawing.Point(0, 0);
            this.btn_Subjects.Name = "btn_Subjects";
            this.btn_Subjects.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btn_Subjects.Size = new System.Drawing.Size(233, 50);
            this.btn_Subjects.TabIndex = 0;
            this.btn_Subjects.Text = "المواد";
            this.btn_Subjects.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Subjects.UseVisualStyleBackColor = true;
            this.btn_Subjects.Click += new System.EventHandler(this.Btn_Subjects_Click);
            // 
            // btn_resultCommunicate
            // 
            this.btn_resultCommunicate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_resultCommunicate.FlatAppearance.BorderSize = 0;
            this.btn_resultCommunicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resultCommunicate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resultCommunicate.ForeColor = System.Drawing.Color.White;
            this.btn_resultCommunicate.Location = new System.Drawing.Point(3, 397);
            this.btn_resultCommunicate.Name = "btn_resultCommunicate";
            this.btn_resultCommunicate.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btn_resultCommunicate.Size = new System.Drawing.Size(233, 55);
            this.btn_resultCommunicate.TabIndex = 2;
            this.btn_resultCommunicate.Text = "الجامعة و التواصل";
            this.btn_resultCommunicate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_resultCommunicate.UseVisualStyleBackColor = true;
            this.btn_resultCommunicate.Click += new System.EventHandler(this.Btn_resultCommunicate_Click);
            // 
            // panel_studendMenu2
            // 
            this.panel_studendMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(175)))));
            this.panel_studendMenu2.Controls.Add(this.btn_GmailSend);
            this.panel_studendMenu2.Controls.Add(this.btn_PhoneSend);
            this.panel_studendMenu2.Controls.Add(this.btn_print);
            this.panel_studendMenu2.Controls.Add(this.btn_university);
            this.panel_studendMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_studendMenu2.Location = new System.Drawing.Point(3, 458);
            this.panel_studendMenu2.Name = "panel_studendMenu2";
            this.panel_studendMenu2.Size = new System.Drawing.Size(233, 199);
            this.panel_studendMenu2.TabIndex = 3;
            // 
            // btn_GmailSend
            // 
            this.btn_GmailSend.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GmailSend.FlatAppearance.BorderSize = 0;
            this.btn_GmailSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GmailSend.ForeColor = System.Drawing.Color.White;
            this.btn_GmailSend.Location = new System.Drawing.Point(0, 150);
            this.btn_GmailSend.Name = "btn_GmailSend";
            this.btn_GmailSend.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btn_GmailSend.Size = new System.Drawing.Size(233, 50);
            this.btn_GmailSend.TabIndex = 3;
            this.btn_GmailSend.Text = "ارسال رسالة الى ايميل الطالب/ة ";
            this.btn_GmailSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GmailSend.UseVisualStyleBackColor = true;
            this.btn_GmailSend.Click += new System.EventHandler(this.Btn_GmailSend_Click);
            // 
            // btn_PhoneSend
            // 
            this.btn_PhoneSend.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PhoneSend.FlatAppearance.BorderSize = 0;
            this.btn_PhoneSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PhoneSend.ForeColor = System.Drawing.Color.White;
            this.btn_PhoneSend.Location = new System.Drawing.Point(0, 100);
            this.btn_PhoneSend.Name = "btn_PhoneSend";
            this.btn_PhoneSend.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btn_PhoneSend.Size = new System.Drawing.Size(233, 50);
            this.btn_PhoneSend.TabIndex = 2;
            this.btn_PhoneSend.Text = "ارسال رسالة الى هاتف الطالب/ة ";
            this.btn_PhoneSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PhoneSend.UseVisualStyleBackColor = true;
            this.btn_PhoneSend.Click += new System.EventHandler(this.Btn_PhoneSend_Click);
            // 
            // btn_print
            // 
            this.btn_print.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(0, 50);
            this.btn_print.Name = "btn_print";
            this.btn_print.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btn_print.Size = new System.Drawing.Size(233, 50);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "طباعة تقرير";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // btn_university
            // 
            this.btn_university.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_university.FlatAppearance.BorderSize = 0;
            this.btn_university.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_university.ForeColor = System.Drawing.Color.White;
            this.btn_university.Location = new System.Drawing.Point(0, 0);
            this.btn_university.Name = "btn_university";
            this.btn_university.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btn_university.Size = new System.Drawing.Size(233, 50);
            this.btn_university.TabIndex = 0;
            this.btn_university.Text = "الجامعة";
            this.btn_university.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_university.UseVisualStyleBackColor = true;
            this.btn_university.Click += new System.EventHandler(this.Btn_stdresult_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(3, 663);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Padding = new System.Windows.Forms.Padding(0, 0, 70, 0);
            this.btn_Exit.Size = new System.Drawing.Size(233, 55);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "الخروج";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(175)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1449, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(153, 28);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(153, 28);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تصديرToolStripMenuItem,
            this.استعادةToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(53, 27);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // تصديرToolStripMenuItem
            // 
            this.تصديرToolStripMenuItem.Name = "تصديرToolStripMenuItem";
            this.تصديرToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.تصديرToolStripMenuItem.Text = "تصدير";
            // 
            // استعادةToolStripMenuItem
            // 
            this.استعادةToolStripMenuItem.Name = "استعادةToolStripMenuItem";
            this.استعادةToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.استعادةToolStripMenuItem.Text = "استعادة";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label_femalestd);
            this.panel1.Controls.Add(this.label_malestd);
            this.panel1.Controls.Add(this.label_totalstd);
            this.panel1.Location = new System.Drawing.Point(-13, 612);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 120);
            this.panel1.TabIndex = 9;
            // 
            // label_femalestd
            // 
            this.label_femalestd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_femalestd.AutoSize = true;
            this.label_femalestd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_femalestd.ForeColor = System.Drawing.Color.White;
            this.label_femalestd.Location = new System.Drawing.Point(1040, 63);
            this.label_femalestd.Name = "label_femalestd";
            this.label_femalestd.Size = new System.Drawing.Size(47, 20);
            this.label_femalestd.TabIndex = 3;
            this.label_femalestd.Text = "الاناث";
            // 
            // label_malestd
            // 
            this.label_malestd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_malestd.AutoSize = true;
            this.label_malestd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_malestd.ForeColor = System.Drawing.Color.White;
            this.label_malestd.Location = new System.Drawing.Point(1127, 63);
            this.label_malestd.Name = "label_malestd";
            this.label_malestd.Size = new System.Drawing.Size(51, 20);
            this.label_malestd.TabIndex = 2;
            this.label_malestd.Text = "الذكور";
            // 
            // label_totalstd
            // 
            this.label_totalstd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_totalstd.AutoSize = true;
            this.label_totalstd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalstd.ForeColor = System.Drawing.Color.White;
            this.label_totalstd.Location = new System.Drawing.Point(1118, 14);
            this.label_totalstd.Name = "label_totalstd";
            this.label_totalstd.Size = new System.Drawing.Size(83, 20);
            this.label_totalstd.TabIndex = 1;
            this.label_totalstd.Text = ":عدد الطلبة";
            // 
            // panel_main
            // 
            this.panel_main.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(175)))));
            this.panel_main.Controls.Add(this.panel2);
            this.panel_main.Location = new System.Drawing.Point(0, 28);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1210, 188);
            this.panel_main.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1210, 399);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.FB_IMG_1682562275328;
            this.pictureBox1.Location = new System.Drawing.Point(0, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1210, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 728);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_slide);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Student Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            this.Panel_slide.ResumeLayout(false);
            this.panel_studentmenu.ResumeLayout(false);
            this.panel_studendMenu2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.FlowLayoutPanel Panel_slide;
        private System.Windows.Forms.Button btn_studentRegstration;
        private System.Windows.Forms.Panel panel_studentmenu;
        private System.Windows.Forms.Button btn_stdReglist;
        private System.Windows.Forms.Button bt_Result;
        private System.Windows.Forms.Button btn_registerStd;
        private System.Windows.Forms.Button btn_Subjects;
        private System.Windows.Forms.Button btn_resultCommunicate;
        private System.Windows.Forms.Panel panel_studendMenu2;
        private System.Windows.Forms.Button btn_GmailSend;
        private System.Windows.Forms.Button btn_PhoneSend;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_university;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تصديرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem استعادةToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_femalestd;
        private System.Windows.Forms.Label label_malestd;
        private System.Windows.Forms.Label label_totalstd;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

