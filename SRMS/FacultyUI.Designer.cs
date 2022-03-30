
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
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Personal Info");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Courses");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Gradebook");
            this.tabControl = new System.Windows.Forms.TabControl();
            this.personalInfoTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.QuickRefLabel = new System.Windows.Forms.Label();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.CourseTab = new System.Windows.Forms.TabPage();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.GradeTab = new System.Windows.Forms.TabPage();
            this.submitDataBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Courselbl = new System.Windows.Forms.Label();
            this.CourseCboBox = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quickAccessTree = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.personalInfoTab.SuspendLayout();
            this.CourseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.GradeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.personalInfoTab);
            this.tabControl.Controls.Add(this.CourseTab);
            this.tabControl.Controls.Add(this.GradeTab);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl.Location = new System.Drawing.Point(152, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(612, 371);
            this.tabControl.TabIndex = 1;
            // 
            // personalInfoTab
            // 
            this.personalInfoTab.Controls.Add(this.textBox1);
            this.personalInfoTab.Controls.Add(this.QuickRefLabel);
            this.personalInfoTab.Controls.Add(this.welcomeLbl);
            this.personalInfoTab.Location = new System.Drawing.Point(4, 25);
            this.personalInfoTab.Name = "personalInfoTab";
            this.personalInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.personalInfoTab.Size = new System.Drawing.Size(604, 342);
            this.personalInfoTab.TabIndex = 0;
            this.personalInfoTab.Text = "Home";
            this.personalInfoTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(626, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "{Placeholder} Will query the faculty\'s courses, (courseName, roomNumber, course t" +
    "ime)";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // QuickRefLabel
            // 
            this.QuickRefLabel.AutoSize = true;
            this.QuickRefLabel.Location = new System.Drawing.Point(46, 94);
            this.QuickRefLabel.Name = "QuickRefLabel";
            this.QuickRefLabel.Size = new System.Drawing.Size(114, 17);
            this.QuickRefLabel.TabIndex = 1;
            this.QuickRefLabel.Text = "Quick Reference";
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(45, 41);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(211, 24);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Welcome {firstName}!";
            // 
            // CourseTab
            // 
            this.CourseTab.Controls.Add(this.label1);
            this.CourseTab.Controls.Add(this.CourseLabel);
            this.CourseTab.Controls.Add(this.dataGridView2);
            this.CourseTab.Location = new System.Drawing.Point(4, 25);
            this.CourseTab.Name = "CourseTab";
            this.CourseTab.Padding = new System.Windows.Forms.Padding(3);
            this.CourseTab.Size = new System.Drawing.Size(604, 342);
            this.CourseTab.TabIndex = 1;
            this.CourseTab.Text = "Courses";
            this.CourseTab.UseVisualStyleBackColor = true;
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseLabel.Location = new System.Drawing.Point(35, 41);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(75, 20);
            this.CourseLabel.TabIndex = 1;
            this.CourseLabel.Text = "Courses";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(39, 124);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(532, 141);
            this.dataGridView2.TabIndex = 0;
            // 
            // GradeTab
            // 
            this.GradeTab.Controls.Add(this.label3);
            this.GradeTab.Controls.Add(this.label2);
            this.GradeTab.Controls.Add(this.submitDataBtn);
            this.GradeTab.Controls.Add(this.dataGridView1);
            this.GradeTab.Controls.Add(this.Courselbl);
            this.GradeTab.Controls.Add(this.CourseCboBox);
            this.GradeTab.Location = new System.Drawing.Point(4, 25);
            this.GradeTab.Name = "GradeTab";
            this.GradeTab.Size = new System.Drawing.Size(604, 342);
            this.GradeTab.TabIndex = 3;
            this.GradeTab.Text = "Gradebook";
            this.GradeTab.UseVisualStyleBackColor = true;
            // 
            // submitDataBtn
            // 
            this.submitDataBtn.Location = new System.Drawing.Point(463, 298);
            this.submitDataBtn.Name = "submitDataBtn";
            this.submitDataBtn.Size = new System.Drawing.Size(109, 29);
            this.submitDataBtn.TabIndex = 3;
            this.submitDataBtn.Text = "Save Changes";
            this.submitDataBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(527, 179);
            this.dataGridView1.TabIndex = 2;
            // 
            // Courselbl
            // 
            this.Courselbl.AutoSize = true;
            this.Courselbl.Location = new System.Drawing.Point(42, 35);
            this.Courselbl.Name = "Courselbl";
            this.Courselbl.Size = new System.Drawing.Size(61, 17);
            this.Courselbl.TabIndex = 1;
            this.Courselbl.Text = "Course: ";
            // 
            // CourseCboBox
            // 
            this.CourseCboBox.FormattingEnabled = true;
            this.CourseCboBox.Location = new System.Drawing.Point(109, 31);
            this.CourseCboBox.Name = "CourseCboBox";
            this.CourseCboBox.Size = new System.Drawing.Size(199, 24);
            this.CourseCboBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // quickAccessTree
            // 
            this.quickAccessTree.Location = new System.Drawing.Point(12, 80);
            this.quickAccessTree.Name = "quickAccessTree";
            treeNode10.Name = "Node0";
            treeNode10.Text = "Personal Info";
            treeNode11.Name = "Node1";
            treeNode11.Text = "Courses";
            treeNode12.Name = "Node0";
            treeNode12.Text = "Gradebook";
            this.quickAccessTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            this.quickAccessTree.Size = new System.Drawing.Size(123, 117);
            this.quickAccessTree.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "{Placeholder} query info on enrollment numbers, course descript";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "{Placeholder} select course in course combobox to see list of students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "display student id, full name, and categories";
            // 
            // FacultyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quickAccessTree);
            this.Controls.Add(this.tabControl);
            this.Name = "FacultyUI";
            this.Text = "Faculty";
            this.tabControl.ResumeLayout(false);
            this.personalInfoTab.ResumeLayout(false);
            this.personalInfoTab.PerformLayout();
            this.CourseTab.ResumeLayout(false);
            this.CourseTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.GradeTab.ResumeLayout(false);
            this.GradeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage personalInfoTab;
        private System.Windows.Forms.TabPage CourseTab;
        private System.Windows.Forms.TabPage GradeTab;
        private System.Windows.Forms.ComboBox CourseCboBox;
        private System.Windows.Forms.Label Courselbl;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button submitDataBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Label QuickRefLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView quickAccessTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}