using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokeMachine
{
    public enum CokeMachineState
    {
        NoQuarter,
        HasQuarter,
        Sold,
        SoldOut
    }

    public class CokeMachine
    {
        public int CokeCount { get; set; }
        public CokeMachineState State { get; set; }

        public CokeMachine(int cokesNumber)
        {
            CokeCount = cokesNumber;
            if (CokeCount > 0)
            {
                State = CokeMachineState.NoQuarter;
            }
        }

        public void InsertQuarter()
        {
            switch (State)
            {
                case CokeMachineState.NoQuarter:
                    Console.WriteLine("Quarter is inserted.");
                    State = CokeMachineState.HasQuarter;
                    break;
                case CokeMachineState.HasQuarter:
                    Console.WriteLine("The quarter is already inserted.");
                    break;
                case CokeMachineState.Sold:
                    Console.WriteLine("Please wait, we are already giving you coke");
                    break;
                case CokeMachineState.SoldOut:
                    Console.WriteLine("There is no coke left");
                    break;
                default:
                    break;
            }
        }

        public void EjectQuarter()
        {
            switch (State)
            {
                case CokeMachineState.NoQuarter:
                    Console.WriteLine("There is no quarter to eject.");
                    State = CokeMachineState.NoQuarter;
                    break;
                case CokeMachineState.HasQuarter:
                    Console.WriteLine("The quarter is ejected.");
                    break;
                case CokeMachineState.Sold:
                    Console.WriteLine("Sorry, you already turned the crank");
                    break;
                case CokeMachineState.SoldOut:
                    Console.WriteLine("There is no coke left");
                    break;
                default:
                    break;
            }

        }

        public void TurnCrank()
        {
            switch (State)
            {
                case CokeMachineState.NoQuarter:
                    Console.WriteLine("There is no quarter to turn the crank.");
                    break;
                case CokeMachineState.HasQuarter:
                    Console.WriteLine("Crank is turned.");
                    State = CokeMachineState.Sold;
                    Dispense();
                    break;
                case CokeMachineState.Sold:
                    Console.WriteLine("Turning twice doesn't give you another coke. (^_-)");
                    break;
                case CokeMachineState.SoldOut:
                    Console.WriteLine("There is no coke left");
                    break;
                default:
                    break;
            }
        }

        public void Dispense()
        {
            switch (State)
            {
                case CokeMachineState.NoQuarter:
                    Console.WriteLine("You need to pay first.");
                    break;
                case CokeMachineState.HasQuarter:
                    Console.WriteLine("Turn the Crank first.");
                    break;
                case CokeMachineState.Sold:
                    if (CokeCount > 0)
                    {
                        ReleaseCoke();
                        State = CokeMachineState.NoQuarter;
                        Console.WriteLine("Machine is ready, please insert the quarter");
                    }
                    else
                    {
                        Console.WriteLine("Oops, out of coke");
                        State = CokeMachineState.SoldOut;
                    }
                    break;
                case CokeMachineState.SoldOut:
                    Console.WriteLine("There is no coke left");
                    break;
                default:
                    break;
            }
        }

        void ReleaseCoke()
        {
            CokeCount = --CokeCount;
            Console.WriteLine("Coke is released");
        }

        public void RefillCoke(int cokeCount)
        {
            CokeCount = cokeCount;
            State = CokeMachineState.NoQuarter;
        }

        public override string ToString()
        {
            return $"Inventory: {CokeCount} cokes";
        }
    }
}
