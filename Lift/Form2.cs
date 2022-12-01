using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lift
{
    public partial class Lifty2 : Form
    {
        int theme;
        public Lifty2()
        {
            
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lifty mainForm = new Lifty(theme);
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lifty2_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            switch(selectedState){
                case "без саундтрека":
                    theme = 0;
                    break;
                case "трек 1":
                    theme = 1;
                    break;
                case "трек 2":
                    theme = 2;
                    break;
                case "трек 3":
                    theme = 3;
                    break;
                case "трек 4":
                    theme = 4;
                    break;
                default:
                    theme = 1;
                    break;

            }
        }
       
    }
}
