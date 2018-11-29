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

namespace RecordTrak
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timetickerlbl.Text = DateTime.Now.ToLongTimeString();

            Datelbl.Text = DateTime.Now.ToLongDateString();
        }
        
        private void Holidaybtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Holidays ss = new Holidays();
            ss.Show();
        }

        private void Alertsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alerts ss = new Alerts();
            ss.Show();
        }

        public string conString = "Data Source=DESKTOP-86TC1QA\\SQLEXPRESS;Initial Catalog=AttendanceApp;Integrated Security=True";

        private void SignInbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            
            {
                string query = "insert into Sign_In_Out_Table(Sign_In)Values('"+ timetickerlbl.ToString()+ "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SignIn", DateTime.Parse (timetickerlbl.Text));
                //cmd.ExecuteNonQuery();
                MessageBox.Show("Signed in sucessfully" +timetickerlbl);
                con.Close();
            }
        }

        private void timetickerlbl_Click(object sender, EventArgs e)
        {
            timetickerlbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Datelbl_Click(object sender, EventArgs e)
        {
           Datelbl.Text = DateTime.Now.ToLongDateString();
        }

        private void mileagebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mileage ss = new Mileage();
            ss.Show();
        }
    }
}
