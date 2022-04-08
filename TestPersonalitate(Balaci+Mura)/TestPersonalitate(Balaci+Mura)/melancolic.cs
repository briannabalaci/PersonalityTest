using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPersonalitate_Balaci_Mura_
{
    public partial class melancolic : Form
    {
        public melancolic()
        {
            InitializeComponent();
        }

        private void melancolic_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Font = new Font("Arial", 18, FontStyle.Bold);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DespreTemperament newform = new DespreTemperament();
            newform.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
