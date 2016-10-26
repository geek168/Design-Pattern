using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SoldOutState : IState
    {

        GumballMachine GumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("Gumball machine has sold out!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sold out, you can't eject quarter!");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Sold out, you can't insert quarter!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but the gumball machine has sold out!");
        }
    }
}
