using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_addstudent_Click(object sender, EventArgs e)
        {
            StudentMenuForm add = new StudentMenuForm();
            this.Hide();
            add.Show();
        }

        private void btn_enrolledstidents_Click(object sender, EventArgs e)
        {
           
        }

        private void bn_clo_Click(object sender, EventArgs e)
        {
            CLOMenuForm clo = new CLOMenuForm();
            this.Hide();
            clo.Show();

        }

        private void btn_listclo_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_addassessment_Click(object sender, EventArgs e)
        {
            RubricMenuForm rub = new RubricMenuForm();
            this.Hide();
            rub.Show();
        }

        private void btn_addedassess_Click(object sender, EventArgs e)
        {
            Added_Assessment view = new Added_Assessment();
            this.Hide();
            view.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rubric_Level r = new Rubric_Level();
            this.Hide();
            r.Show();
        }

        private void btn_assessment_menu_Click(object sender, EventArgs e)
        {
            Assessment bt = new Assessment();
            this.Hide();
            bt.Show();
        }

        private void btn_assessment_component_Click(object sender, EventArgs e)
        {
            Assessment_Component t = new Assessment_Component();
            this.Hide();
            t.Show();
        }

        private void btn_attendance_menu_Click(object sender, EventArgs e)
        {
            Class_Attendance t = new Class_Attendance();
            this.Hide();
            t.Show();
        }
    }
}
