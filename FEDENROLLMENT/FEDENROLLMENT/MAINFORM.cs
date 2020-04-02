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
    public partial class MAINFORM : Form
    {
        public string sID;
        public string sql = "";
        public string pic = "";
        public MySqlCommand sql_cmd = new MySqlCommand();
        public MAINFORM()
        {
            InitializeComponent();
        }

        private void MAINFORM_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            clsMySQL.sql_con.Close();
            clsMySQL.sql_con.Open();

            loadCount1();
            loadCount2();
            loadCount3();
            loadCount4();
            loadCount5();
            loadCount6();
            loadTotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADDSTUDENT a = new ADDSTUDENT();
            this.Hide();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MANAGE j = new MANAGE();
            this.Hide();
            j.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VIEW v = new VIEW();
            this.Hide();
            v.ShowDialog();
        }

        private void loadCount1()
        {
            sql = "SELECT count(id)as total FROM tbstudent where schoolyear = '"+comboBox1.Text+"' AND semester ='"+ comboBox2.Text+"' AND gradelevel = 'I'";
            sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
            MySqlDataReader rd = sql_cmd.ExecuteReader();
            while (rd.Read())
            {
                label19.Text = rd["total"].ToString();

  

            }
            rd.Close();
         
        }
            private void loadCount2()
        {
            sql = "SELECT count(id)as total FROM tbstudent where schoolyear = '" + comboBox1.Text + "' AND semester ='" + comboBox2.Text + "' AND gradelevel = 'II'";
            sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
            MySqlDataReader rd = sql_cmd.ExecuteReader();
            while (rd.Read())
            {
                label14.Text = rd["total"].ToString();



            }
            rd.Close();
            }
        private void loadCount3()
            {
                sql = "SELECT count(id)as total FROM tbstudent where schoolyear = '" + comboBox1.Text + "' AND semester ='" + comboBox2.Text + "' AND gradelevel = 'III'";
                sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
                MySqlDataReader rd = sql_cmd.ExecuteReader();
                while (rd.Read())
                {
                    label18.Text = rd["total"].ToString();



                }
                rd.Close();
            }
        private void loadCount4()
        {
            sql = "SELECT count(id)as total FROM tbstudent where schoolyear = '" + comboBox1.Text + "' AND semester ='" + comboBox2.Text + "' AND gradelevel = 'IV'";
            sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
            MySqlDataReader rd = sql_cmd.ExecuteReader();
            while (rd.Read())
            {
                label17.Text = rd["total"].ToString();



            }
            rd.Close();
        }
        private void loadCount5()
        {
            sql = "SELECT count(id)as total FROM tbstudent where schoolyear = '" + comboBox1.Text + "' AND semester ='" + comboBox2.Text + "' AND gradelevel = 'V'";
            sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
            MySqlDataReader rd = sql_cmd.ExecuteReader();
            while (rd.Read())
            {
                label16.Text = rd["total"].ToString();



            }
            rd.Close();
        }
        private void loadCount6()
        {
            sql = "SELECT count(id)as total FROM tbstudent where schoolyear = '" + comboBox1.Text + "' AND semester ='" + comboBox2.Text + "' AND gradelevel = 'VI'";
            sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
            MySqlDataReader rd = sql_cmd.ExecuteReader();
            while (rd.Read())
            {
                label15.Text = rd["total"].ToString();



            }
            rd.Close();
        }
        private void loadTotal()
        {
            sql = "SELECT count(id)as total FROM tbstudent where schoolyear = '" + comboBox1.Text + "' AND semester ='" + comboBox2.Text + "'";
            sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
            MySqlDataReader rd = sql_cmd.ExecuteReader();
            while (rd.Read())
            {
                label23.Text = rd["total"].ToString();



            }
            rd.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTotal(); 
            loadCount1();
            loadCount2();
            loadCount3();
            loadCount4();
            loadCount5();
            loadCount6();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTotal();
            loadCount1();
            loadCount2();
            loadCount3();
            loadCount4();
            loadCount5();
            loadCount6();
        }
        
    }
}
