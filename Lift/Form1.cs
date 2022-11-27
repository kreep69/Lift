using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lift
{
    public partial class Lifty : Form
    {
        public Lifty(int theme)
        {
            
            InitializeComponent();
            switch (theme)
            {
                case 1:
                    SoundPlayer simpleSound = new SoundPlayer(@"D:\CProjects\Lift\Lift\res\Letov8bit.wav");
                    simpleSound.Play();
                    break;
                case 2:
                    SoundPlayer simpleSound1 = new SoundPlayer(@"D:\CProjects\Lift\Lift\res\Barb_BASS.wav");
                    simpleSound1.Play();
                    break;
                case 3:
                    SoundPlayer simpleSound2 = new SoundPlayer(@"D:\CProjects\Lift\Lift\res\Slipknot.wav");
                    simpleSound2.Play();
                    break;
                case 4:
                    SoundPlayer simpleSound3 = new SoundPlayer(@"D:\CProjects\Lift\Lift\res\Dozor.wav");
                    simpleSound3.Play();
                    break;
            }
        }

        private void Lifty_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Lifty2 interForm = new Lifty2();
            
            interForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            dlgcreate dlgcreatewin = new dlgcreate();
            dlgcreatewin.ShowDialog();
        }
    }
}
