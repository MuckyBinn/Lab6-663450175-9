using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Nidorina nidorina = new Nidorina();
            pictureBox1.Image = nidorina.pic;
            Pokemon.Text = nidorina.name;
            pictureBox2.Image = Properties.Resources.Godzilla;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Raichu raichu = new Raichu();
            pictureBox1.Image = raichu.pic;
            Pokemon.Text = raichu.name;
            pictureBox2.Image = Properties.Resources.Godzilla;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Blastoise blastoise = new Blastoise();
            pictureBox1.Image = blastoise.pic;
            Pokemon.Text = (blastoise.name);
            pictureBox2.Image = Properties.Resources.Midousuji;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Wartortle wartortle = new Wartortle();
            pictureBox1.Image = wartortle.pic;
            Pokemon.Text =(wartortle.name);
            pictureBox2.Image = Properties.Resources.Midousuji;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Squirtle squirtle = new Squirtle();
            pictureBox1.Image = squirtle.pic;
            Pokemon.Text = squirtle.name;
            pictureBox2.Image = Properties.Resources.Garou;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pikachu pikachu = new Pikachu();
            pictureBox1.Image = pikachu.pic;
            Pokemon.Text = pikachu.name;
            pictureBox2.Image = Properties.Resources.Garou;
        }
    }
}
