namespace UniversityManagement
{
    partial class AssignProfessorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label lblProfessors;
        private System.Windows.Forms.ComboBox cmbProfessors;
        private System.Windows.Forms.Button btnAssignProfessor;

        private void InitializeComponent()
        {
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.lblProfessors = new System.Windows.Forms.Label();
            this.cmbProfessors = new System.Windows.Forms.ComboBox();
            this.btnAssignProfessor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Location = new System.Drawing.Point(12, 15);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(71, 13);
            this.lblCourseCode.TabIndex = 0;
            this.lblCourseCode.Text = "Course Code:";
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(90, 12);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(182, 20);
            this.txtCourseCode.TabIndex = 1;
            // 
            // lblProfessors
            // 
            this.lblProfessors.AutoSize = true;
            this.lblProfessors.Location = new System.Drawing.Point(12, 45);
            this.lblProfessors.Name = "lblProfessors";
            this.lblProfessors.Size = new System.Drawing.Size(73, 13);
            this.lblProfessors.TabIndex = 2;
            this.lblProfessors.Text = "Professors ID:";
            // 
            // cmbProfessors
            // 
            this.cmbProfessors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfessors.FormattingEnabled = true;
            this.cmbProfessors.Location = new System.Drawing.Point(90, 42);
            this.cmbProfessors.Name = "cmbProfessors";
            this.cmbProfessors.Size = new System.Drawing.Size(182, 21);
            this.cmbProfessors.TabIndex = 3;
            // 
            // btnAssignProfessor
            // 
            this.btnAssignProfessor.Location = new System.Drawing.Point(90, 75);
            this.btnAssignProfessor.Name = "btnAssignProfessor";
            this.btnAssignProfessor.Size = new System.Drawing.Size(182, 23);
            this.btnAssignProfessor.TabIndex = 4;
            this.btnAssignProfessor.Text = "Assign Professor";
            this.btnAssignProfessor.UseVisualStyleBackColor = true;
            this.btnAssignProfessor.Click += new System.EventHandler(this.btnAssignProfessor_Click);
            // 
            // AssignProfessorForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.lblCourseCode);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.lblProfessors);
            this.Controls.Add(this.cmbProfessors);
            this.Controls.Add(this.btnAssignProfessor);
            this.Name = "AssignProfessorForm";
            this.Text = "Assign Professor to Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
