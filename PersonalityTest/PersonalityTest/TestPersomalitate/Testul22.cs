using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

int coleric2=0;
  int sangvinic2=0;
            int flegmatic2=0;
            int melancolic2=0;
namespace TestPersonalitate_Balaci_Mura_
{
    public partial class Testul22 : Form
    {
        public Testul22()
        {
            InitializeComponent();
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             this.Hide();
            Testul3 newForm = new Testul3();
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

        private void Testul22_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Font = new Font("Arial", 12, FontStyle.Bold);
      
        }
    }
}
