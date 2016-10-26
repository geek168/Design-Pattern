using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class NoQuarterState : IState
    {
        GumballMachine GumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't insert any quarter!");
        }

        public void InsertQuarter()
        {
            GumballMachine.State = GumballMachine.HasQuarterState;
            Console.WriteLine("You inserted a quarter!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there is no quarter!");
        }
    }
}
