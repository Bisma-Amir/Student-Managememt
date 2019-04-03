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
    public partial class Assessment : Form
    {
        public Assessment()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True");
        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dbo.Assessment (Title,DateCreated,TotalMarks,TotalWeightage) values('" + txt_title.Text + "','" + dtp_date_created.Value + "','" + Convert.ToInt32( txt_total_marks.Text) + "','" + Convert.ToInt32(txt_total_weightage.Text) + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Assessment has been added");
        }
        public string ConectionString = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void btn_View_Assessments_Click(object sender, EventArgs e)
        {
            SqlConnection q = new SqlConnection(ConectionString);
            q.Open();
            String query = "SELECT * FROM Assessment";
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

                string Get_Query = "select * FROM dbo.Assessment  WHERE Id = '" + id + "'";
                SqlCommand cmd = new SqlCommand(Get_Query, Connection);
                var myReader = cmd.ExecuteReader();
                myReader.Read();
                txt_title.Text = myReader[1].ToString();
                txt_total_marks.Text = myReader.GetInt32(3).ToString();
                txt_total_weightage.Text = myReader.GetInt32(4).ToString();


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
                    string Delete_Query = "DELETE FROM dbo.Assessment  WHERE Id = '" + Id + "'";
                    SqlCommand cmd = new SqlCommand(Delete_Query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been deleted!");
                }

            }
            else
            {

            }
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update dbo.Assessment SET Title = '" + txt_title.Text + "',DateCreated='"+dtp_date_created.Value+"', TotalMarks = '" + int.Parse(txt_total_marks.Text.ToString()) + "', TotalWeightage = '" + int.Parse(txt_total_weightage.Text.ToString()) + "' WHERE Id = '" + ID + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Assessment has been Updated");
        }

        private void btn_dash_board_Click(object sender, EventArgs e)
        {
            Dashboard b = new Dashboard();
            this.Hide();
            b.Show();
        }

        private void btn_view_assessment_component_Click(object sender, EventArgs e)
        {
           
        }
    }
}
