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
    public partial class Holidays : Form
    {
        public Holidays()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-86TC1QA\\SQLEXPRESS;Initial Catalog=AttendanceApp;Integrated Security=True";

        private void holiday_Submit_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)

            {
                string query = "INSERT INTO Holiday_Table(Holiday_Start)values('" + dateTimePicker1 + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                MessageBox.Show("Holidays Submitted Sucessfully");
                con.Close();
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                Main ss = new Main();
                ss.Show();
            }
        }
    }
}
