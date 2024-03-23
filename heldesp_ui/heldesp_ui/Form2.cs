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

namespace heldesp_ui
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_nxt_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        public string constring = ("Data Source=ACHI-LAPTOP;Initial Catalog=manzaneque;Integrated Security=True");
        private void btn_chk_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_eq_id.Text);

            if (id != 0)
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string q2 = "(select * from equipment where equipment_ID = '" + id + "')";
                SqlCommand cmd = new SqlCommand(q2, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_2.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid Equipment ID", "Error");
            }
        }

        private void btn_chk_cn_Click(object sender, EventArgs e)
        {
            string name = txt_cn.Text;

            if (name != "")
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string q3 = "(select caller_ID, caller_name, jobtitle, department from _caller where caller_name = '" + name + "')";
                SqlCommand cmd = new SqlCommand(q3, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_2.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Name", "Error");
            }
        }
    }
}
