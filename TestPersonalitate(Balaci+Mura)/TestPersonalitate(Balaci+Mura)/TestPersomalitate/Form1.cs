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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Font = new Font("Arial", 18, FontStyle.Bold);
            button1.BackColor = System.Drawing.Color.LightGray;
            button2.BackColor = System.Drawing.Color.LightGray;
            button3.BackColor = System.Drawing.Color.LightGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Testul newForm = new Testul();
            newForm.Show();
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
    }
}
