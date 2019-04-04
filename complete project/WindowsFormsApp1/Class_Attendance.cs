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
    public partial class Class_Attendance : Form
    {
        public Class_Attendance()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True");
        private void btnmark_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dbo.ClassAttendance (AttendanceDate) values('" + dtp_attendance_date.Value + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Date has been added");
        }

        private void Class_Attendance_Load(object sender, EventArgs e)
        {

        }

        private void btn_student_attendance_Click(object sender, EventArgs e)
        {
            student_attendance u = new student_attendance();
            this.Hide();
            u.Show();

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Show();
        }
    }
}
