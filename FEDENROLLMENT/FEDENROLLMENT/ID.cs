using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEDENROLLMENT
{
    public partial class ID : Form
    {
        public ID()
        {
            InitializeComponent();
        }

        private void ID_Load(object sender, EventArgs e)
        {
            label9.Text = clsMySQL.firstname +" "+ clsMySQL.middlename+ " "+clsMySQL.lastname;
   

            label8.Text = clsMySQL.schoolyear;
            pictureBox1.ImageLocation = clsMySQL.pic;
            label11.Text = clsMySQL.lrn;
            label12.Text = "Grade "+ clsMySQL.gradelevel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
