/* =============================================================================
 * Code in this file is generated from the visual studio .NET C# winForms framework. 
 * ============================================================================= */

namespace SRMS
{
    partial class MainUI
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
            this.studentViewControl = new System.Windows.Forms.TabControl();
            this.AcctInfoPage = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CoursePage = new System.Windows.Forms.TabPage();
            this.EnrollPage = new System.Windows.Forms.TabPage();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.studentViewControl.SuspendLayout();
            this.AcctInfoPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentViewControl
            // 
            this.studentViewControl.Controls.Add(this.AcctInfoPage);
            this.studentViewControl.Controls.Add(this.CoursePage);
            this.studentViewControl.Controls.Add(this.EnrollPage);
            this.studentViewControl.Location = new System.Drawing.Point(16, 15);
            this.studentViewControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentViewControl.Name = "studentViewControl";
            this.studentViewControl.SelectedIndex = 0;
            this.studentViewControl.Size = new System.Drawing.Size(864, 415);
            this.studentViewControl.TabIndex = 0;
            // 
            // AcctInfoPage
            // 
            this.AcctInfoPage.Controls.Add(this.logOutBtn);
            this.AcctInfoPage.Controls.Add(this.listBox1);
            this.AcctInfoPage.Location = new System.Drawing.Point(4, 25);
            this.AcctInfoPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AcctInfoPage.Name = "AcctInfoPage";
            this.AcctInfoPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AcctInfoPage.Size = new System.Drawing.Size(856, 386);
            this.AcctInfoPage.TabIndex = 0;
            this.AcctInfoPage.Text = "Account Info";
            this.AcctInfoPage.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(53, 48);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 116);
            this.listBox1.TabIndex = 0;
            // 
            // CoursePage
            // 
            this.CoursePage.Location = new System.Drawing.Point(4, 25);
            this.CoursePage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoursePage.Name = "CoursePage";
            this.CoursePage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoursePage.Size = new System.Drawing.Size(856, 386);
            this.CoursePage.TabIndex = 1;
            this.CoursePage.Text = "Courses";
            this.CoursePage.UseVisualStyleBackColor = true;
            // 
            // EnrollPage
            // 
            this.EnrollPage.Location = new System.Drawing.Point(4, 25);
            this.EnrollPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnrollPage.Name = "EnrollPage";
            this.EnrollPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnrollPage.Size = new System.Drawing.Size(856, 386);
            this.EnrollPage.TabIndex = 2;
            this.EnrollPage.Text = "Enrollment";
            this.EnrollPage.UseVisualStyleBackColor = true;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(760, 7);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(89, 31);
            this.logOutBtn.TabIndex = 1;
            this.logOutBtn.Text = "Log Out\r\n";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.studentViewControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainUI";
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.studentViewControl.ResumeLayout(false);
            this.AcctInfoPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl studentViewControl;
        private System.Windows.Forms.TabPage AcctInfoPage;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage CoursePage;
        private System.Windows.Forms.TabPage EnrollPage;
        private System.Windows.Forms.Button logOutBtn;
    }
}

