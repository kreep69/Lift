using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift
{
    public class Elevator
    {
        int floor, numb_of_pas, dest_floor, max_pas;
        object[] pass_array;
        public Elevator(int max_pas)
        {
            this.max_pas= max_pas;
            floor = 1;
            numb_of_pas = 0;
            object[] pass_array = new object[max_pas];
            pass_array= null;
        }
        void pass_in(Passenger pass)
        {
            numb_of_pas++;
            for (int i =0; i<max_pas;i++)
            {
                if (this.pass_array[i]== null)
                {

                }
            }
        }
        void pass_out(Passenger pass) 
        {

        }
        int move_down()
        {
            this.floor--;
            return floor; 
        }
        int move_up() 
        {
            this.floor++;
            return floor; 
        }
        int getfloor() { return floor; }
    }
}
