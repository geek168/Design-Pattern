using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class HasQuarterState : IState
    {
        GumballMachine GumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumbal dispense!");
        }

        public void EjectQuarter()
        {
            GumballMachine.State = GumballMachine.NoQuarterState;
            Console.WriteLine("Quarter returned!");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter!");
        }

        public void TurnCrank()
        {
            if (new Random().Next(0, 10) == 1)
            {
                GumballMachine.State = GumballMachine.WinnerState;
            }
            else
            {
                GumballMachine.State = GumballMachine.SoldState;
            }
            Console.WriteLine("You turned crank...");
        }
    }
}
