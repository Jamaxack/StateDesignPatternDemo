using StatePattern.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class CokeMachine
    {
        public int CokeCount { get; set; } = 0;
        public IState State { get; set; }
        public IState SoldOutState { get; set; }
        public IState SoldState { get; set; }
        public IState NoQuarterState { get; set; }
        public IState HasQuarterState { get; set; }
        //public IState WinnerState { get; set; }

        public CokeMachine(int cokesNumber)
        {
            SoldOutState = new SoldOutState(this);
            SoldState = new SoldState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            //WinnerState = new WinnerState(this);

            CokeCount = cokesNumber;
            if (CokeCount > 0)
            {
                State = NoQuarterState;
            }
        }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void ReleaseCoke()
        {
            CokeCount = --CokeCount;
            Console.WriteLine("Coke is released");
            //if (CokeCount % 10 == 0)
            //{
            //    Console.WriteLine("You are the winner, please turn the crank to get extra coke");
            //    State = WinnerState;
            //}
        }

        public void RefillCoke(int cokeCount)
        {
            CokeCount = cokeCount;
            State = NoQuarterState;
        }

        public override string ToString()
        {
            return $"Inventory: {CokeCount} cokes";
        }

    }
}
