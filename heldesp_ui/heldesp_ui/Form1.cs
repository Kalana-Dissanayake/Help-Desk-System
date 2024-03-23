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
    public partial class Form1 : Form
    {
private  string SqlCon;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string constring = ("Data Source=ACHI-LAPTOP;Initial Catalog=manzaneque;Integrated Security=True");
        private void btn_next_Click(object sender, EventArgs e)
        {
    
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();

        }

        private void btn_chk_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q1 = "select*from computer";
            SqlCommand cmd = new SqlCommand(q1, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_1.DataSource = dt;
            con.Close();
        }

        private void btn_log_add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (txt_sn.Text.Length < 5)
            {
                MessageBox.Show("Please enter a valid seiral number", "Help Desk");
            }
            else
            {
                string q = "insert into computer values ('" + Convert.ToInt32(txt_sn.Text) + "', '" + txt_os.Text + "', '" + txt_sft + "', '" + txt_clname.Text + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Added Successfully");
                con.Close();
            }
        }
    }
}
