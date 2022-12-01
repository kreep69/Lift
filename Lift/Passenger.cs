using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift
{
    public class Passenger
    {

        bool wait = false, queue = true, lift_is_coming = false, in_lift = false, ended = false;
        int x = 790;
        int y = 85;
        public Image pass_img = Image.FromFile(@"\..\..\res\passenger.png");
        public Point pos = new Point(790, 85);
        public Passenger(int start_floor, int end_floor)
        {
            
            
             
        }
    }
}
 