/* =============================================================================
 * Code in this file is generated from the visual studio .NET C# winForms framework. 
 * ============================================================================= */

namespace SRMS
{
    partial class FacultyUI
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
            this.components = new System.ComponentModel.Container();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GradeTab = new System.Windows.Forms.TabPage();
            this.studentsLb = new System.Windows.Forms.Label();
            this.editCourseBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvGradebook = new System.Windows.Forms.DataGridView();
            this.Courselbl = new System.Windows.Forms.Label();
            this.CourseCboBox = new System.Windows.Forms.ComboBox();
            this.CourseTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.personalInfoTab = new System.Windows.Forms.TabPage();
            this.welcomeNameLb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.userInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.editAcctInfoBtn = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.Label();
            this.departmentText = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.Label();
            this.facultyIdText = new System.Windows.Forms.Label();
            this.showPassCB = new System.Windows.Forms.CheckBox();
            this.departmentLb = new System.Windows.Forms.Label();
            this.usernameLb = new System.Windows.Forms.Label();
            this.emailLb = new System.Windows.Forms.Label();
            this.lastNameLb = new System.Windows.Forms.Label();
            this.passwordLb = new System.Windows.Forms.Label();
            this.facultyIdLb = new System.Windows.Forms.Label();
            this.firstNameLb = new System.Windows.Forms.Label();
            this.acctInfoLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GradeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradebook)).BeginInit();
            this.CourseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.personalInfoTab.SuspendLayout();
            this.userInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.Location = new System.Drawing.Point(691, 23);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(74, 32);
            this.logOutBtn.TabIndex = 3;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BackgroundImage = global::SRMS.Properties.Resources.Kansas_Jayhawks_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(33, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 110);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "■ Home",
            "■ Course",
            "■ Gradebook"});
            this.listBox1.Location = new System.Drawing.Point(33, 190);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 56);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // GradeTab
            // 
            this.GradeTab.Controls.Add(this.studentsLb);
            this.GradeTab.Controls.Add(this.editCourseBtn);
            this.GradeTab.Controls.Add(this.label3);
            this.GradeTab.Controls.Add(this.label2);
            this.GradeTab.Controls.Add(this.dgvGradebook);
            this.GradeTab.Controls.Add(this.Courselbl);
            this.GradeTab.Controls.Add(this.CourseCboBox);
            this.GradeTab.Location = new System.Drawing.Point(4, 25);
            this.GradeTab.Name = "GradeTab";
            this.GradeTab.Size = new System.Drawing.Size(533, 307);
            this.GradeTab.TabIndex = 3;
            this.GradeTab.Text = "Gradebook";
            this.GradeTab.UseVisualStyleBackColor = true;
            // 
            // studentsLb
            // 
            this.studentsLb.AutoSize = true;
            this.studentsLb.Location = new System.Drawing.Point(27, 48);
            this.studentsLb.Name = "studentsLb";
            this.studentsLb.Size = new System.Drawing.Size(68, 17);
            this.studentsLb.TabIndex = 7;
            this.studentsLb.Text = "Students:";
            // 
            // editCourseBtn
            // 
            this.editCourseBtn.Location = new System.Drawing.Point(395, 12);
            this.editCourseBtn.Name = "editCourseBtn";
            this.editCourseBtn.Size = new System.Drawing.Size(96, 23);
            this.editCourseBtn.TabIndex = 6;
            this.editCourseBtn.Text = "Edit Course";
            this.editCourseBtn.UseVisualStyleBackColor = true;
            this.editCourseBtn.Click += new System.EventHandler(this.editCourseBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // dgvGradebook
            // 
            this.dgvGradebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradebook.Location = new System.Drawing.Point(22, 68);
            this.dgvGradebook.Name = "dgvGradebook";
            this.dgvGradebook.RowHeadersWidth = 51;
            this.dgvGradebook.Size = new System.Drawing.Size(492, 179);
            this.dgvGradebook.TabIndex = 2;
            // 
            // Courselbl
            // 
            this.Courselbl.AutoSize = true;
            this.Courselbl.Location = new System.Drawing.Point(34, 15);
            this.Courselbl.Name = "Courselbl";
            this.Courselbl.Size = new System.Drawing.Size(61, 17);
            this.Courselbl.TabIndex = 1;
            this.Courselbl.Text = "Course: ";
            // 
            // CourseCboBox
            // 
            this.CourseCboBox.FormattingEnabled = true;
            this.CourseCboBox.Location = new System.Drawing.Point(101, 12);
            this.CourseCboBox.Name = "CourseCboBox";
            this.CourseCboBox.Size = new System.Drawing.Size(199, 24);
            this.CourseCboBox.TabIndex = 0;
            this.CourseCboBox.SelectedIndexChanged += new System.EventHandler(this.CourseCboBox_SelectedIndexChanged);
            // 
            // CourseTab
            // 
            this.CourseTab.Controls.Add(this.label1);
            this.CourseTab.Controls.Add(this.CourseLabel);
            this.CourseTab.Controls.Add(this.dgvClasses);
            this.CourseTab.Location = new System.Drawing.Point(4, 25);
            this.CourseTab.Name = "CourseTab";
            this.CourseTab.Padding = new System.Windows.Forms.Padding(3);
            this.CourseTab.Size = new System.Drawing.Size(533, 307);
            this.CourseTab.TabIndex = 1;
            this.CourseTab.Text = "Courses";
            this.CourseTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.CourseLabel.Location = new System.Drawing.Point(38, 21);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(110, 29);
            this.CourseLabel.TabIndex = 1;
            this.CourseLabel.Text = "Courses";
            // 
            // dgvClasses
            // 
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(13, 70);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersWidth = 51;
            this.dgvClasses.Size = new System.Drawing.Size(501, 171);
            this.dgvClasses.TabIndex = 0;
            // 
            // personalInfoTab
            // 
            this.personalInfoTab.Controls.Add(this.welcomeNameLb);
            this.personalInfoTab.Controls.Add(this.label6);
            this.personalInfoTab.Controls.Add(this.label5);
            this.personalInfoTab.Controls.Add(this.label4);
            this.personalInfoTab.Controls.Add(this.welcomeLbl);
            this.personalInfoTab.Location = new System.Drawing.Point(4, 25);
            this.personalInfoTab.Name = "personalInfoTab";
            this.personalInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.personalInfoTab.Size = new System.Drawing.Size(533, 307);
            this.personalInfoTab.TabIndex = 0;
            this.personalInfoTab.Text = "Home";
            this.personalInfoTab.UseVisualStyleBackColor = true;
            // 
            // welcomeNameLb
            // 
            this.welcomeNameLb.AutoSize = true;
            this.welcomeNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.welcomeNameLb.Location = new System.Drawing.Point(168, 36);
            this.welcomeNameLb.Name = "welcomeNameLb";
            this.welcomeNameLb.Size = new System.Drawing.Size(116, 29);
            this.welcomeNameLb.TabIndex = 5;
            this.welcomeNameLb.Text = "{Faculty}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(390, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Select \"Account Information\" tab to view personal information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(449, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select \"Gradebook\" tab to view class roster and edit semester grades.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select \"Courses\" tab to view your courses.";
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.welcomeLbl.Location = new System.Drawing.Point(27, 36);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(135, 29);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Welcome,";
            // 
            // userInfo
            // 
            this.userInfo.Controls.Add(this.personalInfoTab);
            this.userInfo.Controls.Add(this.CourseTab);
            this.userInfo.Controls.Add(this.GradeTab);
            this.userInfo.Controls.Add(this.tabPage1);
            this.userInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userInfo.Location = new System.Drawing.Point(247, 60);
            this.userInfo.Name = "userInfo";
            this.userInfo.SelectedIndex = 0;
            this.userInfo.Size = new System.Drawing.Size(541, 336);
            this.userInfo.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.editAcctInfoBtn);
            this.tabPage1.Controls.Add(this.passwordText);
            this.tabPage1.Controls.Add(this.departmentText);
            this.tabPage1.Controls.Add(this.emailText);
            this.tabPage1.Controls.Add(this.usernameText);
            this.tabPage1.Controls.Add(this.lastNameText);
            this.tabPage1.Controls.Add(this.firstNameText);
            this.tabPage1.Controls.Add(this.facultyIdText);
            this.tabPage1.Controls.Add(this.showPassCB);
            this.tabPage1.Controls.Add(this.departmentLb);
            this.tabPage1.Controls.Add(this.usernameLb);
            this.tabPage1.Controls.Add(this.emailLb);
            this.tabPage1.Controls.Add(this.lastNameLb);
            this.tabPage1.Controls.Add(this.passwordLb);
            this.tabPage1.Controls.Add(this.facultyIdLb);
            this.tabPage1.Controls.Add(this.firstNameLb);
            this.tabPage1.Controls.Add(this.acctInfoLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(533, 307);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Account Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // editAcctInfoBtn
            // 
            this.editAcctInfoBtn.Location = new System.Drawing.Point(222, 261);
            this.editAcctInfoBtn.Name = "editAcctInfoBtn";
            this.editAcctInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.editAcctInfoBtn.TabIndex = 19;
            this.editAcctInfoBtn.Text = "Edit";
            this.editAcctInfoBtn.UseVisualStyleBackColor = true;
            this.editAcctInfoBtn.Click += new System.EventHandler(this.editAcctInfoBtn_Click);
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Location = new System.Drawing.Point(391, 94);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(79, 17);
            this.passwordText.TabIndex = 18;
            this.passwordText.Text = "{Password}";
            // 
            // departmentText
            // 
            this.departmentText.AutoSize = true;
            this.departmentText.Location = new System.Drawing.Point(391, 208);
            this.departmentText.Name = "departmentText";
            this.departmentText.Size = new System.Drawing.Size(92, 17);
            this.departmentText.TabIndex = 17;
            this.departmentText.Text = "{Department}";
            // 
            // emailText
            // 
            this.emailText.AutoSize = true;
            this.emailText.Location = new System.Drawing.Point(391, 173);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(52, 17);
            this.emailText.TabIndex = 16;
            this.emailText.Text = "{Email}";
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.Location = new System.Drawing.Point(135, 208);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(83, 17);
            this.usernameText.TabIndex = 15;
            this.usernameText.Text = "{Username}";
            // 
            // lastNameText
            // 
            this.lastNameText.AutoSize = true;
            this.lastNameText.Location = new System.Drawing.Point(135, 173);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(86, 17);
            this.lastNameText.TabIndex = 14;
            this.lastNameText.Text = "{Last Name}";
            // 
            // firstNameText
            // 
            this.firstNameText.AutoSize = true;
            this.firstNameText.Location = new System.Drawing.Point(135, 133);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(86, 17);
            this.firstNameText.TabIndex = 13;
            this.firstNameText.Text = "{First Name}";
            // 
            // facultyIdText
            // 
            this.facultyIdText.AutoSize = true;
            this.facultyIdText.Location = new System.Drawing.Point(135, 94);
            this.facultyIdText.Name = "facultyIdText";
            this.facultyIdText.Size = new System.Drawing.Size(78, 17);
            this.facultyIdText.TabIndex = 12;
            this.facultyIdText.Text = "{Faculty Id}";
            // 
            // showPassCB
            // 
            this.showPassCB.AutoSize = true;
            this.showPassCB.Cursor = System.Windows.Forms.Cursors.Default;
            this.showPassCB.Location = new System.Drawing.Point(327, 129);
            this.showPassCB.Name = "showPassCB";
            this.showPassCB.Size = new System.Drawing.Size(126, 21);
            this.showPassCB.TabIndex = 11;
            this.showPassCB.Text = "Show Password";
            this.showPassCB.UseVisualStyleBackColor = true;
            this.showPassCB.CheckedChanged += new System.EventHandler(this.showPassCB_CheckedChanged);
            // 
            // departmentLb
            // 
            this.departmentLb.AutoSize = true;
            this.departmentLb.Location = new System.Drawing.Point(288, 208);
            this.departmentLb.Name = "departmentLb";
            this.departmentLb.Size = new System.Drawing.Size(86, 17);
            this.departmentLb.TabIndex = 7;
            this.departmentLb.Text = "Department:";
            // 
            // usernameLb
            // 
            this.usernameLb.AutoSize = true;
            this.usernameLb.Location = new System.Drawing.Point(29, 208);
            this.usernameLb.Name = "usernameLb";
            this.usernameLb.Size = new System.Drawing.Size(77, 17);
            this.usernameLb.TabIndex = 6;
            this.usernameLb.Text = "Username:";
            // 
            // emailLb
            // 
            this.emailLb.AutoSize = true;
            this.emailLb.Location = new System.Drawing.Point(288, 173);
            this.emailLb.Name = "emailLb";
            this.emailLb.Size = new System.Drawing.Size(46, 17);
            this.emailLb.TabIndex = 5;
            this.emailLb.Text = "Email:";
            // 
            // lastNameLb
            // 
            this.lastNameLb.AutoSize = true;
            this.lastNameLb.Location = new System.Drawing.Point(29, 173);
            this.lastNameLb.Name = "lastNameLb";
            this.lastNameLb.Size = new System.Drawing.Size(80, 17);
            this.lastNameLb.TabIndex = 4;
            this.lastNameLb.Text = "Last Name:";
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Location = new System.Drawing.Point(288, 94);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(73, 17);
            this.passwordLb.TabIndex = 3;
            this.passwordLb.Text = "Password:";
            // 
            // facultyIdLb
            // 
            this.facultyIdLb.AutoSize = true;
            this.facultyIdLb.Location = new System.Drawing.Point(29, 94);
            this.facultyIdLb.Name = "facultyIdLb";
            this.facultyIdLb.Size = new System.Drawing.Size(72, 17);
            this.facultyIdLb.TabIndex = 2;
            this.facultyIdLb.Text = "Faculty Id:";
            // 
            // firstNameLb
            // 
            this.firstNameLb.AutoSize = true;
            this.firstNameLb.Location = new System.Drawing.Point(29, 133);
            this.firstNameLb.Name = "firstNameLb";
            this.firstNameLb.Size = new System.Drawing.Size(80, 17);
            this.firstNameLb.TabIndex = 1;
            this.firstNameLb.Text = "First Name:";
            // 
            // acctInfoLabel
            // 
            this.acctInfoLabel.AutoSize = true;
            this.acctInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.acctInfoLabel.Location = new System.Drawing.Point(27, 20);
            this.acctInfoLabel.Name = "acctInfoLabel";
            this.acctInfoLabel.Size = new System.Drawing.Size(242, 29);
            this.acctInfoLabel.TabIndex = 0;
            this.acctInfoLabel.Text = "Account Information";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(8, 258);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // FacultyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.userInfo);
            this.Name = "FacultyUI";
            this.Text = "Faculty";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GradeTab.ResumeLayout(false);
            this.GradeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradebook)).EndInit();
            this.CourseTab.ResumeLayout(false);
            this.CourseTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.personalInfoTab.ResumeLayout(false);
            this.personalInfoTab.PerformLayout();
            this.userInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button logOutBtn;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage GradeTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvGradebook;
        private System.Windows.Forms.Label Courselbl;
        private System.Windows.Forms.ComboBox CourseCboBox;
        private System.Windows.Forms.TabPage CourseTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.TabPage personalInfoTab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.TabControl userInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label acctInfoLabel;
        private System.Windows.Forms.Label firstNameLb;
        private System.Windows.Forms.Label emailLb;
        private System.Windows.Forms.Label lastNameLb;
        private System.Windows.Forms.Label passwordLb;
        private System.Windows.Forms.Label facultyIdLb;
        private System.Windows.Forms.Label usernameLb;
        private System.Windows.Forms.Label departmentLb;
        private System.Windows.Forms.Label facultyIdText;
        private System.Windows.Forms.CheckBox showPassCB;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.Label departmentText;
        private System.Windows.Forms.Label emailText;
        private System.Windows.Forms.Label usernameText;
        private System.Windows.Forms.Label lastNameText;
        private System.Windows.Forms.Label firstNameText;
        private System.Windows.Forms.Button editAcctInfoBtn;
        private System.Windows.Forms.Label welcomeNameLb;
        private System.Windows.Forms.Button editCourseBtn;
        private System.Windows.Forms.Label studentsLb;
    }
}