using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeManagementSystem
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllReport a1 = new AllReport();
            a1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmpAttendence e1 = new EmpAttendence();
            e1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EmpSalary es1 = new EmpSalary();
            es1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmpLeave el1 = new EmpLeave();
            el1.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpExperience ob = new EmpExperience();
            ob.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmpShift ob = new EmpShift();
            ob.Show();
            this.Hide();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SignUpAdmin c1 = new SignUpAdmin();
            c1.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            EmailSend e1 = new EmailSend();
            e1.Show();
            this.Hide();
        }
    }
}
