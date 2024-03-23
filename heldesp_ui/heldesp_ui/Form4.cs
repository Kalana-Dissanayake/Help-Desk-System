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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public string constring = ("Data Source=ACHI-LAPTOP;Initial Catalog=manzaneque;Integrated Security=True");

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q6 = "UPDATE problem SET solution = '" + txt_slo.Text + "', _time = '" + txt_time.Text + "' Where problem_number = '" + Convert.ToInt32(txt_pnoms.Text) + "' ";
            SqlCommand cmd = new SqlCommand(q6, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated Successfully", "Help Desk");
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q5 = "(select problem_number , reason from _call)";
            SqlCommand cmd = new SqlCommand(q5, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_4.DataSource = dt;
            con.Close();
        }

        private void btn_ext_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}
