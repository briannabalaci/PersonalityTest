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
    public partial class Test3 : Form
    {
        public MainPage strabunicu;

       public int coleric3;
       public int sangvinic3;
       public int flegmatic3;
       public int melancolic3;
       public int colerictotal = 0;
       public int sangvinictotal = 0;
       public int flegmatictotal = 0;
       public int melancolictotal = 0;
        public Test3()
        {
            InitializeComponent();
        }

        private void Testul3_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Font = new Font("Arial", 12, FontStyle.Bold);
      
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton49.Checked)  coleric3++;
            if (radioButton51.Checked) sangvinic3++;
            if (radioButton53.Checked) flegmatic3++;
            if (radioButton55.Checked) melancolic3++;
            if (radioButton57.Checked)  coleric3++;
            if (radioButton59.Checked)  sangvinic3++;
            if (radioButton61.Checked) flegmatic3++;
            if (radioButton63.Checked) melancolic3++;
            if (radioButton65.Checked) coleric3++;
            if (radioButton67.Checked) sangvinic3++;
            if (radioButton69.Checked) flegmatic3++;
            if (radioButton71.Checked) melancolic3++;
            colerictotal =  coleric3;
            sangvinictotal = sangvinic3;
            flegmatictotal = flegmatic3;
            melancolictotal =  melancolic3;
            colerictotal += coleric3;
            sangvinictotal += sangvinic3;
            flegmatictotal += flegmatic3;
            melancolictotal += melancolic3;

            int[] scor = { sangvinictotal, colerictotal, flegmatictotal, melancolictotal };
            if (scor.Max() == sangvinictotal) textBox1.Text = textBox1.Text + "Sangvinic ";
            if (scor.Max() == colerictotal) textBox1.Text = textBox1.Text + "Coleric ";
            if (scor.Max() == flegmatictotal) textBox1.Text = textBox1.Text + "Flegmatic ";
            if (scor.Max() == melancolictotal) textBox1.Text = textBox1.Text + "Melancolic ";

            MessageBox.Show(textBox1.Text);

            strabunicu.Show();

            this.Close();
        
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Test2 newForm = new Test2();
            newForm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.Location = new Point(
    this.ClientSize.Width / 2 - panel3.Size.Width / 2,
    this.ClientSize.Height / 2 - panel3.Size.Height / 2);
            panel3.Anchor = AnchorStyles.None;
        }

        private void radioButton86_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
