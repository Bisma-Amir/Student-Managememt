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

    public partial class Assessment_Component : Form
    {
        
        public Assessment_Component()
        {
            
            InitializeComponent();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            this.Hide();
            dash.Show();
        }

        private void Assessment_Component_Load(object sender, EventArgs e)
        {
            SqlConnection com = new SqlConnection(ConectionString);
            com.Open();
            if (com.State == ConnectionState.Open)
            {
                string QUERYCLO = "select * from dbo.Rubric";
                SqlCommand abc = new SqlCommand(QUERYCLO, com);
                SqlDataReader xyz = abc.ExecuteReader();
                while (xyz.Read())
                {
                    cmbrubricid.Items.Add(xyz[0].ToString());

                }
            }
            com.Close();
            SqlConnection t = new SqlConnection(ConectionString);
            t.Open();
            if (t.State == ConnectionState.Open)
            {
                string QUERYCLO = "select * from dbo.Assessment";
                SqlCommand abc = new SqlCommand(QUERYCLO, t);
                SqlDataReader xyz = abc.ExecuteReader();
                while (xyz.Read())
                {
                    cmbAsssessment_Id.Items.Add(xyz[0].ToString());

                }
            }
            t.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Assessment r = new Assessment();
            this.Hide();
            r.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Show();
        }
        SqlConnection con = new SqlConnection("Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True");
        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dbo.AssessmentComponent (Name,RubricId,TotalMarks,DateCreated,DateUpdated,AssessmentId) values('" + txt_name.Text + "','" + int.Parse(cmbrubricid.SelectedItem.ToString()) + "','" + Convert.ToInt32(txt_total_marks.Text) + "','" + dtp_date_created.Value + "','" + dtp_date_updated.Value + "','"+ int.Parse(cmbAsssessment_Id.SelectedItem.ToString()) + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Assessment Component has been added");
        }
        public string ConectionString = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";

        private void btn_view_assessment_component_Click(object sender, EventArgs e)
        {
            SqlConnection q = new SqlConnection(ConectionString);
            q.Open();
            String query = "SELECT * FROM AssessmentComponent";
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

                
                int row = e.RowIndex;

                int id = Convert.ToInt32(dataGridView1.Rows[row].Cells["Id"].Value);
                ID = id;

                string Get_Query = "select * FROM dbo.AssessmentComponent  WHERE Id = '" + id + "'";
                SqlCommand cmd = new SqlCommand(Get_Query, Connection);
                var myReader = cmd.ExecuteReader();
                myReader.Read();
                txt_name.Text = myReader[1].ToString();
                txt_total_marks.Text = myReader.GetInt32(3).ToString();
                


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
                    string Delete_Query = "DELETE FROM dbo.AssessmentComponent  WHERE Id = '" + Id + "'";
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
            cmd.CommandText = "update dbo.AssessmentComponent SET Name = '" + txt_name.Text + "',RubricId='" + int.Parse(cmbrubricid.SelectedItem.ToString()) + "', TotalMarks = '" +txt_total_marks.Text + "', DateCreated = '" + dtp_date_created.Value + "',DateUpdated = '" + dtp_date_updated.Value + "', AssessmentId = '" + int.Parse(cmbAsssessment_Id.SelectedItem.ToString()) + "' WHERE Id = '" + ID + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Assessment Component has been Updated");
        }
    }
}
