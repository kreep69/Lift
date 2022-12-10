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
using System.IO;
using System.Resources;

namespace Lift
{
    public partial class Lifty : Form
    {
        Image pass_img;
        Point position = new Point(588, 60);

        public Lifty(int theme)
        {

            InitializeComponent();

            switch (theme)
            {
                case 1:
                    SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\..\..\res\Letov8bit.wav");
                    simpleSound.Play();
                    break;
                case 2:
                    SoundPlayer simpleSound1 = new SoundPlayer(Application.StartupPath + @"\..\..\res\Barb_BASS.wav");
                    simpleSound1.Play();
                    break;
                case 3:
                    SoundPlayer simpleSound2 = new SoundPlayer(Application.StartupPath + @"\..\..\res\Slipknot.wav");
                    simpleSound2.Play();
                    break;
                case 4:
                    SoundPlayer simpleSound3 = new SoundPlayer(Application.StartupPath + @"\..\..\res\Dozor.wav");
                    simpleSound3.Play();
                    break;

            }
            pass_img = Image.FromFile(Application.StartupPath + @"\..\..\res\passenger.png");
    

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
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X <= 480) timer1.Enabled = false;
            else timer1.Enabled=true;
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            
            dlgcreate dlgcreatewin = new dlgcreate();
            dlgcreatewin.ShowDialog();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            position.Offset(-5, 0);
            this.Invalidate();
        }
        public void Lifty_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Location = position;
            pictureBox1.Width = 26;
            pictureBox1.Height = 50;
            pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            if (pictureBox1.Location.X <= 480) timer1.Enabled=false;
        }

        
    }
}
