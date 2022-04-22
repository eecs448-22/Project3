/* =============================================================================
 * Code in this file is generated from the visual studio .NET C# winForms framework. 
 * ============================================================================= */


namespace SRMS
{
    partial class newPassWordLabel
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
            this.goBackBtn = new System.Windows.Forms.Button();
            this.PassLabel = new System.Windows.Forms.Label();
            this.newNameLabel = new System.Windows.Forms.Label();
            this.createPassInput = new System.Windows.Forms.TextBox();
            this.createUserInput = new System.Windows.Forms.TextBox();
            this.confirmPassLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createTitle = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.accountTypeCB = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goBackBtn
            // 
            this.goBackBtn.Location = new System.Drawing.Point(310, 308);
            this.goBackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(86, 19);
            this.goBackBtn.TabIndex = 0;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(128, 210);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(90, 13);
            this.PassLabel.TabIndex = 7;
            this.PassLabel.Text = "Create Password:";
            // 
            // newNameLabel
            // 
            this.newNameLabel.AutoSize = true;
            this.newNameLabel.Location = new System.Drawing.Point(128, 117);
            this.newNameLabel.Name = "newNameLabel";
            this.newNameLabel.Size = new System.Drawing.Size(109, 13);
            this.newNameLabel.TabIndex = 6;
            this.newNameLabel.Text = "Choose a Username: ";
            // 
            // createPassInput
            // 
            this.createPassInput.Location = new System.Drawing.Point(247, 205);
            this.createPassInput.Name = "createPassInput";
            this.createPassInput.Size = new System.Drawing.Size(182, 20);
            this.createPassInput.TabIndex = 5;
            // 
            // createUserInput
            // 
            this.createUserInput.Location = new System.Drawing.Point(247, 112);
            this.createUserInput.Name = "createUserInput";
            this.createUserInput.Size = new System.Drawing.Size(182, 20);
            this.createUserInput.TabIndex = 4;
            // 
            // confirmPassLabel
            // 
            this.confirmPassLabel.Location = new System.Drawing.Point(247, 240);
            this.confirmPassLabel.Name = "confirmPassLabel";
            this.confirmPassLabel.Size = new System.Drawing.Size(182, 20);
            this.confirmPassLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Confirm Password:";
            // 
            // createTitle
            // 
            this.createTitle.AutoSize = true;
            this.createTitle.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTitle.Location = new System.Drawing.Point(110, 56);
            this.createTitle.Name = "createTitle";
            this.createTitle.Size = new System.Drawing.Size(376, 31);
            this.createTitle.TabIndex = 8;
            this.createTitle.Text = "Create Administrator Account";
            this.createTitle.Click += new System.EventHandler(this.ProgTitle_Click);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(247, 145);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(182, 20);
            this.emailInput.TabIndex = 4;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(128, 148);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrator",
            "Student",
            "Faculty"});
            this.comboBox1.Location = new System.Drawing.Point(247, 174);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // accountTypeCB
            // 
            this.accountTypeCB.AutoSize = true;
            this.accountTypeCB.Location = new System.Drawing.Point(128, 176);
            this.accountTypeCB.Name = "accountTypeCB";
            this.accountTypeCB.Size = new System.Drawing.Size(77, 13);
            this.accountTypeCB.TabIndex = 6;
            this.accountTypeCB.Text = "Account Type:";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(199, 308);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(86, 19);
            this.submitBtn.TabIndex = 11;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // newPassWordLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.createTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.confirmPassLabel);
            this.Controls.Add(this.accountTypeCB);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.newNameLabel);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.createPassInput);
            this.Controls.Add(this.createUserInput);
            this.Controls.Add(this.goBackBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "newPassWordLabel";
            this.Text = "CreateAccountUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label newNameLabel;
        private System.Windows.Forms.TextBox createPassInput;
        private System.Windows.Forms.TextBox createUserInput;
        private System.Windows.Forms.TextBox confirmPassLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label createTitle;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label accountTypeCB;
        private System.Windows.Forms.Button submitBtn;
    }
}