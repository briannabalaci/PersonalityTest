using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 int coleric1=0;
  int sangvinic1=0;
            int flegmatic1=0;
            int melancolic1=0;
namespace TestPersonalitate_Balaci_Mura_
{ 
    public partial class Testul : Form
    {
        public Testul()
        {
            InitializeComponent();
        }

        private void Testul_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Font = new Font("Arial", 12, FontStyle.Bold);
      
          


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void True(object sender, KeyEventArgs e)
        {
            
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Testul22 newForm = new Testul22();
            newForm.Show();
           
            if (radioButton1.Checked)  coleric1=coleric1++;
            if(radioButton3.Checked) sangvinic1=sangvinic1++;
            if(radioButton5.Checked)   flegmatic1=flegmatic1++;
            if(radioButton8.Checked)    melancolic1=melancolic1++;
            if(radioButton10.Checked)  coleric1=coleric1++;
            if(radioButton12.Checked)   sangvinic1=sangvinic1++;
            if(radioButton14.Checked)  sangvinic1=sangvinic1++;
            if(radioButton16.Checked)    melancolic1=melancolic1++;
            if(radioButton18.Checked)  coleric1=coleric1++;
            if(radioButtoon20.Checked)  sangvinic1=sangvinic1++;


        }
    }
}
