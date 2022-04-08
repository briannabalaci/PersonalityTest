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
    public partial class Test1 : Form
    {
        public MainPage taticu;

        public int coleric1 = 0;
        public int sangvinic1 = 0;
        public int flegmatic1 = 0;
        public int melancolic1 = 0;
        public Test1()
        {
            InitializeComponent();
        }

        private void Testul_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Font = new Font("Arial", 12, FontStyle.Bold);


        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Test2 newForm = new Test2();
            newForm.bunicu = taticu;
            newForm.Show();
           
            if (radioButton1.Checked)  coleric1++;
            if(radioButton3.Checked) sangvinic1++;
            if(radioButton5.Checked)   flegmatic1++;
            if(radioButton7.Checked)   melancolic1++;
            if(radioButton9.Checked)  coleric1++;
            if(radioButton11.Checked)   sangvinic1++;
            if (radioButton13.Checked) flegmatic1++;
            if(radioButton15.Checked)   melancolic1++;
            if(radioButton17.Checked) coleric1++;
            if(radioButton19.Checked)  sangvinic1++;
            if (radioButton21.Checked) flegmatic1++;
            
            newForm.coleric2 = coleric1;
            newForm.sangvinic2 = sangvinic1;
            newForm.flegmatic2 = flegmatic1;
            newForm.melancolic2 = melancolic1;

            this.Close();
      


        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage newForm = new MainPage();
            newForm.Show();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       private void panel1_Paint(object sender, PaintEventArgs e)
        {
           panel1.Location = new Point(
  this.ClientSize.Width / 2 - panel1.Size.Width / 2,
          this.ClientSize.Height / 1 - panel1.Size.Height / 1);
   panel1.Anchor = AnchorStyles.None;
        }

       private void label2_Click(object sender, EventArgs e)
       {

       }

       private void label1_Click(object sender, EventArgs e)
       {

       }

       private void radioButton8_CheckedChanged(object sender, EventArgs e)
       {

       }

       private void radioButton21_CheckedChanged(object sender, EventArgs e)
       {

       }
    }
}
