using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public class NoQuarterState : IState
    {
        CokeMachine machine;

        public NoQuarterState(CokeMachine machine)
        {
            this.machine = machine;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("Quarter is inserted.");
            machine.State = machine.HasQuarterState;
        }

        public void EjectQuarter()
        {
            Console.WriteLine("There is no quarter to eject.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("There is no quarter to turn the crank.");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first.");
        }



    }
}
