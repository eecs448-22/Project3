namespace SRMS
{
    partial class StudentUI
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
            this.tabControl_studentInfo = new System.Windows.Forms.TabControl();
            this.tabPage_welcome = new System.Windows.Forms.TabPage();
            this.label_enrollment = new System.Windows.Forms.Label();
            this.label_classes = new System.Windows.Forms.Label();
            this.label_accInfo = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label_welcome = new System.Windows.Forms.Label();
            this.tabPage_accInfo = new System.Windows.Forms.TabPage();
            this.showPW = new System.Windows.Forms.CheckBox();
            this.label_heading = new System.Windows.Forms.Label();
            this.editInfoBtn = new System.Windows.Forms.Button();
            this.textBox_Major = new System.Windows.Forms.TextBox();
            this.label_major = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_lastName = new System.Windows.Forms.Label();
            this.label_firstName = new System.Windows.Forms.Label();
            this.tabPage_classes = new System.Windows.Forms.TabPage();
            this.dropEnrollBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.tabPage_enrollment = new System.Windows.Forms.TabPage();
            this.enrollAddBtn = new System.Windows.Forms.Button();
            this.lblEnrollment = new System.Windows.Forms.Label();
            this.dgvEnrollment = new System.Windows.Forms.DataGridView();
            this.label_selectSemester = new System.Windows.Forms.Label();
            this.comboBox_selectSemester = new System.Windows.Forms.ComboBox();
            this.label_enrollmentScreen = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_logOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.calender = new System.Windows.Forms.MonthCalendar();
            this.tabControl_studentInfo.SuspendLayout();
            this.tabPage_welcome.SuspendLayout();
            this.tabPage_accInfo.SuspendLayout();
            this.tabPage_classes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.tabPage_enrollment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_studentInfo
            // 
            this.tabControl_studentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_studentInfo.Controls.Add(this.tabPage_welcome);
            this.tabControl_studentInfo.Controls.Add(this.tabPage_accInfo);
            this.tabControl_studentInfo.Controls.Add(this.tabPage_classes);
            this.tabControl_studentInfo.Controls.Add(this.tabPage_enrollment);
            this.tabControl_studentInfo.Location = new System.Drawing.Point(327, 62);
            this.tabControl_studentInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_studentInfo.Name = "tabControl_studentInfo";
            this.tabControl_studentInfo.SelectedIndex = 0;
            this.tabControl_studentInfo.Size = new System.Drawing.Size(857, 489);
            this.tabControl_studentInfo.TabIndex = 0;
            // 
            // tabPage_welcome
            // 
            this.tabPage_welcome.Controls.Add(this.label_enrollment);
            this.tabPage_welcome.Controls.Add(this.label_classes);
            this.tabPage_welcome.Controls.Add(this.label_accInfo);
            this.tabPage_welcome.Controls.Add(this.nameLabel);
            this.tabPage_welcome.Controls.Add(this.labelName);
            this.tabPage_welcome.Controls.Add(this.label_welcome);
            this.tabPage_welcome.Location = new System.Drawing.Point(4, 25);
            this.tabPage_welcome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_welcome.Name = "tabPage_welcome";
            this.tabPage_welcome.Size = new System.Drawing.Size(849, 460);
            this.tabPage_welcome.TabIndex = 2;
            this.tabPage_welcome.Text = "Welcome";
            this.tabPage_welcome.UseVisualStyleBackColor = true;
            this.tabPage_welcome.Click += new System.EventHandler(this.tabPage_welcome_Click);
            // 
            // label_enrollment
            // 
            this.label_enrollment.AutoSize = true;
            this.label_enrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_enrollment.Location = new System.Drawing.Point(110, 300);
            this.label_enrollment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_enrollment.Name = "label_enrollment";
            this.label_enrollment.Size = new System.Drawing.Size(555, 25);
            this.label_enrollment.TabIndex = 3;
            this.label_enrollment.Text = "Select the \"Enrollment\" tab to enroll in classes for the semester.";
            this.label_enrollment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_classes
            // 
            this.label_classes.AutoSize = true;
            this.label_classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_classes.Location = new System.Drawing.Point(96, 245);
            this.label_classes.Name = "label_classes";
            this.label_classes.Size = new System.Drawing.Size(587, 25);
            this.label_classes.TabIndex = 2;
            this.label_classes.Text = "Select the \"Classes\" tab to view your enrolled classes and grades. ";
            this.label_classes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_accInfo
            // 
            this.label_accInfo.AutoSize = true;
            this.label_accInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_accInfo.Location = new System.Drawing.Point(56, 191);
            this.label_accInfo.Name = "label_accInfo";
            this.label_accInfo.Size = new System.Drawing.Size(690, 25);
            this.label_accInfo.TabIndex = 1;
            this.label_accInfo.Text = "Select the \"Account Information\" tab to view and edit your personal information.";
            this.label_accInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(427, 86);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 62);
            this.nameLabel.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(440, 76);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(327, 62);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "{placeHolder}";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.Location = new System.Drawing.Point(214, 76);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(220, 62);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Welcome";
            // 
            // tabPage_accInfo
            // 
            this.tabPage_accInfo.Controls.Add(this.showPW);
            this.tabPage_accInfo.Controls.Add(this.label_heading);
            this.tabPage_accInfo.Controls.Add(this.editInfoBtn);
            this.tabPage_accInfo.Controls.Add(this.textBox_Major);
            this.tabPage_accInfo.Controls.Add(this.label_major);
            this.tabPage_accInfo.Controls.Add(this.textBox_password);
            this.tabPage_accInfo.Controls.Add(this.textBox_Email);
            this.tabPage_accInfo.Controls.Add(this.label_password);
            this.tabPage_accInfo.Controls.Add(this.label_email);
            this.tabPage_accInfo.Controls.Add(this.textBox_username);
            this.tabPage_accInfo.Controls.Add(this.label_username);
            this.tabPage_accInfo.Controls.Add(this.textBox_id);
            this.tabPage_accInfo.Controls.Add(this.textBox_lastName);
            this.tabPage_accInfo.Controls.Add(this.textBox_firstName);
            this.tabPage_accInfo.Controls.Add(this.label_id);
            this.tabPage_accInfo.Controls.Add(this.label_lastName);
            this.tabPage_accInfo.Controls.Add(this.label_firstName);
            this.tabPage_accInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPage_accInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_accInfo.Name = "tabPage_accInfo";
            this.tabPage_accInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_accInfo.Size = new System.Drawing.Size(849, 460);
            this.tabPage_accInfo.TabIndex = 0;
            this.tabPage_accInfo.Text = "Account Information";
            this.tabPage_accInfo.UseVisualStyleBackColor = true;
            this.tabPage_accInfo.Click += new System.EventHandler(this.tabPage_accInfo_Click);
            // 
            // showPW
            // 
            this.showPW.AutoSize = true;
            this.showPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPW.Location = new System.Drawing.Point(541, 179);
            this.showPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showPW.Name = "showPW";
            this.showPW.Size = new System.Drawing.Size(175, 29);
            this.showPW.TabIndex = 13;
            this.showPW.Text = "Show Password";
            this.showPW.UseVisualStyleBackColor = true;
            this.showPW.CheckedChanged += new System.EventHandler(this.showPW_CheckedChanged_1);
            // 
            // label_heading
            // 
            this.label_heading.AutoSize = true;
            this.label_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_heading.Location = new System.Drawing.Point(46, 75);
            this.label_heading.Name = "label_heading";
            this.label_heading.Size = new System.Drawing.Size(325, 38);
            this.label_heading.TabIndex = 11;
            this.label_heading.Text = "Account Information";
            // 
            // editInfoBtn
            // 
            this.editInfoBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.editInfoBtn.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInfoBtn.Location = new System.Drawing.Point(302, 337);
            this.editInfoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editInfoBtn.Name = "editInfoBtn";
            this.editInfoBtn.Size = new System.Drawing.Size(193, 46);
            this.editInfoBtn.TabIndex = 10;
            this.editInfoBtn.Text = "Edit";
            this.editInfoBtn.UseVisualStyleBackColor = false;
            this.editInfoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Major
            // 
            this.textBox_Major.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Major.Location = new System.Drawing.Point(541, 283);
            this.textBox_Major.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Major.Name = "textBox_Major";
            this.textBox_Major.ReadOnly = true;
            this.textBox_Major.Size = new System.Drawing.Size(230, 30);
            this.textBox_Major.TabIndex = 9;
            // 
            // label_major
            // 
            this.label_major.AutoSize = true;
            this.label_major.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_major.Location = new System.Drawing.Point(423, 280);
            this.label_major.Name = "label_major";
            this.label_major.Size = new System.Drawing.Size(61, 25);
            this.label_major.TabIndex = 8;
            this.label_major.Text = "Major";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(541, 128);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.ReadOnly = true;
            this.textBox_password.Size = new System.Drawing.Size(230, 30);
            this.textBox_password.TabIndex = 9;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(541, 227);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.ReadOnly = true;
            this.textBox_Email.Size = new System.Drawing.Size(230, 30);
            this.textBox_Email.TabIndex = 7;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(420, 133);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(98, 25);
            this.label_password.TabIndex = 8;
            this.label_password.Text = "Password";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(423, 230);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(60, 25);
            this.label_email.TabIndex = 6;
            this.label_email.Text = "Email";
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(171, 280);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.ReadOnly = true;
            this.textBox_username.Size = new System.Drawing.Size(230, 30);
            this.textBox_username.TabIndex = 7;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(48, 283);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(102, 25);
            this.label_username.TabIndex = 6;
            this.label_username.Text = "Username";
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(171, 225);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(230, 30);
            this.textBox_id.TabIndex = 5;
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lastName.Location = new System.Drawing.Point(171, 177);
            this.textBox_lastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.ReadOnly = true;
            this.textBox_lastName.Size = new System.Drawing.Size(230, 30);
            this.textBox_lastName.TabIndex = 4;
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_firstName.Location = new System.Drawing.Point(171, 130);
            this.textBox_firstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.ReadOnly = true;
            this.textBox_firstName.Size = new System.Drawing.Size(230, 30);
            this.textBox_firstName.TabIndex = 3;
            this.textBox_firstName.TextChanged += new System.EventHandler(this.textBox_firstName_TextChanged);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(44, 230);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(104, 25);
            this.label_id.TabIndex = 2;
            this.label_id.Text = "Student ID";
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastName.Location = new System.Drawing.Point(44, 182);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(106, 25);
            this.label_lastName.TabIndex = 1;
            this.label_lastName.Text = "Last Name";
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstName.Location = new System.Drawing.Point(44, 133);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(106, 25);
            this.label_firstName.TabIndex = 0;
            this.label_firstName.Text = "First Name";
            // 
            // tabPage_classes
            // 
            this.tabPage_classes.Controls.Add(this.dropEnrollBtn);
            this.tabPage_classes.Controls.Add(this.label1);
            this.tabPage_classes.Controls.Add(this.dgvClasses);
            this.tabPage_classes.Location = new System.Drawing.Point(4, 25);
            this.tabPage_classes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_classes.Name = "tabPage_classes";
            this.tabPage_classes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_classes.Size = new System.Drawing.Size(849, 460);
            this.tabPage_classes.TabIndex = 1;
            this.tabPage_classes.Text = "Classes";
            this.tabPage_classes.UseVisualStyleBackColor = true;
            // 
            // dropEnrollBtn
            // 
            this.dropEnrollBtn.Location = new System.Drawing.Point(335, 352);
            this.dropEnrollBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dropEnrollBtn.Name = "dropEnrollBtn";
            this.dropEnrollBtn.Size = new System.Drawing.Size(160, 49);
            this.dropEnrollBtn.TabIndex = 18;
            this.dropEnrollBtn.Text = "Drop";
            this.dropEnrollBtn.UseVisualStyleBackColor = true;
            this.dropEnrollBtn.Click += new System.EventHandler(this.dropEnrollBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Classes";
            // 
            // dgvClasses
            // 
            this.dgvClasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(132, 121);
            this.dgvClasses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersWidth = 51;
            this.dgvClasses.RowTemplate.Height = 24;
            this.dgvClasses.Size = new System.Drawing.Size(571, 196);
            this.dgvClasses.TabIndex = 0;
            this.dgvClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellContentClick);
            // 
            // tabPage_enrollment
            // 
            this.tabPage_enrollment.Controls.Add(this.enrollAddBtn);
            this.tabPage_enrollment.Controls.Add(this.lblEnrollment);
            this.tabPage_enrollment.Controls.Add(this.dgvEnrollment);
            this.tabPage_enrollment.Controls.Add(this.label_selectSemester);
            this.tabPage_enrollment.Controls.Add(this.comboBox_selectSemester);
            this.tabPage_enrollment.Controls.Add(this.label_enrollmentScreen);
            this.tabPage_enrollment.Location = new System.Drawing.Point(4, 25);
            this.tabPage_enrollment.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_enrollment.Name = "tabPage_enrollment";
            this.tabPage_enrollment.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_enrollment.Size = new System.Drawing.Size(849, 460);
            this.tabPage_enrollment.TabIndex = 3;
            this.tabPage_enrollment.Tag = "Maggie";
            this.tabPage_enrollment.Text = "Enrollment";
            this.tabPage_enrollment.UseVisualStyleBackColor = true;
            this.tabPage_enrollment.Click += new System.EventHandler(this.tabPage_enrollment_Click);
            // 
            // enrollAddBtn
            // 
            this.enrollAddBtn.Location = new System.Drawing.Point(350, 378);
            this.enrollAddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enrollAddBtn.Name = "enrollAddBtn";
            this.enrollAddBtn.Size = new System.Drawing.Size(141, 54);
            this.enrollAddBtn.TabIndex = 17;
            this.enrollAddBtn.Text = "Add";
            this.enrollAddBtn.UseVisualStyleBackColor = true;
            this.enrollAddBtn.Click += new System.EventHandler(this.enrollAddBtn_Click);
            // 
            // lblEnrollment
            // 
            this.lblEnrollment.AutoSize = true;
            this.lblEnrollment.Location = new System.Drawing.Point(114, 142);
            this.lblEnrollment.Name = "lblEnrollment";
            this.lblEnrollment.Size = new System.Drawing.Size(386, 16);
            this.lblEnrollment.TabIndex = 16;
            this.lblEnrollment.Text = "Once a semester is selected, offered courses will appear below:";
            // 
            // dgvEnrollment
            // 
            this.dgvEnrollment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrollment.Location = new System.Drawing.Point(117, 171);
            this.dgvEnrollment.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEnrollment.Name = "dgvEnrollment";
            this.dgvEnrollment.RowHeadersWidth = 51;
            this.dgvEnrollment.Size = new System.Drawing.Size(613, 187);
            this.dgvEnrollment.TabIndex = 15;
            this.dgvEnrollment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnrollment_CellContentClick);
            // 
            // label_selectSemester
            // 
            this.label_selectSemester.AutoSize = true;
            this.label_selectSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selectSemester.Location = new System.Drawing.Point(112, 90);
            this.label_selectSemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_selectSemester.Name = "label_selectSemester";
            this.label_selectSemester.Size = new System.Drawing.Size(281, 29);
            this.label_selectSemester.TabIndex = 14;
            this.label_selectSemester.Text = "Select desired semester:";
            // 
            // comboBox_selectSemester
            // 
            this.comboBox_selectSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_selectSemester.FormattingEnabled = true;
            this.comboBox_selectSemester.Items.AddRange(new object[] {
            "Spring2022",
            "Summer2022",
            "Fall2022"});
            this.comboBox_selectSemester.Location = new System.Drawing.Point(409, 86);
            this.comboBox_selectSemester.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_selectSemester.Name = "comboBox_selectSemester";
            this.comboBox_selectSemester.Size = new System.Drawing.Size(209, 37);
            this.comboBox_selectSemester.TabIndex = 13;
            this.comboBox_selectSemester.SelectedIndexChanged += new System.EventHandler(this.comboBox_selectSemester_SelectedIndexChanged);
            // 
            // label_enrollmentScreen
            // 
            this.label_enrollmentScreen.AutoSize = true;
            this.label_enrollmentScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_enrollmentScreen.Location = new System.Drawing.Point(110, 33);
            this.label_enrollmentScreen.Name = "label_enrollmentScreen";
            this.label_enrollmentScreen.Size = new System.Drawing.Size(182, 38);
            this.label_enrollmentScreen.TabIndex = 12;
            this.label_enrollmentScreen.Text = "Enrollment";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(485, 326);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button_logOut
            // 
            this.button_logOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_logOut.Location = new System.Drawing.Point(1088, 22);
            this.button_logOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Size = new System.Drawing.Size(92, 36);
            this.button_logOut.TabIndex = 3;
            this.button_logOut.Text = "Log Out";
            this.button_logOut.UseVisualStyleBackColor = true;
            this.button_logOut.Click += new System.EventHandler(this.button_logOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BackgroundImage = global::SRMS.Properties.Resources.Kansas_Jayhawks_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 183);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "■ Welcome",
            "■ Account Information",
            "■ Classes",
            "■ Enrollment"});
            this.listBox1.Location = new System.Drawing.Point(12, 261);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(303, 68);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // calender
            // 
            this.calender.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calender.Location = new System.Drawing.Point(12, 351);
            this.calender.Name = "calender";
            this.calender.TabIndex = 18;
            this.calender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calender_DateChanged);
            // 
            // StudentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1196, 580);
            this.Controls.Add(this.calender);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_logOut);
            this.Controls.Add(this.tabControl_studentInfo);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentUI";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.StudentUI_Load);
            this.tabControl_studentInfo.ResumeLayout(false);
            this.tabPage_welcome.ResumeLayout(false);
            this.tabPage_welcome.PerformLayout();
            this.tabPage_accInfo.ResumeLayout(false);
            this.tabPage_accInfo.PerformLayout();
            this.tabPage_classes.ResumeLayout(false);
            this.tabPage_classes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.tabPage_enrollment.ResumeLayout(false);
            this.tabPage_enrollment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_studentInfo;
        private System.Windows.Forms.TabPage tabPage_accInfo;
        private System.Windows.Forms.TabPage tabPage_classes;
        private System.Windows.Forms.TabPage tabPage_welcome;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Label label_accInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_classes;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button editInfoBtn;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.Button button_logOut;
        private System.Windows.Forms.Label label_heading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage_enrollment;
        private System.Windows.Forms.Label label_enrollment;
        private System.Windows.Forms.Label label_enrollmentScreen;
        private System.Windows.Forms.ComboBox comboBox_selectSemester;
        private System.Windows.Forms.Label label_selectSemester;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox showPW;
        private System.Windows.Forms.TextBox textBox_Major;
        private System.Windows.Forms.Label label_major;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label lblEnrollment;
        private System.Windows.Forms.Button enrollAddBtn;
        private System.Windows.Forms.MonthCalendar calender;
        private System.Windows.Forms.Button dropEnrollBtn;
        private System.Windows.Forms.DataGridView dgvEnrollment;
    }
}