namespace WindowsFormsApp1
{
    partial class RubricMenuForm
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
            this.lbl_clo = new System.Windows.Forms.Label();
            this.cmb_clo = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_details = new System.Windows.Forms.TextBox();
            this.lbl_details = new System.Windows.Forms.Label();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_EDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_clo
            // 
            this.lbl_clo.AutoSize = true;
            this.lbl_clo.Location = new System.Drawing.Point(289, 77);
            this.lbl_clo.Name = "lbl_clo";
            this.lbl_clo.Size = new System.Drawing.Size(28, 13);
            this.lbl_clo.TabIndex = 0;
            this.lbl_clo.Text = "CLO";
            // 
            // cmb_clo
            // 
            this.cmb_clo.FormattingEnabled = true;
            this.cmb_clo.Location = new System.Drawing.Point(437, 69);
            this.cmb_clo.Name = "cmb_clo";
            this.cmb_clo.Size = new System.Drawing.Size(121, 21);
            this.cmb_clo.TabIndex = 1;
            this.cmb_clo.SelectedIndexChanged += new System.EventHandler(this.cmb_clo_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(483, 193);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_details
            // 
            this.txt_details.Location = new System.Drawing.Point(437, 119);
            this.txt_details.Name = "txt_details";
            this.txt_details.Size = new System.Drawing.Size(121, 20);
            this.txt_details.TabIndex = 3;
            // 
            // lbl_details
            // 
            this.lbl_details.AutoSize = true;
            this.lbl_details.Location = new System.Drawing.Point(289, 126);
            this.lbl_details.Name = "lbl_details";
            this.lbl_details.Size = new System.Drawing.Size(39, 13);
            this.lbl_details.TabIndex = 4;
            this.lbl_details.Text = "Details";
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Location = new System.Drawing.Point(292, 179);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(75, 23);
            this.btn_dashboard.TabIndex = 5;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(605, 193);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(292, 225);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(75, 23);
            this.btn_view.TabIndex = 7;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_EDIT,
            this.btn_DELETE});
            this.dataGridView1.Location = new System.Drawing.Point(103, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(685, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_EDIT
            // 
            this.btn_EDIT.HeaderText = "EDIT";
            this.btn_EDIT.Name = "btn_EDIT";
            this.btn_EDIT.ReadOnly = true;
            this.btn_EDIT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_EDIT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_EDIT.Text = "EDIT";
            this.btn_EDIT.UseColumnTextForButtonValue = true;
            // 
            // btn_DELETE
            // 
            this.btn_DELETE.HeaderText = "DELETE";
            this.btn_DELETE.Name = "btn_DELETE";
            this.btn_DELETE.Text = "DELETE";
            this.btn_DELETE.UseColumnTextForButtonValue = true;
            // 
            // RubricMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btn_dashboard);
            this.Controls.Add(this.lbl_details);
            this.Controls.Add(this.txt_details);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmb_clo);
            this.Controls.Add(this.lbl_clo);
            this.Name = "RubricMenuForm";
            this.Text = "RubricMenuForm";
            this.Load += new System.EventHandler(this.RubricMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_clo;
        private System.Windows.Forms.ComboBox cmb_clo;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_details;
        private System.Windows.Forms.Label lbl_details;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn btn_EDIT;
        private System.Windows.Forms.DataGridViewButtonColumn btn_DELETE;
    }
}