using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SoldState : IState
    {

        GumballMachine GumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("The gumball is selling, you can't get any quarter!");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, the gumball is selling!");
        }

        public void TurnCrank()
        {
            GumballMachine.ReleaseBall();
        }
    }
}
