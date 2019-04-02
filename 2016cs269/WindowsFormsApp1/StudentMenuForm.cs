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
    public partial class StudentMenuForm : Form
    {
        public StudentMenuForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True");
        public int ID;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_registered_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dbo.Student (FirstName,LastName,Contact,Email,RegistrationNumber,Status) values('" + txt_firstname.Text.ToString() + "','" + txt_lastname.Text.ToString() + "','" + txt_contact.Text.ToString() + "','" + txt_email.Text.ToString() + "','" + txt_regno.Text.ToString() + "','" + 5 + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Student has been added");
            txt_firstname.Text = "";
            txt_lastname.Text = "";
            txt_regno.Text = "";
            txt_contact.Text = "";
            txt_email.Text = "";


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

        private void Add_Student_Load(object sender, EventArgs e)
        {

        }

        private void lbl_lastname_Click(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void lbl_contact_Click(object sender, EventArgs e)
        {

        }

        private void lbl_firstname_Click(object sender, EventArgs e)
        {

        }

        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_regno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_status_Click(object sender, EventArgs e)
        {

        }

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_view_Click_1(object sender, EventArgs e)
        {

            con.Open();
            String query = "SELECT * FROM dbo.Student";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM dbo.Student where FirstName = '"+txt_firstname.Text+"'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
          
        }
        public string ConectionString = "Data Source=DEVIL\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection Connection = new SqlConnection(ConectionString);
            Connection.Open();
            if (e.ColumnIndex == dataGridView1.Columns["btnEDIT"].Index)
            {
                int row = e.RowIndex;
                
                int id = Convert.ToInt32(dataGridView1.Rows[row].Cells["Id"].Value);
                ID = id;
                //string Edit_Query = "UPDATE FROM tbl_employees SET emp_name='" + txtname.Text + "',emp_email = '" + txtmail.Text + "',emp_department = '" + txtdept.Text + "',emp_designation = '" + txtdesg.Text + "',emp_joining_date = '" + dtpjoin.Value.ToString("MM/dd/yyyy") + "',emp_salary = '" + Convert.ToDouble(txtsalary.Text) + "'";
                string Get_Query = "select * FROM dbo.Student  WHERE Id = '" + id + "'";
                SqlCommand cmd = new SqlCommand(Get_Query, Connection);
                var myReader = cmd.ExecuteReader();
                myReader.Read();
                txt_firstname.Text = myReader[1].ToString();
                txt_lastname.Text = myReader[2].ToString();
                txt_contact.Text = myReader[3].ToString();
                txt_email.Text = myReader[4].ToString();
                txt_regno.Text = myReader[5].ToString();

            }
            else
            {

            }
            if (e.ColumnIndex == dataGridView1.Columns["btnDelete"].Index)
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    int row = e.RowIndex;
                    int Id = Convert.ToInt32(dataGridView1.Rows[row].Cells["Id"].Value);
                    string Delete_Query = "DELETE FROM dbo.Student  WHERE Id = '" + Id + "'";
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
            int T;
            if(cmb_status.Text == "Active"){
                T = 5;
            }
            else{
                T = 6;
            }
            
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update dbo.Student SET FirstName = '" + txt_firstname.Text + "', LastName = '" + txt_lastname.Text + "', Contact = '" + txt_contact.Text + "', Email = '" + txt_email.Text + "', RegistrationNumber = '" + txt_regno.Text + "', Status = '" +T + "' WHERE Id = '" + ID + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Student has been added");
        }
    }
}
