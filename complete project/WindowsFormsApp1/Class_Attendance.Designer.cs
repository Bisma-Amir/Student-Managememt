namespace WindowsFormsApp1
{
    partial class Class_Attendance
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
            this.lbl_attendance_date = new MetroFramework.Drawing.Html.HtmlLabel();
            this.dtp_attendance_date = new MetroFramework.Controls.MetroDateTime();
            this.btnmark = new System.Windows.Forms.Button();
            this.btn_student_attendance = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_attendance_date
            // 
            this.lbl_attendance_date.AutoScroll = true;
            this.lbl_attendance_date.AutoScrollMinSize = new System.Drawing.Size(88, 23);
            this.lbl_attendance_date.AutoSize = false;
            this.lbl_attendance_date.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_attendance_date.Location = new System.Drawing.Point(230, 141);
            this.lbl_attendance_date.Name = "lbl_attendance_date";
            this.lbl_attendance_date.Size = new System.Drawing.Size(105, 23);
            this.lbl_attendance_date.TabIndex = 0;
            this.lbl_attendance_date.Text = "AttendanceDate";
            // 
            // dtp_attendance_date
            // 
            this.dtp_attendance_date.Location = new System.Drawing.Point(367, 135);
            this.dtp_attendance_date.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp_attendance_date.Name = "dtp_attendance_date";
            this.dtp_attendance_date.Size = new System.Drawing.Size(200, 29);
            this.dtp_attendance_date.TabIndex = 1;
            // 
            // btnmark
            // 
            this.btnmark.Location = new System.Drawing.Point(387, 216);
            this.btnmark.Name = "btnmark";
            this.btnmark.Size = new System.Drawing.Size(75, 23);
            this.btnmark.TabIndex = 2;
            this.btnmark.Text = "Mark";
            this.btnmark.UseVisualStyleBackColor = true;
            this.btnmark.Click += new System.EventHandler(this.btnmark_Click);
            // 
            // btn_student_attendance
            // 
            this.btn_student_attendance.Location = new System.Drawing.Point(387, 283);
            this.btn_student_attendance.Name = "btn_student_attendance";
            this.btn_student_attendance.Size = new System.Drawing.Size(230, 23);
            this.btn_student_attendance.TabIndex = 3;
            this.btn_student_attendance.Text = "Student Attendance";
            this.btn_student_attendance.UseVisualStyleBackColor = true;
            this.btn_student_attendance.Click += new System.EventHandler(this.btn_student_attendance_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.Location = new System.Drawing.Point(235, 212);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(100, 31);
            this.btn_dashboard.TabIndex = 20;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // Class_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_dashboard);
            this.Controls.Add(this.btn_student_attendance);
            this.Controls.Add(this.btnmark);
            this.Controls.Add(this.dtp_attendance_date);
            this.Controls.Add(this.lbl_attendance_date);
            this.Name = "Class_Attendance";
            this.Text = "Class_Attendance";
            this.Load += new System.EventHandler(this.Class_Attendance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel lbl_attendance_date;
        private MetroFramework.Controls.MetroDateTime dtp_attendance_date;
        private System.Windows.Forms.Button btnmark;
        private System.Windows.Forms.Button btn_student_attendance;
        private System.Windows.Forms.Button btn_dashboard;
    }
}