﻿namespace WindowsFormsApp1
{
    partial class Assessment_Component
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
            this.txt_total_marks = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_totalmarks = new System.Windows.Forms.Label();
            this.lbl_datecreated = new System.Windows.Forms.Label();
            this.lbl_rubricid = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.dtp_date_created = new System.Windows.Forms.DateTimePicker();
            this.cmbrubricid = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAsssessment_Id = new MetroFramework.Controls.MetroComboBox();
            this.dtp_date_updated = new System.Windows.Forms.DateTimePicker();
            this.lbl_date_updated = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_total_marks
            // 
            this.txt_total_marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_marks.Location = new System.Drawing.Point(326, 168);
            this.txt_total_marks.Name = "txt_total_marks";
            this.txt_total_marks.Size = new System.Drawing.Size(100, 22);
            this.txt_total_marks.TabIndex = 26;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(326, 61);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 24;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(326, 302);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 31);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // lbl_totalmarks
            // 
            this.lbl_totalmarks.AutoSize = true;
            this.lbl_totalmarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalmarks.Location = new System.Drawing.Point(157, 172);
            this.lbl_totalmarks.Name = "lbl_totalmarks";
            this.lbl_totalmarks.Size = new System.Drawing.Size(90, 16);
            this.lbl_totalmarks.TabIndex = 20;
            this.lbl_totalmarks.Text = "Total Marks";
            // 
            // lbl_datecreated
            // 
            this.lbl_datecreated.AutoSize = true;
            this.lbl_datecreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datecreated.Location = new System.Drawing.Point(157, 200);
            this.lbl_datecreated.Name = "lbl_datecreated";
            this.lbl_datecreated.Size = new System.Drawing.Size(100, 16);
            this.lbl_datecreated.TabIndex = 19;
            this.lbl_datecreated.Text = "Date Created";
            // 
            // lbl_rubricid
            // 
            this.lbl_rubricid.AutoSize = true;
            this.lbl_rubricid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rubricid.Location = new System.Drawing.Point(157, 144);
            this.lbl_rubricid.Name = "lbl_rubricid";
            this.lbl_rubricid.Size = new System.Drawing.Size(74, 16);
            this.lbl_rubricid.TabIndex = 18;
            this.lbl_rubricid.Text = "Rubric_Id";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(157, 65);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 16);
            this.lbl_name.TabIndex = 17;
            this.lbl_name.Text = "Name";
            // 
            // dtp_date_created
            // 
            this.dtp_date_created.Location = new System.Drawing.Point(326, 202);
            this.dtp_date_created.Name = "dtp_date_created";
            this.dtp_date_created.Size = new System.Drawing.Size(200, 20);
            this.dtp_date_created.TabIndex = 31;
            // 
            // cmbrubricid
            // 
            this.cmbrubricid.FormattingEnabled = true;
            this.cmbrubricid.ItemHeight = 23;
            this.cmbrubricid.Location = new System.Drawing.Point(326, 133);
            this.cmbrubricid.Name = "cmbrubricid";
            this.cmbrubricid.Size = new System.Drawing.Size(139, 29);
            this.cmbrubricid.TabIndex = 32;
            this.cmbrubricid.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Asssessment_Id";
            // 
            // cmbAsssessment_Id
            // 
            this.cmbAsssessment_Id.FormattingEnabled = true;
            this.cmbAsssessment_Id.ItemHeight = 23;
            this.cmbAsssessment_Id.Location = new System.Drawing.Point(326, 89);
            this.cmbAsssessment_Id.Name = "cmbAsssessment_Id";
            this.cmbAsssessment_Id.Size = new System.Drawing.Size(139, 29);
            this.cmbAsssessment_Id.TabIndex = 34;
            this.cmbAsssessment_Id.UseSelectable = true;
            // 
            // dtp_date_updated
            // 
            this.dtp_date_updated.Location = new System.Drawing.Point(326, 248);
            this.dtp_date_updated.Name = "dtp_date_updated";
            this.dtp_date_updated.Size = new System.Drawing.Size(200, 20);
            this.dtp_date_updated.TabIndex = 36;
            // 
            // lbl_date_updated
            // 
            this.lbl_date_updated.AutoSize = true;
            this.lbl_date_updated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_updated.Location = new System.Drawing.Point(157, 246);
            this.lbl_date_updated.Name = "lbl_date_updated";
            this.lbl_date_updated.Size = new System.Drawing.Size(105, 16);
            this.lbl_date_updated.TabIndex = 35;
            this.lbl_date_updated.Text = "Date Updated";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(178, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 37;
            this.button1.Text = "DashBoard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(488, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 31);
            this.button2.TabIndex = 38;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Assessment_Component
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtp_date_updated);
            this.Controls.Add(this.lbl_date_updated);
            this.Controls.Add(this.cmbAsssessment_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbrubricid);
            this.Controls.Add(this.dtp_date_created);
            this.Controls.Add(this.txt_total_marks);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_totalmarks);
            this.Controls.Add(this.lbl_datecreated);
            this.Controls.Add(this.lbl_rubricid);
            this.Controls.Add(this.lbl_name);
            this.Name = "Assessment_Component";
            this.Text = "Assessment_Component";
            this.Load += new System.EventHandler(this.Assessment_Component_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_total_marks;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_totalmarks;
        private System.Windows.Forms.Label lbl_datecreated;
        private System.Windows.Forms.Label lbl_rubricid;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.DateTimePicker dtp_date_created;
        private MetroFramework.Controls.MetroComboBox cmbrubricid;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cmbAsssessment_Id;
        private System.Windows.Forms.DateTimePicker dtp_date_updated;
        private System.Windows.Forms.Label lbl_date_updated;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}