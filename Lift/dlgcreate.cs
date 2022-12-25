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
    public partial class dlgcreate : Form
    {
        public dlgcreate()
        {
            InitializeComponent();
        }

        private void dlgcreate_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void create_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_done_Click(object sender, EventArgs e)
        {
            Passenger passenger = new Passenger(Decimal.ToInt32(numericUpDown1.Value), Decimal.ToInt32(numericUpDown2.Value), );
            
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
