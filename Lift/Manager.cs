using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lift
{
    public class Manager 
    {
        int timer=0;
        
        void start_system()
        {
            Data data = new Data();
            Elevator elevator= new Elevator(5);
            system_is_runing(data, elevator);
        }
        void system_is_runing(Data data, Elevator elevator)
        {
            Passenger passenger = new Passenger(4, 8, data.pas_numb);
            while(true)
            {                
                Thread.Sleep(1000);
                timer++;
            }
        }
        int strategy_less_time(Elevator elev, Passenger pass)
        {
            return 0;
        }
        void pas_to_list(Passenger passenger, Data data)
        {
            data.passengers.Add(passenger);
            passenger.state = Passenger.passenger_state.wait;
            data.pas_numb++;
        }
    }
}
