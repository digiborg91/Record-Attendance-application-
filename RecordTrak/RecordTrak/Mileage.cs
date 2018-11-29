using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordTrak
{
    public partial class Mileage : Form
    {
        public Mileage()
        {
            InitializeComponent();
        }

        private void Mileage_Load(object sender, EventArgs e)
        {

        }

        private void mileage_backbtn_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                Main ss = new Main();
                ss.Show();
            }
        }
    }
}
