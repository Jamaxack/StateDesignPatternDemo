using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public class HasQuarterState : IState
    {
        CokeMachine machine;

        public HasQuarterState(CokeMachine machine)
        {
            this.machine = machine;
        }
        public void EjectQuarter()
        {
            Console.WriteLine("The quarter is ejected.");
            machine.State = machine.NoQuarterState;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("The quarter is already inserted.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Crank is turned.");
            machine.State = machine.SoldState;
        }

        public void Dispense()
        {
            Console.WriteLine("Turn the Crank first.");
        }
    }
}
