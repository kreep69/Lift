using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lift
{
    public class Manager 
    {
        int timer=0;
        
        void start_system()
        {
            Data data = new Data();
            Elevator elevator= new Elevator(5);
            system_is_running(data, elevator);
        }
        void system_is_running(Data data, Elevator elevator)
        {
            Passenger passenger = new Passenger(4, 8, data.pas_numb);
            while(true)
            {
                strategy_less_time(elevator, passenger, data);
                Thread.Sleep(1000);
                timer++;
            }
        }
        int strategy_less_time(Elevator elev, Passenger pass, Data data)
        {
            int direction;
            if (elev.numb_of_pas == elev.max_pas)
            {
                deliver_pass(data.elevators, data);
            }
            else
                if (elev.numb_of_pas < elev.max_pas) 
            {
				direction = minimize_path(data.elevators, pass.start_floor, data);
                if (direction < 0)
                {
                    best_elev(data.elevators, pass.start_floor, data).move_down();
                }
                else
                    if (direction > 0)
                {
                    best_elev(data.elevators, pass.start_floor, data).move_up();
                }
                else
                    if (direction == 0) 
                {
                    best_elev(data.elevators, pass.start_floor, data).pass_in(pass);

				}
			}

            
            return 0;
        }

        int deliver_pass(List<Elevator> elev, Data data) 
        {
			// Minimal pass path
			int min_path = data.amount_of_floors;
            Passenger pass = null;
			for (int i = 0; i < elev.Count; i++) 
            {
                for (int j = 0; j < elev[i].pass_array.Length; j++) 
                {
                    if (Math.Abs(elev[i].floor - elev[i].pass_array[j].end_floor) <= min_path)
                    {
                        min_path = elev[i].floor - elev[i].pass_array[j].end_floor;
                        pass = elev[i].pass_array[j];
                    }
                }
                if (min_path > 0)
                {
                    elev[i].move_up();
                }
                else
                    if (min_path < 0)
                {
                    elev[i].move_down();
                }
                else
                    if (min_path == 0)
                {
                    elev[i].pass_out(pass);
                }
            }
			return min_path;
        }


        int minimize_path(List<Elevator> elevs, int pass_floor, Data data) 
        {
            int path = data.amount_of_floors;
            for (int i = 0; i < elevs.Count; i++) 
            {
                if (Math.Abs(elevs[i].floor - pass_floor) < path) 
                {
                    path = elevs[i].floor - pass_floor;
				}
            }
            return path;
        }
		Elevator best_elev(List<Elevator> elevs, int pass_floor, Data data)
		{
			int path = data.amount_of_floors;
            
			for (int i = 0; i < elevs.Count; i++)
			{
				if (Math.Abs(elevs[i].floor - pass_floor) < path)
				{
					path = Math.Abs(elevs[i].floor - pass_floor);
                    if (i == elevs.Count - 1) 
                    {
                        return elevs[i];
                    }
				}
			}
            return null;
		}
		void pas_to_list(Passenger passenger, Data data)
        {
            data.passengers.Add(passenger);
            passenger.state = Passenger.passenger_state.wait;
            data.pas_numb++;
        }
    }
}
