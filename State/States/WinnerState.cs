using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class WinnerState : IState
    {
        GumballMachine GumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("YOU ARE A WINNER! You get two gumballs for you quarter!");
            GumballMachine.ReleaseBall();
            GumballMachine.ReleaseBall();
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Error!");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Error!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Error!");
        }
    }
}
