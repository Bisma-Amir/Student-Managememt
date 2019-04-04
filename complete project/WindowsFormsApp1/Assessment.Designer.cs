namespace WindowsFormsApp1
{
    partial class Assessment
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
            this.lbl_title = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_total_marks = new System.Windows.Forms.TextBox();
            this.lbl_total_marks = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txt_total_weightage = new System.Windows.Forms.TextBox();
            this.lbl_Total_Weightage = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lb_date_created = new MetroFramework.Drawing.Html.HtmlLabel();
            this.dtp_date_created = new MetroFramework.Controls.MetroDateTime();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_dash_board = new System.Windows.Forms.Button();
            this.btn_View_Assessments = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoScroll = true;
            this.lbl_title.AutoScrollMinSize = new System.Drawing.Size(32, 23);
            this.lbl_title.AutoSize = false;
            this.lbl_title.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_title.Location = new System.Drawing.Point(99, 43);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(96, 23);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Title";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(251, 43);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(100, 20);
            this.txt_title.TabIndex = 1;
            // 
            // txt_total_marks
            // 
            this.txt_total_marks.Location = new System.Drawing.Point(251, 88);
            this.txt_total_marks.Name = "txt_total_marks";
            this.txt_total_marks.Size = new System.Drawing.Size(100, 20);
            this.txt_total_marks.TabIndex = 3;
            // 
            // lbl_total_marks
            // 
            this.lbl_total_marks.AutoScroll = true;
            this.lbl_total_marks.AutoScrollMinSize = new System.Drawing.Size(66, 23);
            this.lbl_total_marks.AutoSize = false;
            this.lbl_total_marks.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_total_marks.Location = new System.Drawing.Point(99, 88);
            this.lbl_total_marks.Name = "lbl_total_marks";
            this.lbl_total_marks.Size = new System.Drawing.Size(96, 23);
            this.lbl_total_marks.TabIndex = 2;
            this.lbl_total_marks.Text = "TotalMarks";
            // 
            // txt_total_weightage
            // 
            this.txt_total_weightage.Location = new System.Drawing.Point(251, 136);
            this.txt_total_weightage.Name = "txt_total_weightage";
            this.txt_total_weightage.Size = new System.Drawing.Size(100, 20);
            this.txt_total_weightage.TabIndex = 5;
            // 
            // lbl_Total_Weightage
            // 
            this.lbl_Total_Weightage.AutoScroll = true;
            this.lbl_Total_Weightage.AutoScrollMinSize = new System.Drawing.Size(87, 23);
            this.lbl_Total_Weightage.AutoSize = false;
            this.lbl_Total_Weightage.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Total_Weightage.Location = new System.Drawing.Point(99, 136);
            this.lbl_Total_Weightage.Name = "lbl_Total_Weightage";
            this.lbl_Total_Weightage.Size = new System.Drawing.Size(96, 23);
            this.lbl_Total_Weightage.TabIndex = 4;
            this.lbl_Total_Weightage.Text = "TotalWeightage";
            // 
            // lb_date_created
            // 
            this.lb_date_created.AutoScroll = true;
            this.lb_date_created.AutoScrollMinSize = new System.Drawing.Size(75, 23);
            this.lb_date_created.AutoSize = false;
            this.lb_date_created.BackColor = System.Drawing.SystemColors.Window;
            this.lb_date_created.Location = new System.Drawing.Point(97, 180);
            this.lb_date_created.Name = "lb_date_created";
            this.lb_date_created.Size = new System.Drawing.Size(75, 23);
            this.lb_date_created.TabIndex = 1;
            this.lb_date_created.Text = "Date Created";
            // 
            // dtp_date_created
            // 
            this.dtp_date_created.Location = new System.Drawing.Point(228, 174);
            this.dtp_date_created.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp_date_created.Name = "dtp_date_created";
            this.dtp_date_created.Size = new System.Drawing.Size(200, 29);
            this.dtp_date_created.TabIndex = 6;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(247, 227);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_dash_board
            // 
            this.btn_dash_board.Location = new System.Drawing.Point(95, 227);
            this.btn_dash_board.Name = "btn_dash_board";
            this.btn_dash_board.Size = new System.Drawing.Size(75, 23);
            this.btn_dash_board.TabIndex = 8;
            this.btn_dash_board.Text = "Dash Board";
            this.btn_dash_board.UseVisualStyleBackColor = true;
            this.btn_dash_board.Click += new System.EventHandler(this.btn_dash_board_Click);
            // 
            // btn_View_Assessments
            // 
            this.btn_View_Assessments.Location = new System.Drawing.Point(95, 274);
            this.btn_View_Assessments.Name = "btn_View_Assessments";
            this.btn_View_Assessments.Size = new System.Drawing.Size(129, 23);
            this.btn_View_Assessments.TabIndex = 9;
            this.btn_View_Assessments.Text = "View Assessments";
            this.btn_View_Assessments.UseVisualStyleBackColor = true;
            this.btn_View_Assessments.Click += new System.EventHandler(this.btn_View_Assessments_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(365, 227);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_Delete,
            this.btn_Edit});
            this.dataGridView1.Location = new System.Drawing.Point(42, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.HeaderText = "Delete";
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseColumnTextForButtonValue = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.HeaderText = "Edit";
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseColumnTextForButtonValue = true;
            // 
            // Assessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_View_Assessments);
            this.Controls.Add(this.btn_dash_board);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dtp_date_created);
            this.Controls.Add(this.lb_date_created);
            this.Controls.Add(this.txt_total_weightage);
            this.Controls.Add(this.lbl_Total_Weightage);
            this.Controls.Add(this.txt_total_marks);
            this.Controls.Add(this.lbl_total_marks);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.lbl_title);
            this.Name = "Assessment";
            this.Text = "Assessment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel lbl_title;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_total_marks;
        private MetroFramework.Drawing.Html.HtmlLabel lbl_total_marks;
        private System.Windows.Forms.TextBox txt_total_weightage;
        private MetroFramework.Drawing.Html.HtmlLabel lbl_Total_Weightage;
        private MetroFramework.Drawing.Html.HtmlLabel lb_date_created;
        private MetroFramework.Controls.MetroDateTime dtp_date_created;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_dash_board;
        private System.Windows.Forms.Button btn_View_Assessments;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Delete;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Edit;
    }
}