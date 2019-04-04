namespace WindowsFormsApp1
{
    partial class Dashboard
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
            this.btn_addstudent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_addrubric = new System.Windows.Forms.Button();
            this.btn_clo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_assessment_menu = new System.Windows.Forms.Button();
            this.btn_assessment_component = new System.Windows.Forms.Button();
            this.btn_attendance_menu = new System.Windows.Forms.Button();
            this.btn_student_result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addstudent
            // 
            this.btn_addstudent.Location = new System.Drawing.Point(431, 86);
            this.btn_addstudent.Name = "btn_addstudent";
            this.btn_addstudent.Size = new System.Drawing.Size(115, 23);
            this.btn_addstudent.TabIndex = 0;
            this.btn_addstudent.Text = "Add Student";
            this.btn_addstudent.UseVisualStyleBackColor = true;
            this.btn_addstudent.Click += new System.EventHandler(this.btn_addstudent_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(279, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Welcome to your system";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_addrubric
            // 
            this.btn_addrubric.Location = new System.Drawing.Point(279, 86);
            this.btn_addrubric.Name = "btn_addrubric";
            this.btn_addrubric.Size = new System.Drawing.Size(115, 23);
            this.btn_addrubric.TabIndex = 5;
            this.btn_addrubric.Text = "Add Rubric";
            this.btn_addrubric.UseVisualStyleBackColor = true;
            this.btn_addrubric.Click += new System.EventHandler(this.btn_addassessment_Click);
            // 
            // btn_clo
            // 
            this.btn_clo.Location = new System.Drawing.Point(431, 134);
            this.btn_clo.Name = "btn_clo";
            this.btn_clo.Size = new System.Drawing.Size(115, 23);
            this.btn_clo.TabIndex = 2;
            this.btn_clo.Text = "Add CLO";
            this.btn_clo.UseVisualStyleBackColor = true;
            this.btn_clo.Click += new System.EventHandler(this.bn_clo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add Rubric Level";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_assessment_menu
            // 
            this.btn_assessment_menu.Location = new System.Drawing.Point(279, 191);
            this.btn_assessment_menu.Name = "btn_assessment_menu";
            this.btn_assessment_menu.Size = new System.Drawing.Size(115, 23);
            this.btn_assessment_menu.TabIndex = 7;
            this.btn_assessment_menu.Text = "Assessment Menu";
            this.btn_assessment_menu.UseVisualStyleBackColor = true;
            this.btn_assessment_menu.Click += new System.EventHandler(this.btn_assessment_menu_Click);
            // 
            // btn_assessment_component
            // 
            this.btn_assessment_component.Location = new System.Drawing.Point(431, 191);
            this.btn_assessment_component.Name = "btn_assessment_component";
            this.btn_assessment_component.Size = new System.Drawing.Size(186, 23);
            this.btn_assessment_component.TabIndex = 8;
            this.btn_assessment_component.Text = "Assessment Component Menu";
            this.btn_assessment_component.UseVisualStyleBackColor = true;
            this.btn_assessment_component.Click += new System.EventHandler(this.btn_assessment_component_Click);
            // 
            // btn_attendance_menu
            // 
            this.btn_attendance_menu.Location = new System.Drawing.Point(279, 251);
            this.btn_attendance_menu.Name = "btn_attendance_menu";
            this.btn_attendance_menu.Size = new System.Drawing.Size(186, 23);
            this.btn_attendance_menu.TabIndex = 9;
            this.btn_attendance_menu.Text = "Attendance Menu";
            this.btn_attendance_menu.UseVisualStyleBackColor = true;
            this.btn_attendance_menu.Click += new System.EventHandler(this.btn_attendance_menu_Click);
            // 
            // btn_student_result
            // 
            this.btn_student_result.Location = new System.Drawing.Point(501, 251);
            this.btn_student_result.Name = "btn_student_result";
            this.btn_student_result.Size = new System.Drawing.Size(186, 23);
            this.btn_student_result.TabIndex = 10;
            this.btn_student_result.Text = "Student Result";
            this.btn_student_result.UseVisualStyleBackColor = true;
            this.btn_student_result.Click += new System.EventHandler(this.btn_student_result_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_student_result);
            this.Controls.Add(this.btn_attendance_menu);
            this.Controls.Add(this.btn_assessment_component);
            this.Controls.Add(this.btn_assessment_menu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_addrubric);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_clo);
            this.Controls.Add(this.btn_addstudent);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addstudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_addrubric;
        private System.Windows.Forms.Button btn_clo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_assessment_menu;
        private System.Windows.Forms.Button btn_assessment_component;
        private System.Windows.Forms.Button btn_attendance_menu;
        private System.Windows.Forms.Button btn_student_result;
    }
}