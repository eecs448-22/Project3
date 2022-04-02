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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_accInfo = new System.Windows.Forms.TabPage();
            this.tabPage_classes = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl_studentInfo.SuspendLayout();
            this.tabPage_welcome.SuspendLayout();
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
            this.tabControl_studentInfo.Location = new System.Drawing.Point(221, 63);
            this.tabControl_studentInfo.Name = "tabControl_studentInfo";
            this.tabControl_studentInfo.SelectedIndex = 0;
            this.tabControl_studentInfo.Size = new System.Drawing.Size(598, 378);
            this.tabControl_studentInfo.TabIndex = 0;
            // 
            // tabPage_welcome
            // 
            this.tabPage_welcome.Controls.Add(this.label2);
            this.tabPage_welcome.Controls.Add(this.label1);
            this.tabPage_welcome.Location = new System.Drawing.Point(4, 25);
            this.tabPage_welcome.Name = "tabPage_welcome";
            this.tabPage_welcome.Size = new System.Drawing.Size(590, 349);
            this.tabPage_welcome.TabIndex = 2;
            this.tabPage_welcome.Text = "Welcome";
            this.tabPage_welcome.UseVisualStyleBackColor = true;
            this.tabPage_welcome.Click += new System.EventHandler(this.tabPage_welcome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select the \"Account Information\" tab above to view and edit your personal informa" +
    "tion.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage_accInfo
            // 
            this.tabPage_accInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPage_accInfo.Name = "tabPage_accInfo";
            this.tabPage_accInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_accInfo.Size = new System.Drawing.Size(590, 349);
            this.tabPage_accInfo.TabIndex = 0;
            this.tabPage_accInfo.Text = "Account Information";
            this.tabPage_accInfo.UseVisualStyleBackColor = true;
            // 
            // tabPage_classes
            // 
            this.tabPage_classes.Location = new System.Drawing.Point(4, 25);
            this.tabPage_classes.Name = "tabPage_classes";
            this.tabPage_classes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_classes.Size = new System.Drawing.Size(590, 349);
            this.tabPage_classes.TabIndex = 1;
            this.tabPage_classes.Text = "Classes";
            this.tabPage_classes.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(486, 326);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // StudentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(846, 487);
            this.Controls.Add(this.tabControl_studentInfo);
            this.Controls.Add(this.textBox1);
            this.Name = "StudentUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentUI_Load);
            this.tabControl_studentInfo.ResumeLayout(false);
            this.tabPage_welcome.ResumeLayout(false);
            this.tabPage_welcome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_studentInfo;
        private System.Windows.Forms.TabPage tabPage_accInfo;
        private System.Windows.Forms.TabPage tabPage_classes;
        private System.Windows.Forms.TabPage tabPage_welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}