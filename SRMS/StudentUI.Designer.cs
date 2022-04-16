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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Welcome");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Account Information");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Classes");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Enrollment");
            this.tabControl_studentInfo = new System.Windows.Forms.TabControl();
            this.tabPage_welcome = new System.Windows.Forms.TabPage();
            this.label_enrollment = new System.Windows.Forms.Label();
            this.label_classes = new System.Windows.Forms.Label();
            this.label_accInfo = new System.Windows.Forms.Label();
            this.label_welcome = new System.Windows.Forms.Label();
            this.tabPage_accInfo = new System.Windows.Forms.TabPage();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.label_heading = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_major = new System.Windows.Forms.TextBox();
            this.label_major = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_lastName = new System.Windows.Forms.Label();
            this.label_firstName = new System.Windows.Forms.Label();
            this.tabPage_classes = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.tabPage_enrollment = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label_selectSemester = new System.Windows.Forms.Label();
            this.comboBox_selectSemester = new System.Windows.Forms.ComboBox();
            this.label_enrollmentScreen = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_logOut = new System.Windows.Forms.Button();
            this.treeView_tabs = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl_studentInfo.SuspendLayout();
            this.tabPage_welcome.SuspendLayout();
            this.tabPage_accInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.tabPage_classes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.tabPage_enrollment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.tabControl_studentInfo.Location = new System.Drawing.Point(291, 63);
            this.tabControl_studentInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_studentInfo.Name = "tabControl_studentInfo";
            this.tabControl_studentInfo.SelectedIndex = 0;
            this.tabControl_studentInfo.Size = new System.Drawing.Size(723, 378);
            this.tabControl_studentInfo.TabIndex = 0;
            // 
            // tabPage_welcome
            // 
            this.tabPage_welcome.Controls.Add(this.label_enrollment);
            this.tabPage_welcome.Controls.Add(this.label_classes);
            this.tabPage_welcome.Controls.Add(this.label_accInfo);
            this.tabPage_welcome.Controls.Add(this.label_welcome);
            this.tabPage_welcome.Location = new System.Drawing.Point(4, 25);
            this.tabPage_welcome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_welcome.Name = "tabPage_welcome";
            this.tabPage_welcome.Size = new System.Drawing.Size(715, 349);
            this.tabPage_welcome.TabIndex = 2;
            this.tabPage_welcome.Text = "Welcome";
            this.tabPage_welcome.UseVisualStyleBackColor = true;
            // 
            // label_enrollment
            // 
            this.label_enrollment.AutoSize = true;
            this.label_enrollment.Location = new System.Drawing.Point(40, 186);
            this.label_enrollment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_enrollment.Name = "label_enrollment";
            this.label_enrollment.Size = new System.Drawing.Size(378, 16);
            this.label_enrollment.TabIndex = 3;
            this.label_enrollment.Text = "Select the \"Enrollment\" tab to enroll in classes for the semester.";
            // 
            // label_classes
            // 
            this.label_classes.AutoSize = true;
            this.label_classes.Location = new System.Drawing.Point(40, 153);
            this.label_classes.Name = "label_classes";
            this.label_classes.Size = new System.Drawing.Size(403, 16);
            this.label_classes.TabIndex = 2;
            this.label_classes.Text = "Select the \"Classes\" tab to view your enrolled classes and grades. ";
            // 
            // label_accInfo
            // 
            this.label_accInfo.AutoSize = true;
            this.label_accInfo.Location = new System.Drawing.Point(40, 121);
            this.label_accInfo.Name = "label_accInfo";
            this.label_accInfo.Size = new System.Drawing.Size(468, 16);
            this.label_accInfo.TabIndex = 1;
            this.label_accInfo.Text = "Select the \"Account Information\" tab to view and edit your personal information.";
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.Location = new System.Drawing.Point(36, 31);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(170, 38);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Welcome!\r\n";
            // 
            // tabPage_accInfo
            // 
            this.tabPage_accInfo.Controls.Add(this.dgvInfo);
            this.tabPage_accInfo.Controls.Add(this.label_heading);
            this.tabPage_accInfo.Controls.Add(this.button1);
            this.tabPage_accInfo.Controls.Add(this.textBox_major);
            this.tabPage_accInfo.Controls.Add(this.label_major);
            this.tabPage_accInfo.Controls.Add(this.textBox_email);
            this.tabPage_accInfo.Controls.Add(this.label_email);
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
            this.tabPage_accInfo.Size = new System.Drawing.Size(715, 349);
            this.tabPage_accInfo.TabIndex = 0;
            this.tabPage_accInfo.Text = "Account Information";
            this.tabPage_accInfo.UseVisualStyleBackColor = true;
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(18, 72);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowHeadersWidth = 51;
            this.dgvInfo.RowTemplate.Height = 24;
            this.dgvInfo.Size = new System.Drawing.Size(666, 201);
            this.dgvInfo.TabIndex = 12;
            this.dgvInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // label_heading
            // 
            this.label_heading.AutoSize = true;
            this.label_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_heading.Location = new System.Drawing.Point(36, 31);
            this.label_heading.Name = "label_heading";
            this.label_heading.Size = new System.Drawing.Size(325, 38);
            this.label_heading.TabIndex = 11;
            this.label_heading.Text = "Account Information";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_major
            // 
            this.textBox_major.Location = new System.Drawing.Point(117, 206);
            this.textBox_major.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_major.Name = "textBox_major";
            this.textBox_major.Size = new System.Drawing.Size(100, 22);
            this.textBox_major.TabIndex = 9;
            // 
            // label_major
            // 
            this.label_major.AutoSize = true;
            this.label_major.Location = new System.Drawing.Point(40, 209);
            this.label_major.Name = "label_major";
            this.label_major.Size = new System.Drawing.Size(41, 16);
            this.label_major.TabIndex = 8;
            this.label_major.Text = "Major";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(117, 178);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 22);
            this.textBox_email.TabIndex = 7;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(40, 181);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(41, 16);
            this.label_email.TabIndex = 6;
            this.label_email.Text = "Email";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(117, 150);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_id.TabIndex = 5;
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(117, 122);
            this.textBox_lastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(100, 22);
            this.textBox_lastName.TabIndex = 4;
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(117, 94);
            this.textBox_firstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(100, 22);
            this.textBox_firstName.TabIndex = 3;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(40, 153);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(68, 16);
            this.label_id.TabIndex = 2;
            this.label_id.Text = "Student ID";
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Location = new System.Drawing.Point(40, 126);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(72, 16);
            this.label_lastName.TabIndex = 1;
            this.label_lastName.Text = "Last Name";
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(40, 96);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(72, 16);
            this.label_firstName.TabIndex = 0;
            this.label_firstName.Text = "First Name";
            // 
            // tabPage_classes
            // 
            this.tabPage_classes.Controls.Add(this.label1);
            this.tabPage_classes.Controls.Add(this.dgvClasses);
            this.tabPage_classes.Location = new System.Drawing.Point(4, 25);
            this.tabPage_classes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_classes.Name = "tabPage_classes";
            this.tabPage_classes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_classes.Size = new System.Drawing.Size(715, 349);
            this.tabPage_classes.TabIndex = 1;
            this.tabPage_classes.Text = "Classes";
            this.tabPage_classes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 31);
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
            this.dgvClasses.Location = new System.Drawing.Point(43, 97);
            this.dgvClasses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersWidth = 51;
            this.dgvClasses.RowTemplate.Height = 24;
            this.dgvClasses.Size = new System.Drawing.Size(619, 196);
            this.dgvClasses.TabIndex = 0;
            // 
            // tabPage_enrollment
            // 
            this.tabPage_enrollment.Controls.Add(this.label2);
            this.tabPage_enrollment.Controls.Add(this.dataGridView2);
            this.tabPage_enrollment.Controls.Add(this.label_selectSemester);
            this.tabPage_enrollment.Controls.Add(this.comboBox_selectSemester);
            this.tabPage_enrollment.Controls.Add(this.label_enrollmentScreen);
            this.tabPage_enrollment.Location = new System.Drawing.Point(4, 25);
            this.tabPage_enrollment.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_enrollment.Name = "tabPage_enrollment";
            this.tabPage_enrollment.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_enrollment.Size = new System.Drawing.Size(715, 349);
            this.tabPage_enrollment.TabIndex = 3;
            this.tabPage_enrollment.Tag = "Maggie";
            this.tabPage_enrollment.Text = "Enrollment";
            this.tabPage_enrollment.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "query classes for given semester";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(45, 143);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(617, 155);
            this.dataGridView2.TabIndex = 15;
            // 
            // label_selectSemester
            // 
            this.label_selectSemester.AutoSize = true;
            this.label_selectSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selectSemester.Location = new System.Drawing.Point(40, 85);
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
            "Spring 2022",
            "Summer 2022",
            "Fall 2022"});
            this.comboBox_selectSemester.Location = new System.Drawing.Point(337, 81);
            this.comboBox_selectSemester.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_selectSemester.Name = "comboBox_selectSemester";
            this.comboBox_selectSemester.Size = new System.Drawing.Size(209, 37);
            this.comboBox_selectSemester.TabIndex = 13;
            // 
            // label_enrollmentScreen
            // 
            this.label_enrollmentScreen.AutoSize = true;
            this.label_enrollmentScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_enrollmentScreen.Location = new System.Drawing.Point(37, 30);
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
            this.button_logOut.Location = new System.Drawing.Point(920, 21);
            this.button_logOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Size = new System.Drawing.Size(92, 36);
            this.button_logOut.TabIndex = 3;
            this.button_logOut.Text = "Log Out";
            this.button_logOut.UseVisualStyleBackColor = true;
            this.button_logOut.Click += new System.EventHandler(this.button_logOut_Click);
            // 
            // treeView_tabs
            // 
            this.treeView_tabs.Location = new System.Drawing.Point(41, 318);
            this.treeView_tabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView_tabs.Name = "treeView_tabs";
            treeNode1.Name = "Node_Welcome";
            treeNode1.Text = "Welcome";
            treeNode2.Name = "Node_accInfo";
            treeNode2.Text = "Account Information";
            treeNode3.Name = "Node_classes";
            treeNode3.Text = "Classes";
            treeNode4.Name = "Node_enrollment";
            treeNode4.Text = "Enrollment";
            this.treeView_tabs.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView_tabs.Size = new System.Drawing.Size(216, 85);
            this.treeView_tabs.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BackgroundImage = global::SRMS.Properties.Resources.Kansas_Jayhawks_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(41, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 135);
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
            this.listBox1.Location = new System.Drawing.Point(41, 242);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 68);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // StudentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1043, 487);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView_tabs);
            this.Controls.Add(this.button_logOut);
            this.Controls.Add(this.tabControl_studentInfo);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentUI";
            this.Text = "Student";
            this.tabControl_studentInfo.ResumeLayout(false);
            this.tabPage_welcome.ResumeLayout(false);
            this.tabPage_welcome.PerformLayout();
            this.tabPage_accInfo.ResumeLayout(false);
            this.tabPage_accInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.tabPage_classes.ResumeLayout(false);
            this.tabPage_classes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.tabPage_enrollment.ResumeLayout(false);
            this.tabPage_enrollment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_major;
        private System.Windows.Forms.Label label_major;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.Button button_logOut;
        private System.Windows.Forms.TreeView treeView_tabs;
        private System.Windows.Forms.Label label_heading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage_enrollment;
        private System.Windows.Forms.Label label_enrollment;
        private System.Windows.Forms.Label label_enrollmentScreen;
        private System.Windows.Forms.ComboBox comboBox_selectSemester;
        private System.Windows.Forms.Label label_selectSemester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dgvInfo;
    }
}