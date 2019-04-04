namespace WindowsFormsApp1
{
    partial class student_attendance
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
            this.lbl_class_attendance_ids = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lbl_student_ids = new MetroFramework.Drawing.Html.HtmlLabel();
            this.cmb_class_attendance_ids = new MetroFramework.Controls.MetroComboBox();
            this.cmb_student_ids = new MetroFramework.Controls.MetroComboBox();
            this.cmb_status = new MetroFramework.Controls.MetroComboBox();
            this.lbl_status = new MetroFramework.Drawing.Html.HtmlLabel();
            this.btn_mark = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_class_attendance_ids
            // 
            this.lbl_class_attendance_ids.AutoScroll = true;
            this.lbl_class_attendance_ids.AutoScrollMinSize = new System.Drawing.Size(114, 23);
            this.lbl_class_attendance_ids.AutoSize = false;
            this.lbl_class_attendance_ids.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_class_attendance_ids.Location = new System.Drawing.Point(226, 104);
            this.lbl_class_attendance_ids.Name = "lbl_class_attendance_ids";
            this.lbl_class_attendance_ids.Size = new System.Drawing.Size(126, 23);
            this.lbl_class_attendance_ids.TabIndex = 0;
            this.lbl_class_attendance_ids.Text = "Class Attendance Ids";
            // 
            // lbl_student_ids
            // 
            this.lbl_student_ids.AutoScroll = true;
            this.lbl_student_ids.AutoScrollMinSize = new System.Drawing.Size(65, 23);
            this.lbl_student_ids.AutoSize = false;
            this.lbl_student_ids.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_student_ids.Location = new System.Drawing.Point(226, 179);
            this.lbl_student_ids.Name = "lbl_student_ids";
            this.lbl_student_ids.Size = new System.Drawing.Size(75, 23);
            this.lbl_student_ids.TabIndex = 1;
            this.lbl_student_ids.Text = "Student Ids";
            // 
            // cmb_class_attendance_ids
            // 
            this.cmb_class_attendance_ids.FormattingEnabled = true;
            this.cmb_class_attendance_ids.ItemHeight = 23;
            this.cmb_class_attendance_ids.Location = new System.Drawing.Point(384, 104);
            this.cmb_class_attendance_ids.Name = "cmb_class_attendance_ids";
            this.cmb_class_attendance_ids.Size = new System.Drawing.Size(121, 29);
            this.cmb_class_attendance_ids.TabIndex = 2;
            this.cmb_class_attendance_ids.UseSelectable = true;
            // 
            // cmb_student_ids
            // 
            this.cmb_student_ids.FormattingEnabled = true;
            this.cmb_student_ids.ItemHeight = 23;
            this.cmb_student_ids.Location = new System.Drawing.Point(384, 179);
            this.cmb_student_ids.Name = "cmb_student_ids";
            this.cmb_student_ids.Size = new System.Drawing.Size(121, 29);
            this.cmb_student_ids.TabIndex = 3;
            this.cmb_student_ids.UseSelectable = true;
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.ItemHeight = 23;
            this.cmb_status.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Leave",
            "Late"});
            this.cmb_status.Location = new System.Drawing.Point(384, 246);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(121, 29);
            this.cmb_status.TabIndex = 5;
            this.cmb_status.UseSelectable = true;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoScroll = true;
            this.lbl_status.AutoScrollMinSize = new System.Drawing.Size(41, 23);
            this.lbl_status.AutoSize = false;
            this.lbl_status.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_status.Location = new System.Drawing.Point(226, 246);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(75, 23);
            this.lbl_status.TabIndex = 4;
            this.lbl_status.Text = "Status";
            // 
            // btn_mark
            // 
            this.btn_mark.Location = new System.Drawing.Point(391, 315);
            this.btn_mark.Name = "btn_mark";
            this.btn_mark.Size = new System.Drawing.Size(75, 23);
            this.btn_mark.TabIndex = 6;
            this.btn_mark.Text = "Mark";
            this.btn_mark.UseVisualStyleBackColor = true;
            this.btn_mark.Click += new System.EventHandler(this.btn_mark_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.Location = new System.Drawing.Point(226, 315);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(100, 31);
            this.btn_dashboard.TabIndex = 20;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // student_attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_dashboard);
            this.Controls.Add(this.btn_mark);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.cmb_student_ids);
            this.Controls.Add(this.cmb_class_attendance_ids);
            this.Controls.Add(this.lbl_student_ids);
            this.Controls.Add(this.lbl_class_attendance_ids);
            this.Name = "student_attendance";
            this.Text = "student_attendance";
            this.Load += new System.EventHandler(this.student_attendance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel lbl_class_attendance_ids;
        private MetroFramework.Drawing.Html.HtmlLabel lbl_student_ids;
        private MetroFramework.Controls.MetroComboBox cmb_class_attendance_ids;
        private MetroFramework.Controls.MetroComboBox cmb_student_ids;
        private MetroFramework.Controls.MetroComboBox cmb_status;
        private MetroFramework.Drawing.Html.HtmlLabel lbl_status;
        private System.Windows.Forms.Button btn_mark;
        private System.Windows.Forms.Button btn_dashboard;
    }
}