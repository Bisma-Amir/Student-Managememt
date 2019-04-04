namespace WindowsFormsApp1
{
    partial class Student_result
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmb_student_ids = new MetroFramework.Controls.MetroComboBox();
            this.cmb_assessment_component_ids = new MetroFramework.Controls.MetroComboBox();
            this.lbl_student_ids = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lbl_assessment_component_ids = new MetroFramework.Drawing.Html.HtmlLabel();
            this.cmb_rubric_measurement_ids = new MetroFramework.Controls.MetroComboBox();
            this.lbl_rubric_measurement_ids = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lbl_EvaluationDate = new MetroFramework.Drawing.Html.HtmlLabel();
            this.dtp_EvaluationDate = new MetroFramework.Controls.MetroDateTime();
            this.btn_Add = new System.Windows.Forms.Button();
            this.datagridview_result = new MetroFramework.Controls.MetroGrid();
            this.btn_show_result = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_result)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_student_ids
            // 
            this.cmb_student_ids.FormattingEnabled = true;
            this.cmb_student_ids.ItemHeight = 23;
            this.cmb_student_ids.Location = new System.Drawing.Point(169, 20);
            this.cmb_student_ids.Name = "cmb_student_ids";
            this.cmb_student_ids.Size = new System.Drawing.Size(121, 29);
            this.cmb_student_ids.TabIndex = 7;
            this.cmb_student_ids.UseSelectable = true;
            // 
            // cmb_assessment_component_ids
            // 
            this.cmb_assessment_component_ids.FormattingEnabled = true;
            this.cmb_assessment_component_ids.ItemHeight = 23;
            this.cmb_assessment_component_ids.Location = new System.Drawing.Point(169, 66);
            this.cmb_assessment_component_ids.Name = "cmb_assessment_component_ids";
            this.cmb_assessment_component_ids.Size = new System.Drawing.Size(121, 29);
            this.cmb_assessment_component_ids.TabIndex = 6;
            this.cmb_assessment_component_ids.UseSelectable = true;
            // 
            // lbl_student_ids
            // 
            this.lbl_student_ids.AutoScroll = true;
            this.lbl_student_ids.AutoScrollMinSize = new System.Drawing.Size(65, 23);
            this.lbl_student_ids.AutoSize = false;
            this.lbl_student_ids.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_student_ids.Location = new System.Drawing.Point(11, 20);
            this.lbl_student_ids.Name = "lbl_student_ids";
            this.lbl_student_ids.Size = new System.Drawing.Size(75, 23);
            this.lbl_student_ids.TabIndex = 5;
            this.lbl_student_ids.Text = "Student Ids";
            // 
            // lbl_assessment_component_ids
            // 
            this.lbl_assessment_component_ids.AutoScroll = true;
            this.lbl_assessment_component_ids.AutoScrollMinSize = new System.Drawing.Size(148, 23);
            this.lbl_assessment_component_ids.AutoSize = false;
            this.lbl_assessment_component_ids.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_assessment_component_ids.Location = new System.Drawing.Point(11, 66);
            this.lbl_assessment_component_ids.Name = "lbl_assessment_component_ids";
            this.lbl_assessment_component_ids.Size = new System.Drawing.Size(152, 23);
            this.lbl_assessment_component_ids.TabIndex = 4;
            this.lbl_assessment_component_ids.Text = "Assessment Component Ids";
            // 
            // cmb_rubric_measurement_ids
            // 
            this.cmb_rubric_measurement_ids.FormattingEnabled = true;
            this.cmb_rubric_measurement_ids.ItemHeight = 23;
            this.cmb_rubric_measurement_ids.Location = new System.Drawing.Point(169, 124);
            this.cmb_rubric_measurement_ids.Name = "cmb_rubric_measurement_ids";
            this.cmb_rubric_measurement_ids.Size = new System.Drawing.Size(121, 29);
            this.cmb_rubric_measurement_ids.TabIndex = 9;
            this.cmb_rubric_measurement_ids.UseSelectable = true;
            // 
            // lbl_rubric_measurement_ids
            // 
            this.lbl_rubric_measurement_ids.AutoScroll = true;
            this.lbl_rubric_measurement_ids.AutoScrollMinSize = new System.Drawing.Size(131, 23);
            this.lbl_rubric_measurement_ids.AutoSize = false;
            this.lbl_rubric_measurement_ids.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_rubric_measurement_ids.Location = new System.Drawing.Point(11, 124);
            this.lbl_rubric_measurement_ids.Name = "lbl_rubric_measurement_ids";
            this.lbl_rubric_measurement_ids.Size = new System.Drawing.Size(152, 23);
            this.lbl_rubric_measurement_ids.TabIndex = 8;
            this.lbl_rubric_measurement_ids.Text = "Rubric Measurement Ids";
            // 
            // lbl_EvaluationDate
            // 
            this.lbl_EvaluationDate.AutoScroll = true;
            this.lbl_EvaluationDate.AutoScrollMinSize = new System.Drawing.Size(85, 23);
            this.lbl_EvaluationDate.AutoSize = false;
            this.lbl_EvaluationDate.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_EvaluationDate.Location = new System.Drawing.Point(11, 184);
            this.lbl_EvaluationDate.Name = "lbl_EvaluationDate";
            this.lbl_EvaluationDate.Size = new System.Drawing.Size(126, 23);
            this.lbl_EvaluationDate.TabIndex = 9;
            this.lbl_EvaluationDate.Text = "EvaluationDate";
            // 
            // dtp_EvaluationDate
            // 
            this.dtp_EvaluationDate.Location = new System.Drawing.Point(169, 178);
            this.dtp_EvaluationDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp_EvaluationDate.Name = "dtp_EvaluationDate";
            this.dtp_EvaluationDate.Size = new System.Drawing.Size(200, 29);
            this.dtp_EvaluationDate.TabIndex = 10;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(169, 238);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // datagridview_result
            // 
            this.datagridview_result.AllowUserToResizeRows = false;
            this.datagridview_result.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.datagridview_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview_result.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datagridview_result.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridview_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_result.DefaultCellStyle = dataGridViewCellStyle5;
            this.datagridview_result.EnableHeadersVisualStyles = false;
            this.datagridview_result.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.datagridview_result.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.datagridview_result.Location = new System.Drawing.Point(375, 73);
            this.datagridview_result.Name = "datagridview_result";
            this.datagridview_result.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_result.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagridview_result.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridview_result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_result.Size = new System.Drawing.Size(413, 342);
            this.datagridview_result.TabIndex = 12;
            // 
            // btn_show_result
            // 
            this.btn_show_result.Location = new System.Drawing.Point(574, 44);
            this.btn_show_result.Name = "btn_show_result";
            this.btn_show_result.Size = new System.Drawing.Size(75, 23);
            this.btn_show_result.TabIndex = 13;
            this.btn_show_result.Text = "Show Result";
            this.btn_show_result.UseVisualStyleBackColor = true;
            this.btn_show_result.Click += new System.EventHandler(this.btn_show_result_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(704, 421);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 14;
            this.btn_print.Text = "Print Result";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Student_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_show_result);
            this.Controls.Add(this.datagridview_result);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dtp_EvaluationDate);
            this.Controls.Add(this.lbl_EvaluationDate);
            this.Controls.Add(this.cmb_rubric_measurement_ids);
            this.Controls.Add(this.lbl_rubric_measurement_ids);
            this.Controls.Add(this.cmb_student_ids);
            this.Controls.Add(this.cmb_assessment_component_ids);
            this.Controls.Add(this.lbl_student_ids);
            this.Controls.Add(this.lbl_assessment_component_ids);
            this.Name = "Student_result";
            this.Text = "Student_result";
            this.Load += new System.EventHandler(this.Student_result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmb_student_ids;
        private MetroFramework.Controls.MetroComboBox cmb_assessment_component_ids;
        private MetroFramework.Drawing.Html.HtmlLabel lbl_student_ids;
        private MetroFramework.Drawing.Html.HtmlLabel lbl_assessment_component_ids;
        private MetroFramework.Controls.MetroComboBox cmb_rubric_measurement_ids;
        private MetroFramework.Drawing.Html.HtmlLabel lbl_rubric_measurement_ids;
        private MetroFramework.Drawing.Html.HtmlLabel lbl_EvaluationDate;
        private MetroFramework.Controls.MetroDateTime dtp_EvaluationDate;
        private System.Windows.Forms.Button btn_Add;
        private MetroFramework.Controls.MetroGrid datagridview_result;
        private System.Windows.Forms.Button btn_show_result;
        private System.Windows.Forms.Button btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}