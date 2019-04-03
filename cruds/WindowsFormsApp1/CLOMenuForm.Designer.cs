namespace WindowsFormsApp1
{
    partial class CLOMenuForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_datecreated = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Date_Created = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.dateTimePicker_Date_Updated = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date_Updated = new System.Windows.Forms.Label();
            this.btnDELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(282, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add CLO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(212, 84);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 16);
            this.lbl_name.TabIndex = 14;
            this.lbl_name.Text = "Name";
            // 
            // lbl_datecreated
            // 
            this.lbl_datecreated.AutoSize = true;
            this.lbl_datecreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datecreated.Location = new System.Drawing.Point(212, 125);
            this.lbl_datecreated.Name = "lbl_datecreated";
            this.lbl_datecreated.Size = new System.Drawing.Size(100, 16);
            this.lbl_datecreated.TabIndex = 15;
            this.lbl_datecreated.Text = "Date Created";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(418, 78);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(200, 22);
            this.txt_name.TabIndex = 16;
            // 
            // dateTimePicker_Date_Created
            // 
            this.dateTimePicker_Date_Created.Location = new System.Drawing.Point(418, 121);
            this.dateTimePicker_Date_Created.Name = "dateTimePicker_Date_Created";
            this.dateTimePicker_Date_Created.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Date_Created.TabIndex = 17;
            this.dateTimePicker_Date_Created.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.dateTimePicker1_ControlAdded);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(487, 230);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 31);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.Location = new System.Drawing.Point(233, 230);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(100, 31);
            this.btn_dashboard.TabIndex = 19;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_view
            // 
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(232, 281);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(100, 31);
            this.btn_view.TabIndex = 32;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDELETE,
            this.btnEDIT});
            this.dataGridView1.Location = new System.Drawing.Point(200, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(512, 150);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(487, 281);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 31);
            this.btn_search.TabIndex = 31;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_addclo_Click);
            // 
            // dateTimePicker_Date_Updated
            // 
            this.dateTimePicker_Date_Updated.Location = new System.Drawing.Point(418, 173);
            this.dateTimePicker_Date_Updated.Name = "dateTimePicker_Date_Updated";
            this.dateTimePicker_Date_Updated.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Date_Updated.TabIndex = 34;
            // 
            // lbl_Date_Updated
            // 
            this.lbl_Date_Updated.AutoSize = true;
            this.lbl_Date_Updated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_Updated.Location = new System.Drawing.Point(212, 177);
            this.lbl_Date_Updated.Name = "lbl_Date_Updated";
            this.lbl_Date_Updated.Size = new System.Drawing.Size(105, 16);
            this.lbl_Date_Updated.TabIndex = 33;
            this.lbl_Date_Updated.Text = "Date Updated";
            // 
            // btnDELETE
            // 
            this.btnDELETE.HeaderText = "DELETE";
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.ReadOnly = true;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseColumnTextForButtonValue = true;
            // 
            // btnEDIT
            // 
            this.btnEDIT.HeaderText = "EDIT";
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.ReadOnly = true;
            this.btnEDIT.Text = "EDIT";
            this.btnEDIT.UseColumnTextForButtonValue = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(487, 230);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(100, 31);
            this.btn_Update.TabIndex = 35;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Add_CLO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 514);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.dateTimePicker_Date_Updated);
            this.Controls.Add(this.lbl_Date_Updated);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_dashboard);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dateTimePicker_Date_Created);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_datecreated);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.button1);
            this.Name = "Add_CLO";
            this.Text = "Add_CLO";
            this.Load += new System.EventHandler(this.Add_CLO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_datecreated;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date_Created;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date_Updated;
        private System.Windows.Forms.Label lbl_Date_Updated;
        private System.Windows.Forms.DataGridViewButtonColumn btnDELETE;
        private System.Windows.Forms.DataGridViewButtonColumn btnEDIT;
        private System.Windows.Forms.Button btn_Update;
    }
}