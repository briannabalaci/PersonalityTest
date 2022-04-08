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
    public partial class DespreTemperament : Form
    {
        public DespreTemperament()
        {
            InitializeComponent();
        }


        private void DespreTemperament_Load(object sender, EventArgs e)
        {
          
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Font = new Font("Arial", 18, FontStyle.Bold);
            linkLabel1.BackColor = System.Drawing.Color.LightBlue;
            linkLabel2.BackColor = System.Drawing.Color.LightBlue;
            linkLabel3.BackColor = System.Drawing.Color.LightBlue;
            linkLabel4.BackColor = System.Drawing.Color.LightBlue;
            button1.BackColor = System.Drawing.Color.White;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            coleric newform = new coleric();
            newform.taticu = this;
            newform.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            sangvinic newform = new sangvinic();
            newform.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            flegmatic newform = new flegmatic();
            newform.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            melancolic newform = new melancolic();
            newform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
