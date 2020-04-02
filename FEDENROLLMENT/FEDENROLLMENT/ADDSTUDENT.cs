using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FEDENROLLMENT
{
    public partial class ADDSTUDENT : Form
    {
        public string sID;
        public string sql = "";
        public string pic;
        public MySqlCommand sql_cmd = new MySqlCommand();
        public ADDSTUDENT()
        {
            InitializeComponent();
        }

        private void ADDSTUDENT_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            clsMySQL.sql_con.Close();
            clsMySQL.sql_con.Open();
            disable();

            
        }

        private void label34_Click(object sender, EventArgs e)
        {
            MAINFORM m = new MAINFORM();
            this.Hide();
            m.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MAINFORM m = new MAINFORM();
            this.Hide();
            m.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void addStudent()
        {
            
            sql = string.Format("INSERT INTO tbstudent VALUES (null, '{0}', '{1}', '{2}','{3}', '{4}', '{5}', '{6}', '{7}', '{8}','{9}', '{10}','{11}', '{12}', '{13}', '{14}', '{15}', '{16}','{17}', '{18}','{19}', '{20}', '{21}', '{22}', '{23}', '{24}','{25}', '{26}','{27}', '{28}', '{29}','{30}')",
      tx1.Text, tx2.Text, tx3.Text, tx4.Text, tx5.Text, tx6.Text, tx7.Text, tx8.Text, tx9.Text, tx10.Text, tx11.Text, tx12.Text, tx13.Text, tx14.Text, tx15.Text, tx16.Text, tx17.Text, tx18.Text, tx19.Text, tx20.Text, tx21.Text, tx22.Text, tx23.Text, tx24.Text, tx25.Text, tx26.Text, tx27.Text, tx28.Text, tx29.Text, tx30.Text, pic);
            sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
            sql_cmd.ExecuteNonQuery();
            MessageBox.Show("New Student has been added successfully!", "Add Subject");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Add Now")
            {
                enable();
                button1.Text = "Add Student";
            }
            else if (button1.Text == "Add Student")
            {
                addStudent();
                disable();
                clearAll();
               
                button1.Text = "Add Now";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox5.Image = new Bitmap(open.FileName);
                pic = open.FileName.Replace(@"\", @"\\");
            }
        }
        private void disable()
        {
            button1.Text = "Add Now";
            button2.Enabled = false;
            tx1.Enabled = false; tx2.Enabled = false; tx3.Enabled = false; tx4.Enabled = false; tx5.Enabled = false; tx6.Enabled = false; tx7.Enabled = false; tx8.Enabled = false; tx9.Enabled = false; tx10.Enabled = false; tx11.Enabled = false; tx12.Enabled = false; tx13.Enabled = false; tx14.Enabled = false; tx15.Enabled = false; tx16.Enabled = false; tx17.Enabled = false; tx18.Enabled = false; tx19.Enabled = false; tx20.Enabled = false; tx21.Enabled = false; tx22.Enabled = false; tx23.Enabled = false; tx24.Enabled = false; tx25.Enabled = false; tx26.Enabled = false; tx27.Enabled = false; tx28.Enabled = false; tx29.Enabled = false; tx30.Enabled = false; button3.Enabled = false;
        }
        private void clearAll()
        {
            button1.Text = "Add Now";
            tx1.Text = ""; tx2.Text = ""; tx3.Text = ""; tx4.Text = ""; tx5.Text = ""; tx6.Text = ""; tx7.Text = ""; tx8.Text = ""; tx9.Text = ""; tx10.Text = ""; tx11.Text = ""; tx12.Text = ""; tx13.Text = ""; tx14.Text = ""; tx15.Text = ""; tx16.Text = ""; tx17.Text = ""; tx18.Text = ""; tx19.Text = ""; tx20.Text = ""; tx21.Text = ""; tx22.Text = ""; tx23.Text = ""; tx24.Text = ""; tx25.Text = ""; tx26.Text = ""; tx27.Text = ""; tx28.Text = ""; tx29.Text = ""; tx30.Text = ""; pictureBox5.ImageLocation = null;
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearAll();
            disable();
            button2.Enabled = false;
        }
        private void enable()
        {
            button2.Enabled = true;
            tx1.Enabled = true; tx2.Enabled = true; tx3.Enabled = true; tx4.Enabled = true; tx5.Enabled = true; tx6.Enabled = true; tx7.Enabled = true; tx8.Enabled = true; tx9.Enabled = true; tx10.Enabled = true; tx11.Enabled = true; tx12.Enabled = true; tx13.Enabled = true; tx14.Enabled = true; tx15.Enabled = true; tx16.Enabled = true; tx17.Enabled = true; tx18.Enabled = true; tx19.Enabled = true; tx20.Enabled = true; tx21.Enabled = true; tx22.Enabled = true; tx23.Enabled = true; tx24.Enabled = true; tx25.Enabled = true; tx26.Enabled = true; tx27.Enabled = true; tx28.Enabled = true; tx29.Enabled = true; tx30.Enabled = true; button3.Enabled = true;
        }

    }
}
