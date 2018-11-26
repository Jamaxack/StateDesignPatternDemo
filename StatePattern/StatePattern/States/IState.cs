using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public interface IState
    {
        void InsertQuarter();

        void EjectQuarter();

        void TurnCrank();

        void Dispense();
    }
}
