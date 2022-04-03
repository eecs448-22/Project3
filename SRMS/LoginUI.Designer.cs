/* =============================================================================
 * Code in this file is generated from the visual studio .NET C# winForms framework. Maggie Testing 
 * ============================================================================= */

namespace SRMS
{
    partial class LoginUI
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
            this.UserInput = new System.Windows.Forms.TextBox();
            this.PassInput = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ProgTitle = new System.Windows.Forms.Label();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.signInLabel = new System.Windows.Forms.Label();
            this.signInCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(493, 236);
            this.UserInput.Margin = new System.Windows.Forms.Padding(4);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(132, 22);
            this.UserInput.TabIndex = 0;
            // 
            // PassInput
            // 
            this.PassInput.Location = new System.Drawing.Point(493, 284);
            this.PassInput.Margin = new System.Windows.Forms.Padding(4);
            this.PassInput.Name = "PassInput";
            this.PassInput.Size = new System.Drawing.Size(132, 22);
            this.PassInput.TabIndex = 1;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(411, 240);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(70, 16);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "Username";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(414, 288);
            this.PassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(67, 16);
            this.PassLabel.TabIndex = 3;
            this.PassLabel.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(471, 338);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(154, 28);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ProgTitle
            // 
            this.ProgTitle.AutoSize = true;
            this.ProgTitle.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgTitle.Location = new System.Drawing.Point(397, 130);
            this.ProgTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProgTitle.Name = "ProgTitle";
            this.ProgTitle.Size = new System.Drawing.Size(285, 40);
            this.ProgTitle.TabIndex = 5;
            this.ProgTitle.Text = "KU Course Access";
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Location = new System.Drawing.Point(470, 373);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(155, 23);
            this.createAccountBtn.TabIndex = 6;
            this.createAccountBtn.Text = "Create Account";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // signInLabel
            // 
            this.signInLabel.AutoSize = true;
            this.signInLabel.Location = new System.Drawing.Point(411, 198);
            this.signInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(68, 16);
            this.signInLabel.TabIndex = 2;
            this.signInLabel.Text = "Sign in as:";
            // 
            // signInCB
            // 
            this.signInCB.FormattingEnabled = true;
            this.signInCB.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.signInCB.Location = new System.Drawing.Point(493, 195);
            this.signInCB.Name = "signInCB";
            this.signInCB.Size = new System.Drawing.Size(132, 24);
            this.signInCB.TabIndex = 7;
            this.signInCB.Text = "Student";
            this.signInCB.SelectedIndexChanged += new System.EventHandler(this.signInCB_SelectedIndexChanged);
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.signInCB);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.ProgTitle);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.signInLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.PassInput);
            this.Controls.Add(this.UserInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.TextBox PassInput;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label ProgTitle;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.Label signInLabel;
        private System.Windows.Forms.ComboBox signInCB;
    }
}