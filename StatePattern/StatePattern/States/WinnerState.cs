using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public class WinnerState : IState
    {
        CokeMachine machine;

        public WinnerState(CokeMachine machine)
        {
            this.machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("You are already winner, You will get coke for free");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You are already winner, You will get coke for free");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You are already winner, You will get coke for free");
        }

        public void TurnCrank()
        {
            if (machine.CokeCount > 0)
            {
                machine.ReleaseCoke();
                machine.State = machine.NoQuarterState;
                Console.WriteLine("Enjoy free coke.");
                Console.WriteLine("Machine is ready, please insert the quarter");
            }
            else
            {
                Console.WriteLine("Oops, out of coke");
                machine.State = machine.SoldOutState;
            }
        }
    }
}
