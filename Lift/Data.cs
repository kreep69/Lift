using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift
{
    enum choosed_strat
    {
        less_time,

    }
    public struct Data
    {
        

        public string choosed_strat;
        int amount_of_floors;
        int amount_of_lifts;
        int pas_numb;
        
        List<object> passengers;
        int get_aof()
        { return amount_of_floors; }
        int get_aol() 
        { return amount_of_floors; }
        void addPasList(Passenger passenger)
        {
            passengers.Add(passenger);
            pas_numb++;
        }
        public Data(int amount_of_floors, int amount_of_lifts)
        {
            this.choosed_strat = "";
            this.amount_of_floors= amount_of_floors;
            this.amount_of_lifts= amount_of_lifts;
            this.passengers = null;
            this.pas_numb= 0;
        }
    }
    
    
}
