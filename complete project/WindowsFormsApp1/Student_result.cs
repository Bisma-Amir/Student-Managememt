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
    public partial class Student_result : Form
    {
        public Student_result()
        {
            InitializeComponent();
        }
        public string ConectionString = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void Student_result_Load(object sender, EventArgs e)
        {
            SqlConnection com = new SqlConnection(ConectionString);
            com.Open();
            if (com.State == ConnectionState.Open)
            {
                string QUERYCLO = "select * from dbo.Student";
                SqlCommand abc = new SqlCommand(QUERYCLO, com);
                SqlDataReader xyz = abc.ExecuteReader();
                while (xyz.Read())
                {
                    cmb_student_ids.Items.Add(xyz[0].ToString());

                }
            }
            com.Close();
            SqlConnection t = new SqlConnection(ConectionString);
            t.Open();
            if (t.State == ConnectionState.Open)
            {
                string QUERYCLO = "select * from dbo.AssessmentComponent";
                SqlCommand abc = new SqlCommand(QUERYCLO, t);
                SqlDataReader xyz = abc.ExecuteReader();
                while (xyz.Read())
                {
                    cmb_assessment_component_ids.Items.Add(xyz[0].ToString());

                }
            }
            t.Close();
            SqlConnection r = new SqlConnection(ConectionString);
            r.Open();
            if (r.State == ConnectionState.Open)
            {
                string QUERYCLO = "select * from dbo.RubricLevel";
                SqlCommand abc = new SqlCommand(QUERYCLO, r);
                SqlDataReader xyz = abc.ExecuteReader();
                while (xyz.Read())
                {
                    cmb_rubric_measurement_ids.Items.Add(xyz[0].ToString());

                }
            }
            r.Close();
        }
        SqlConnection con = new SqlConnection("Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True");
        private void btn_Add_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dbo.StudentResult (StudentId,AssessmentComponentId,RubricMeasurementId,EvaluationDate) values('" + int.Parse(cmb_student_ids.SelectedItem.ToString()) + "','" + int.Parse(cmb_assessment_component_ids.SelectedItem.ToString()) + "','" + int.Parse(cmb_rubric_measurement_ids.SelectedItem.ToString()) + "','"+dtp_EvaluationDate.Value+"')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Result has been added");
        }

        private void btn_show_result_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConectionString))
            {
                string Query1 = "SELECT AssessmentComponent.Name,Rubric.Details,AssessmentComponent.TotalMarks,RubricLevel.MeasurementLevel,CAST(RubricLevel.MeasurementLevel AS float)/ '" + 4 + "' * AssessmentComponent.TotalMarks as Obatined_Marks FROM [AssessmentComponent]  ";
                string Query2 = "JOIN Rubric ON [AssessmentComponent].RubricId = Rubric.Id ";
                string Query3 = "JOIN RubricLevel ON Rubric.Id = RubricLevel.RubricId";
                string MainQuery = Query1 + Query2 + Query3;
                using (SqlCommand cmd = new SqlCommand(MainQuery, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            datagridview_result.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.datagridview_result.Width, this.datagridview_result.Height);
            datagridview_result.DrawToBitmap(bm, new Rectangle(0, 0, this.datagridview_result.Width, this.datagridview_result.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
