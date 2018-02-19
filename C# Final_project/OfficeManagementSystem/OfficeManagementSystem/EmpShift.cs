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
    public partial class EmpShift : Form
    {
        public EmpShift()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHome ob = new AdminHome();
            ob.Show();
            this.Hide();
        }

        private void EmpShift_Load(object sender, EventArgs e)
        {

        }
    }
}
