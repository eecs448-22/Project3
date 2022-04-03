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
            this.tabControl_studentInfo = new System.Windows.Forms.TabControl();
            this.tabPage_welcome = new System.Windows.Forms.TabPage();
            this.label_classes = new System.Windows.Forms.Label();
            this.label_accInfo = new System.Windows.Forms.Label();
            this.label_welcome = new System.Windows.Forms.Label();
            this.tabPage_accInfo = new System.Windows.Forms.TabPage();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_logOut = new System.Windows.Forms.Button();
            this.treeView_tabs = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl_studentInfo.SuspendLayout();
            this.tabPage_welcome.SuspendLayout();
            this.tabPage_accInfo.SuspendLayout();
            this.tabPage_classes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabControl_studentInfo.Location = new System.Drawing.Point(290, 63);
            this.tabControl_studentInfo.Name = "tabControl_studentInfo";
            this.tabControl_studentInfo.SelectedIndex = 0;
            this.tabControl_studentInfo.Size = new System.Drawing.Size(722, 378);
            this.tabControl_studentInfo.TabIndex = 0;
            // 
            // tabPage_welcome
            // 
            this.tabPage_welcome.Controls.Add(this.label_classes);
            this.tabPage_welcome.Controls.Add(this.label_accInfo);
            this.tabPage_welcome.Controls.Add(this.label_welcome);
            this.tabPage_welcome.Location = new System.Drawing.Point(4, 25);
            this.tabPage_welcome.Name = "tabPage_welcome";
            this.tabPage_welcome.Size = new System.Drawing.Size(714, 349);
            this.tabPage_welcome.TabIndex = 2;
            this.tabPage_welcome.Text = "Welcome";
            this.tabPage_welcome.UseVisualStyleBackColor = true;
            this.tabPage_welcome.Click += new System.EventHandler(this.tabPage_welcome_Click);
            // 
            // label_classes
            // 
            this.label_classes.AutoSize = true;
            this.label_classes.Location = new System.Drawing.Point(40, 155);
            this.label_classes.Name = "label_classes";
            this.label_classes.Size = new System.Drawing.Size(403, 16);
            this.label_classes.TabIndex = 2;
            this.label_classes.Text = "Select the \"Classes\" tab to view your enrolled classes and grades. ";
            // 
            // label_accInfo
            // 
            this.label_accInfo.AutoSize = true;
            this.label_accInfo.Location = new System.Drawing.Point(40, 120);
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
            this.label_welcome.Text = "Welcome!";
            this.label_welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage_accInfo
            // 
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
            this.tabPage_accInfo.Name = "tabPage_accInfo";
            this.tabPage_accInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_accInfo.Size = new System.Drawing.Size(714, 349);
            this.tabPage_accInfo.TabIndex = 0;
            this.tabPage_accInfo.Text = "Account Information";
            this.tabPage_accInfo.UseVisualStyleBackColor = true;
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
            this.button1.Location = new System.Drawing.Point(118, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_major
            // 
            this.textBox_major.Location = new System.Drawing.Point(118, 206);
            this.textBox_major.Name = "textBox_major";
            this.textBox_major.Size = new System.Drawing.Size(100, 22);
            this.textBox_major.TabIndex = 9;
            this.textBox_major.TextChanged += new System.EventHandler(this.textBox_major_TextChanged);
            // 
            // label_major
            // 
            this.label_major.AutoSize = true;
            this.label_major.Location = new System.Drawing.Point(40, 209);
            this.label_major.Name = "label_major";
            this.label_major.Size = new System.Drawing.Size(41, 16);
            this.label_major.TabIndex = 8;
            this.label_major.Text = "Major";
            this.label_major.Click += new System.EventHandler(this.label_major_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(118, 178);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 22);
            this.textBox_email.TabIndex = 7;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(40, 181);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(41, 16);
            this.label_email.TabIndex = 6;
            this.label_email.Text = "Email";
            this.label_email.Click += new System.EventHandler(this.label_email_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(118, 150);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_id.TabIndex = 5;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(118, 122);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(100, 22);
            this.textBox_lastName.TabIndex = 4;
            this.textBox_lastName.TextChanged += new System.EventHandler(this.textBox_lastName_TextChanged);
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(118, 93);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(100, 22);
            this.textBox_firstName.TabIndex = 3;
            this.textBox_firstName.TextChanged += new System.EventHandler(this.textBox_firstName_TextChanged);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(40, 153);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(68, 16);
            this.label_id.TabIndex = 2;
            this.label_id.Text = "Student ID";
            this.label_id.Click += new System.EventHandler(this.label_id_Click);
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Location = new System.Drawing.Point(40, 125);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(72, 16);
            this.label_lastName.TabIndex = 1;
            this.label_lastName.Text = "Last Name";
            this.label_lastName.Click += new System.EventHandler(this.label_lastName_Click);
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(40, 96);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(72, 16);
            this.label_firstName.TabIndex = 0;
            this.label_firstName.Text = "First Name";
            this.label_firstName.Click += new System.EventHandler(this.label_firstName_Click);
            // 
            // tabPage_classes
            // 
            this.tabPage_classes.Controls.Add(this.label1);
            this.tabPage_classes.Controls.Add(this.dataGridView1);
            this.tabPage_classes.Location = new System.Drawing.Point(4, 25);
            this.tabPage_classes.Name = "tabPage_classes";
            this.tabPage_classes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_classes.Size = new System.Drawing.Size(714, 349);
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
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(618, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(486, 326);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button_logOut
            // 
            this.button_logOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_logOut.Location = new System.Drawing.Point(920, 21);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Size = new System.Drawing.Size(92, 36);
            this.button_logOut.TabIndex = 3;
            this.button_logOut.Text = "Log Out";
            this.button_logOut.UseVisualStyleBackColor = true;
            this.button_logOut.Click += new System.EventHandler(this.button_logOut_Click);
            // 
            // treeView_tabs
            // 
            this.treeView_tabs.Location = new System.Drawing.Point(41, 243);
            this.treeView_tabs.Name = "treeView_tabs";
            treeNode1.Name = "Node_Welcome";
            treeNode1.Text = "Welcome";
            treeNode2.Name = "Node_accInfo";
            treeNode2.Text = "Account Information";
            treeNode3.Name = "Node_classes";
            treeNode3.Text = "Classes";
            this.treeView_tabs.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView_tabs.Size = new System.Drawing.Size(216, 73);
            this.treeView_tabs.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BackgroundImage = global::SRMS.Properties.Resources.Kansas_Jayhawks_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(41, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 136);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // StudentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1043, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView_tabs);
            this.Controls.Add(this.button_logOut);
            this.Controls.Add(this.tabControl_studentInfo);
            this.Controls.Add(this.textBox1);
            this.Name = "StudentUI";
            this.Load += new System.EventHandler(this.StudentUI_Load);
            this.tabControl_studentInfo.ResumeLayout(false);
            this.tabPage_welcome.ResumeLayout(false);
            this.tabPage_welcome.PerformLayout();
            this.tabPage_accInfo.ResumeLayout(false);
            this.tabPage_accInfo.PerformLayout();
            this.tabPage_classes.ResumeLayout(false);
            this.tabPage_classes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_logOut;
        private System.Windows.Forms.TreeView treeView_tabs;
        private System.Windows.Forms.Label label_heading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}