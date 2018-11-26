using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public class SoldState : IState
    {
        CokeMachine machine;

        public SoldState(CokeMachine machine)
        {
            this.machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we are already giving you coke");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't give you another coke");
        }

        public void Dispense()
        {
            if (machine.CokeCount > 0)
            {
                machine.ReleaseCoke();
                machine.State = machine.NoQuarterState;
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
