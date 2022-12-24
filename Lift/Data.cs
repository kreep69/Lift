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
        public object[] passenger_mas;
        List<object> passengers;
        int get_aof()
        { return amount_of_floors; }
        int get_aol() 
        { return amount_of_floors; }
        void addPasList()
        {

        }
    }
    
    
}
