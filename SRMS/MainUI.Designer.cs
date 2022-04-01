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
            this.CoursePage = new System.Windows.Forms.TabPage();
            this.EnrollPage = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.studentViewControl.SuspendLayout();
            this.AcctInfoPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentViewControl
            // 
            this.studentViewControl.Controls.Add(this.AcctInfoPage);
            this.studentViewControl.Controls.Add(this.CoursePage);
            this.studentViewControl.Controls.Add(this.EnrollPage);
            this.studentViewControl.Location = new System.Drawing.Point(12, 12);
            this.studentViewControl.Name = "studentViewControl";
            this.studentViewControl.SelectedIndex = 0;
            this.studentViewControl.Size = new System.Drawing.Size(648, 337);
            this.studentViewControl.TabIndex = 0;
            // 
            // AcctInfoPage
            // 
            this.AcctInfoPage.Controls.Add(this.listBox1);
            this.AcctInfoPage.Location = new System.Drawing.Point(4, 22);
            this.AcctInfoPage.Name = "AcctInfoPage";
            this.AcctInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.AcctInfoPage.Size = new System.Drawing.Size(640, 311);
            this.AcctInfoPage.TabIndex = 0;
            this.AcctInfoPage.Text = "Account Info";
            this.AcctInfoPage.UseVisualStyleBackColor = true;
            // 
            // CoursePage
            // 
            this.CoursePage.Location = new System.Drawing.Point(4, 22);
            this.CoursePage.Name = "CoursePage";
            this.CoursePage.Padding = new System.Windows.Forms.Padding(3);
            this.CoursePage.Size = new System.Drawing.Size(640, 311);
            this.CoursePage.TabIndex = 1;
            this.CoursePage.Text = "Courses";
            this.CoursePage.UseVisualStyleBackColor = true;
            // 
            // EnrollPage
            // 
            this.EnrollPage.Location = new System.Drawing.Point(4, 22);
            this.EnrollPage.Name = "EnrollPage";
            this.EnrollPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnrollPage.Size = new System.Drawing.Size(640, 311);
            this.EnrollPage.TabIndex = 2;
            this.EnrollPage.Text = "Enrollment";
            this.EnrollPage.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentViewControl);
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
    }
}

