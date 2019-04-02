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
    public partial class RubricMenuForm : Form
    {
        public RubricMenuForm()
        {
            InitializeComponent();
        }
        public int ID;
        private void btn_view_Click(object sender, EventArgs e)
        {
            SqlConnection q = new SqlConnection(ConectionString);
            q.Open();
            String query = "SELECT * FROM Rubric";
            SqlDataAdapter SDA = new SqlDataAdapter(query, q);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection q = new SqlConnection(ConectionString);
            q.Open();
            String GetiingCloid = "SELECT * FROM dbo.Clo WHERE Name='" + cmb_clo.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(GetiingCloid, q);
            var Reader = cmd.ExecuteReader();
            Reader.Read();
            int id = Reader.GetInt32(0);
            


            if (q.State == ConnectionState.Open)
            {
                
                string SQLQuery = "insert into dbo.Rubric (Details,CloId) values('" + txt_details.Text.ToString() + "','" + id+ "')";
                SqlCommand abc = new SqlCommand(SQLQuery, q);
                Reader.Close();
                abc.ExecuteNonQuery();
                MessageBox.Show("Rubric is Added");
            }
            
        }
        public string ConectionString = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection Connection = new SqlConnection(ConectionString);
            Connection.Open();
            if (e.ColumnIndex == dataGridView1.Columns["btn_EDIT"].Index)
            {
                //SqlConnection com = new SqlConnection(ConectionString);
                //com.Open();
                //if (com.State == ConnectionState.Open)
                //{
                //    string QUERYCLO = "select * from dbo.Clo";
                //    SqlCommand abc = new SqlCommand(QUERYCLO, com);
                //    SqlDataReader xyz = abc.ExecuteReader();
                //    while (xyz.Read())
                //    {
                //        cmb_clo.Items.Add(xyz[1].ToString());

                //    }
                //}
                //com.Close();
                btnUpdate.Show();
                btn_add.Hide();
                int row = e.RowIndex;

                int id = Convert.ToInt32(dataGridView1.Rows[row].Cells["Id"].Value);
                ID = id;
                
                string Get_Query = "select * FROM dbo.Rubric  WHERE Id = '" + id + "'";
                SqlCommand cmd = new SqlCommand(Get_Query, Connection);
                var myReader = cmd.ExecuteReader();
                myReader.Read();
                txt_details.Text = myReader[1].ToString();
                
                

            }
            else
            {

            }
            if (e.ColumnIndex == dataGridView1.Columns["btn_DELETE"].Index)
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    int row = e.RowIndex;
                    int Id = Convert.ToInt32(dataGridView1.Rows[row].Cells["Id"].Value);
                    string Delete_Query = "DELETE FROM dbo.Rubric  WHERE Id = '" + Id + "'";
                    SqlCommand cmd = new SqlCommand(Delete_Query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been deleted!");
                }



            }
            else
            {

            }

        }

        private void cmb_clo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void RubricMenuForm_Load(object sender, EventArgs e)
        {
            btnUpdate.Hide();
            SqlConnection com = new SqlConnection(ConectionString);
            com.Open();
            if (com.State == ConnectionState.Open)
            {
                string QUERYCLO = "select * from dbo.Clo";
                SqlCommand abc = new SqlCommand(QUERYCLO, com);
                SqlDataReader xyz = abc.ExecuteReader();
                while (xyz.Read())
                {
                    cmb_clo.Items.Add(xyz[1].ToString());

                }
            }
            com.Close();

        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dbo.Student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        SqlConnection con = new SqlConnection("Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True");
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection q = new SqlConnection(ConectionString);
            q.Open();
            String GetiingCloid = "SELECT * FROM dbo.Clo WHERE Name='" + cmb_clo.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(GetiingCloid, q);
            var Reader = cmd.ExecuteReader();
            Reader.Read();
            int id = Reader.GetInt32(0);
            con.Open();
            SqlCommand t = con.CreateCommand();
            t.CommandType = CommandType.Text;
            t.CommandText = "update dbo.Rubric SET Details = '" + txt_details.Text + "', CloId = '" + id+"' WHERE Id = '" + ID + "'";
            t.ExecuteNonQuery();
            con.Close();
            
            MessageBox.Show("Rubric has been Updated");
        }
    }
}
