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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public string constring = "Data Source=ACHI-LAPTOP;Initial Catalog=manzaneque;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q7 = "insert into _call ( caller_ID, operator_ID, problem_number, _time, reason) values ( '" + Convert.ToInt32(txt_callerid.Text) + "', '" + Convert.ToInt32(txt_oid.Text) + "', '" + Convert.ToInt32(txt_pno.Text)+ "', '" +txt_time.Text + "', '" + txt_pro.Text+ "' )";
            SqlCommand cmd = new SqlCommand(q7, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Added Successfully", "HelpDesk");
            con.Close();
        }

        private void btn_spec_Click(object sender, EventArgs e)
        {
            Form4 frm4= new Form4();
            frm4.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}
