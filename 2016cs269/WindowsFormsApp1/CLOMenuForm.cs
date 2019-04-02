using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class CLOMenuForm : Form
    {
        public int ID;
        public CLOMenuForm()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
        SqlConnection con = new SqlConnection("Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True");

        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dbo.Clo(Name, DateCreated,DateUpdated) values('" + txt_name.Text+ "', '"+dateTimePicker_Date_Created.Value+"','"+DateTime.Today+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("CLO has been added");
            txt_name.Text = "";
     

        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dbo.Clo";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        

        private void btn_addclo_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM dbo.Student where Name = '" + txt_name.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM dbo.Clo";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public string ConectionString = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection Connection = new SqlConnection(ConectionString);
            Connection.Open();
            if (e.ColumnIndex == dataGridView1.Columns["btnEDIT"].Index)
            {
                btn_add.Hide();
                lbl_datecreated.Hide();
                dateTimePicker_Date_Created.Hide();
                lbl_Date_Updated.Show();
                btn_Update.Show();
                dateTimePicker_Date_Updated.Show();
                int row = e.RowIndex;

                int id = Convert.ToInt32(dataGridView1.Rows[row].Cells["Id"].Value);
                ID = id;
               
                string Get_Query = "select * FROM dbo.Clo  WHERE Id = '" + ID + "'";
                SqlCommand cmd = new SqlCommand(Get_Query, Connection);
                var myReader = cmd.ExecuteReader();
                myReader.Read();
                txt_name.Text = myReader[1].ToString();
                
            }
            
            if (e.ColumnIndex == dataGridView1.Columns["btnDelete"].Index)
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    int row = e.RowIndex;
                    int Id = Convert.ToInt32(dataGridView1.Rows[row].Cells["Id"].Value);
                    string Delete_Query = "DELETE FROM dbo.Clo  WHERE Id = '" + ID + "'";
                    SqlCommand cmd = new SqlCommand(Delete_Query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been deleted!");
                }
            }
            
        }

        private void dateTimePicker1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void Add_CLO_Load(object sender, EventArgs e)
        {
            btn_Update.Hide();
            lbl_Date_Updated.Hide();
            dateTimePicker_Date_Updated.Hide();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update dbo.Clo SET Name = '" + txt_name.Text + "', DateCreated = '" + DateTime.Today + "', DateUpdated = '" + dateTimePicker_Date_Updated.Value + "' WHERE Id = '" + ID + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("CLO HAS BEEN UPDATED");
        }
    }
}
