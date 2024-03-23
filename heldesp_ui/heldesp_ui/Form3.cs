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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            combo_type.Items.Add("Software");
            combo_type.Items.Add("Hardware");
            combo_type.Items.Add("Electricity");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public string constring = ("Data Source=ACHI-LAPTOP;Initial Catalog=manzaneque;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q5 = "(select problem_number, equipment_ID, problem_type, problem_description, solution from problem)";
            SqlCommand cmd = new SqlCommand(q5, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_3.DataSource = dt;
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btn_spec_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Show();
        }

        private void lbl_ope_Click(object sender, EventArgs e)
        {

        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q4 = "insert into problem (problem_type, equipment_ID, specialist_ID, problem_description, Operator_ID, solution, _date, _time) values ('"+ combo_type.SelectedItem +"', '" + Convert.ToInt32(txt_eid.Text) + "', '"+Convert.ToInt32(txt_sid.Text)+"', '"+txt_dsc.Text+"', '"+Convert.ToInt32(txt_oid.Text)+"', '"+txt_sol.Text+"', '"+txt_date.Text+"', '"+txt_time.Text+"')";
            SqlCommand cmd = new SqlCommand(q4, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Added Successfully","HelpDesk");
            con.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_call_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q5 = "delete from problem where problem_number = '" + Convert.ToInt32(txt_pno.Text) + "'";
            SqlCommand cmd = new SqlCommand(q5, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully", "Help Desk");
            con.Close();

        }
    }
}
