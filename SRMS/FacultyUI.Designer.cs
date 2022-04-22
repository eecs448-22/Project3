﻿/* =============================================================================
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
            this.GradeTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submitDataBtn = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Courselbl = new System.Windows.Forms.Label();
            this.CourseCboBox = new System.Windows.Forms.ComboBox();
            this.CourseTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.personalInfoTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GradeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.CourseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.personalInfoTab.SuspendLayout();
            this.tabControl.SuspendLayout();
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
            this.pictureBox1.Location = new System.Drawing.Point(22, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 110);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // GradeTab
            // 
            this.GradeTab.Controls.Add(this.label3);
            this.GradeTab.Controls.Add(this.label2);
            this.GradeTab.Controls.Add(this.submitDataBtn);
            this.GradeTab.Controls.Add(this.dataGridView3);
            this.GradeTab.Controls.Add(this.Courselbl);
            this.GradeTab.Controls.Add(this.CourseCboBox);
            this.GradeTab.Location = new System.Drawing.Point(4, 25);
            this.GradeTab.Name = "GradeTab";
            this.GradeTab.Size = new System.Drawing.Size(568, 307);
            this.GradeTab.TabIndex = 3;
            this.GradeTab.Text = "Gradebook";
            this.GradeTab.UseVisualStyleBackColor = true;
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
            // submitDataBtn
            // 
            this.submitDataBtn.Location = new System.Drawing.Point(435, 275);
            this.submitDataBtn.Name = "submitDataBtn";
            this.submitDataBtn.Size = new System.Drawing.Size(109, 29);
            this.submitDataBtn.TabIndex = 3;
            this.submitDataBtn.Text = "Save Changes";
            this.submitDataBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(37, 91);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(492, 179);
            this.dataGridView3.TabIndex = 2;
            // 
            // Courselbl
            // 
            this.Courselbl.AutoSize = true;
            this.Courselbl.Location = new System.Drawing.Point(34, 38);
            this.Courselbl.Name = "Courselbl";
            this.Courselbl.Size = new System.Drawing.Size(61, 17);
            this.Courselbl.TabIndex = 1;
            this.Courselbl.Text = "Course: ";
            // 
            // CourseCboBox
            // 
            this.CourseCboBox.FormattingEnabled = true;
            this.CourseCboBox.Location = new System.Drawing.Point(101, 35);
            this.CourseCboBox.Name = "CourseCboBox";
            this.CourseCboBox.Size = new System.Drawing.Size(199, 24);
            this.CourseCboBox.TabIndex = 0;
            this.CourseCboBox.SelectionChangeCommitted += new System.EventHandler(this.CourseCboBox_SelectionChangeCommitted);
            // 
            // CourseTab
            // 
            this.CourseTab.Controls.Add(this.label1);
            this.CourseTab.Controls.Add(this.CourseLabel);
            this.CourseTab.Controls.Add(this.dataGridView2);
            this.CourseTab.Location = new System.Drawing.Point(4, 25);
            this.CourseTab.Name = "CourseTab";
            this.CourseTab.Padding = new System.Windows.Forms.Padding(3);
            this.CourseTab.Size = new System.Drawing.Size(568, 307);
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
            this.CourseLabel.Location = new System.Drawing.Point(35, 41);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(110, 29);
            this.CourseLabel.TabIndex = 1;
            this.CourseLabel.Text = "Courses";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 90);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(512, 186);
            this.dataGridView2.TabIndex = 0;
            // 
            // personalInfoTab
            // 
            this.personalInfoTab.Controls.Add(this.label5);
            this.personalInfoTab.Controls.Add(this.label4);
            this.personalInfoTab.Controls.Add(this.welcomeLbl);
            this.personalInfoTab.Location = new System.Drawing.Point(4, 25);
            this.personalInfoTab.Name = "personalInfoTab";
            this.personalInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.personalInfoTab.Size = new System.Drawing.Size(568, 307);
            this.personalInfoTab.TabIndex = 0;
            this.personalInfoTab.Text = "Home";
            this.personalInfoTab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(449, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select \"Gradebook\" tab to view class roster and edit semester grades.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select \"Courses\" tab to view your courses.";
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.welcomeLbl.Location = new System.Drawing.Point(44, 48);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(135, 29);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Welcome!";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.personalInfoTab);
            this.tabControl.Controls.Add(this.CourseTab);
            this.tabControl.Controls.Add(this.GradeTab);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl.Location = new System.Drawing.Point(201, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(576, 336);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "■ Home",
            "■ Course",
            "■ Gradebook"});
            this.listBox1.Location = new System.Drawing.Point(22, 212);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 56);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FacultyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.tabControl);
            this.Name = "FacultyUI";
            this.Text = "Faculty";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GradeTab.ResumeLayout(false);
            this.GradeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.CourseTab.ResumeLayout(false);
            this.CourseTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.personalInfoTab.ResumeLayout(false);
            this.personalInfoTab.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button logOutBtn;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage GradeTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitDataBtn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label Courselbl;
        private System.Windows.Forms.ComboBox CourseCboBox;
        private System.Windows.Forms.TabPage CourseTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage personalInfoTab;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}