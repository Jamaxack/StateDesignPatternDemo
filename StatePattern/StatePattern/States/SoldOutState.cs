using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public class SoldOutState : IState
    {
        CokeMachine machine;

        public SoldOutState(CokeMachine machine)
        {
            this.machine = machine;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("There is no coke left");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("There is no coke left");
        }

        public void TurnCrank()
        {
            Console.WriteLine("There is no coke left");
        }
        public void Dispense()
        {
            Console.WriteLine("There is no coke left");
        }
    }
}
