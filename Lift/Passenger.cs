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
        public enum passenger_state
        {
            not_spawned,
            wait,
            lift_is_coming,
            in_lift,
            ended
        }
        public int start_floor, end_floor;
        public passenger_state state = passenger_state.wait;
       
        public int x = 790;
        public int y = 85;
        public Image pass_img = Image.FromFile(@"\..\..\res\passenger.png");
        public Point pos = new Point(790, 85);
        public Passenger(int start, int end, int pas_numb)
        {
            start_floor= start;
            end_floor= end;              
        }
        
        int getstart() { return start_floor; }
        int getend() { return end_floor; }
    }
}
 