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
    public partial class student_attendance : Form
    {
        public student_attendance()
        {
            InitializeComponent();
        }
        public string ConectionString = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void student_attendance_Load(object sender, EventArgs e)
        {
            SqlConnection com = new SqlConnection(ConectionString);
            com.Open();
            if (com.State == ConnectionState.Open)
            {
                string QUERYCLO = "select * from dbo.ClassAttendance";
                SqlCommand abc = new SqlCommand(QUERYCLO, com);
                SqlDataReader xyz = abc.ExecuteReader();
                while (xyz.Read())
                {
                    cmb_class_attendance_ids.Items.Add(xyz[0].ToString());

                }
            }
            com.Close();
            SqlConnection t = new SqlConnection(ConectionString);
            t.Open();
            if (t.State == ConnectionState.Open)
            {
                string QUERYCLO = "select * from dbo.Student";
                SqlCommand abc = new SqlCommand(QUERYCLO, t);
                SqlDataReader xyz = abc.ExecuteReader();
                while (xyz.Read())
                {
                    cmb_student_ids.Items.Add(xyz[0].ToString());

                }
            }
            t.Close();
        }
        SqlConnection con = new SqlConnection("Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True");

        public int AttendanceStatus;
        private void btn_mark_Click(object sender, EventArgs e)
        {
            if(cmb_status.Text== "Present")
            {
                AttendanceStatus = 1;
            }
            if (cmb_status.Text == "Absent")
            {
                AttendanceStatus = 2;
            }
            if (cmb_status.Text == "Leave")
            {
                AttendanceStatus = 3;
            }
            else
            {
                AttendanceStatus = 4;
            }
            
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into dbo.StudentAttendance (AttendanceId,StudentId,AttendanceStatus) values('" +int.Parse(cmb_class_attendance_ids.SelectedItem.ToString()) + "','"+ int.Parse(cmb_student_ids.SelectedItem.ToString()) + "','"+AttendanceStatus+"')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Attendance has been added");

            }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard w = new Dashboard();
            this.Hide();
            w.Show();
        }
    }
}
