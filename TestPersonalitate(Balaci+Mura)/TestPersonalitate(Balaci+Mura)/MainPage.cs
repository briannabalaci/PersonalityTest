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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Font = new Font("Arial", 18, FontStyle.Bold);
            button1.BackColor = System.Drawing.Color.White;
            button2.BackColor = System.Drawing.Color.White;
            button3.BackColor = System.Drawing.Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test1 newForm = new Test1();
            newForm.taticu = this;
            newForm.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            DespreTemperament newForm = new DespreTemperament();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
