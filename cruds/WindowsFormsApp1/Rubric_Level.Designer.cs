namespace WindowsFormsApp1
{
    partial class Rubric_Level
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
            this.lbl_Rubric_ID = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lbl_Details = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lbl_Measurement_Level = new MetroFramework.Drawing.Html.HtmlLabel();
            this.cmb_rubricid = new MetroFramework.Controls.MetroComboBox();
            this.txt_details = new System.Windows.Forms.TextBox();
            this.txt_measurementlevel = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Rubric_ID
            // 
            this.lbl_Rubric_ID.AutoScroll = true;
            this.lbl_Rubric_ID.AutoScrollMinSize = new System.Drawing.Size(60, 23);
            this.lbl_Rubric_ID.AutoSize = false;
            this.lbl_Rubric_ID.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Rubric_ID.Location = new System.Drawing.Point(230, 31);
            this.lbl_Rubric_ID.Name = "lbl_Rubric_ID";
            this.lbl_Rubric_ID.Size = new System.Drawing.Size(75, 23);
            this.lbl_Rubric_ID.TabIndex = 0;
            this.lbl_Rubric_ID.Text = "Rubric_ID";
            // 
            // lbl_Details
            // 
            this.lbl_Details.AutoScroll = true;
            this.lbl_Details.AutoScrollMinSize = new System.Drawing.Size(44, 23);
            this.lbl_Details.AutoSize = false;
            this.lbl_Details.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Details.Location = new System.Drawing.Point(230, 90);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(75, 23);
            this.lbl_Details.TabIndex = 1;
            this.lbl_Details.Text = "Details";
            this.lbl_Details.Click += new System.EventHandler(this.htmlLabel2_Click);
            // 
            // lbl_Measurement_Level
            // 
            this.lbl_Measurement_Level.AutoScroll = true;
            this.lbl_Measurement_Level.AutoScrollMinSize = new System.Drawing.Size(110, 23);
            this.lbl_Measurement_Level.AutoSize = false;
            this.lbl_Measurement_Level.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Measurement_Level.Location = new System.Drawing.Point(230, 131);
            this.lbl_Measurement_Level.Name = "lbl_Measurement_Level";
            this.lbl_Measurement_Level.Size = new System.Drawing.Size(111, 23);
            this.lbl_Measurement_Level.TabIndex = 1;
            this.lbl_Measurement_Level.Text = "Measurement_Level";
            // 
            // cmb_rubricid
            // 
            this.cmb_rubricid.FormattingEnabled = true;
            this.cmb_rubricid.ItemHeight = 23;
            this.cmb_rubricid.Location = new System.Drawing.Point(400, 31);
            this.cmb_rubricid.Name = "cmb_rubricid";
            this.cmb_rubricid.Size = new System.Drawing.Size(121, 29);
            this.cmb_rubricid.TabIndex = 2;
            this.cmb_rubricid.UseSelectable = true;
            // 
            // txt_details
            // 
            this.txt_details.Location = new System.Drawing.Point(400, 78);
            this.txt_details.Name = "txt_details";
            this.txt_details.Size = new System.Drawing.Size(119, 20);
            this.txt_details.TabIndex = 3;
            this.txt_details.TextChanged += new System.EventHandler(this.txt_details_TextChanged);
            // 
            // txt_measurementlevel
            // 
            this.txt_measurementlevel.Location = new System.Drawing.Point(402, 134);
            this.txt_measurementlevel.Name = "txt_measurementlevel";
            this.txt_measurementlevel.Size = new System.Drawing.Size(119, 20);
            this.txt_measurementlevel.TabIndex = 4;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(580, 181);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(141, 23);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(403, 181);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(141, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Location = new System.Drawing.Point(200, 181);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(141, 23);
            this.btn_dashboard.TabIndex = 7;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(200, 235);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(141, 23);
            this.btn_view.TabIndex = 8;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_Edit,
            this.btn_Delete});
            this.dataGridView1.Location = new System.Drawing.Point(200, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Edit
            // 
            this.btn_Edit.HeaderText = "Edit";
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseColumnTextForButtonValue = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.HeaderText = "Delete";
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseColumnTextForButtonValue = true;
            // 
            // Rubric_Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_dashboard);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txt_measurementlevel);
            this.Controls.Add(this.txt_details);
            this.Controls.Add(this.cmb_rubricid);
            this.Controls.Add(this.lbl_Details);
            this.Controls.Add(this.lbl_Measurement_Level);
            this.Controls.Add(this.lbl_Rubric_ID);
            this.Name = "Rubric_Level";
            this.Text = "Rubric_Level";
            this.Load += new System.EventHandler(this.Rubric_Level_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel lbl_Rubric_ID;
        private MetroFramework.Drawing.Html.HtmlLabel lbl_Details;
        private MetroFramework.Drawing.Html.HtmlLabel lbl_Measurement_Level;
        private MetroFramework.Controls.MetroComboBox cmb_rubricid;
        private System.Windows.Forms.TextBox txt_details;
        private System.Windows.Forms.TextBox txt_measurementlevel;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Edit;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Delete;
    }
}