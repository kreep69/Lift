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

            //for (int i = 0; i < Data.passenger_mas.Length; i++) { }

            //Form1_Paint();
            this.Close();
        }
    }
}
