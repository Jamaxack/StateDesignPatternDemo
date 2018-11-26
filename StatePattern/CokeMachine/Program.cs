using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var cokeMachine = new CokeMachine(cokesNumber: 7);
            Console.WriteLine(cokeMachine);
            cokeMachine.InsertQuarter();
            cokeMachine.TurnCrank();

            Console.WriteLine(cokeMachine);
            cokeMachine.InsertQuarter();
            cokeMachine.TurnCrank();



            Console.Read();

        }
    }
}
