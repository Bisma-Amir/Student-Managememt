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
    public partial class Rubric_Level : Form
    {
        public Rubric_Level()
        {
            InitializeComponent();
        }

        private void htmlLabel2_Click(object sender, EventArgs e)
        {

        }
        public string ConectionString = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";

        private void Rubric_Level_Load(object sender, EventArgs e)
        {
            btn_Update.Hide();
            SqlConnection com = new SqlConnection(ConectionString);
            com.Open();
            if (com.State == ConnectionState.Open)
            {
                string QUERYCLO = "select * from dbo.Rubric";
                SqlCommand abc = new SqlCommand(QUERYCLO, com);
                SqlDataReader xyz = abc.ExecuteReader();
                while (xyz.Read())
                {
                    cmb_rubricid.Items.Add(xyz[0].ToString());

                }
            }
            com.Close();

        }
       
        SqlConnection con = new SqlConnection("Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True");
        
        private void btn_add_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dbo.RubricLevel (RubricId,Details,MeasurementLevel) values('" + int.Parse(cmb_rubricid.SelectedItem.ToString()) + "','" + txt_details.Text + "','" + int.Parse(txt_measurementlevel.Text.ToString()) + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            
            MessageBox.Show("Rubric Level has been added");
            

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            SqlConnection q = new SqlConnection(ConectionString);
            q.Open();
            String query = "SELECT * FROM RubricLevel";
            SqlDataAdapter SDA = new SqlDataAdapter(query, q);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public int ID;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection Connection = new SqlConnection(ConectionString);
            Connection.Open();
            if (e.ColumnIndex == dataGridView1.Columns["btn_Edit"].Index)
            {

                btn_Update.Show();
                btn_add.Hide();
                int row = e.RowIndex;

                int id = Convert.ToInt32(dataGridView1.Rows[row].Cells["Id"].Value);
                ID = id;

                string Get_Query = "select * FROM dbo.RubricLevel  WHERE Id = '" + id + "'";
                SqlCommand cmd = new SqlCommand(Get_Query, Connection);
                var myReader = cmd.ExecuteReader();
                myReader.Read();
                txt_details.Text = myReader[2].ToString();
                txt_measurementlevel.Text = myReader.GetInt32(3).ToString();


            }
            else
            {

            }
            if (e.ColumnIndex == dataGridView1.Columns["btn_Delete"].Index)
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    int row = e.RowIndex;
                    int Id = Convert.ToInt32(dataGridView1.Rows[row].Cells["Id"].Value);
                    string Delete_Query = "DELETE FROM dbo.RubricLevel  WHERE Id = '" + Id + "'";
                    SqlCommand cmd = new SqlCommand(Delete_Query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been deleted!");
                }



            }
            else
            {

            }

        }

        private void txt_details_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update dbo.RubricLevel SET RubricId = '" + int.Parse(cmb_rubricid.SelectedItem.ToString()) + "', Details = '" + txt_details.Text + "', MeasurementLevel = '" + int.Parse(txt_measurementlevel.Text.ToString()) + "' WHERE Id = '" + ID + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            
            MessageBox.Show("Rubric Level has been Updated");
        }
    }
}
