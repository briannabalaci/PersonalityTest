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

    public partial class Test2 : Form
    {
        public MainPage bunicu;

        public int coleric2;
        public int sangvinic2;
        public int flegmatic2;
        public int melancolic2;
        public Test2()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
             this.Hide();
            Test3 newForm = new Test3();
            newForm.strabunicu = bunicu;
            newForm.Show();
            if (radioButton23.Checked) melancolic2++;
            if(radioButton25.Checked) coleric2++;
            if (radioButton27.Checked) sangvinic2++;
            if (radioButton29.Checked) flegmatic2++;
            if (radioButton31.Checked) melancolic2++;
            if (radioButton33.Checked) coleric2++;
            if (radioButton35.Checked) sangvinic2++;
            if(radioButton37.Checked)   flegmatic2++;
            if (radioButton39.Checked) melancolic2++;
            if (radioButton41.Checked) coleric2++;
            if (radioButton43.Checked) sangvinic2++;
            if (radioButton45.Checked) flegmatic2++;
            if (radioButton47.Checked) melancolic2++;
           

            newForm.coleric3 = coleric2;
            newForm.sangvinic3 = sangvinic2;
            newForm.flegmatic3 = flegmatic2;
            newForm.melancolic3 = melancolic2;

            this.Close();


        }

        private void Testul22_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Font = new Font("Arial", 12, FontStyle.Bold);
      
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Test1 newForm = new Test1();
            newForm.Show();
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
