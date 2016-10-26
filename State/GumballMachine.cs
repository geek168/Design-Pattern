using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class GumballMachine
    {
        public IState HasQuarterState { get; set; }
        public IState NoQuarterState { get; set; }
        public IState SoldState { get; set; }
        public IState SoldOutState { get; set; }
        public IState WinnerState { get; set; }

        int Count = 0;
        public IState State { get; set; }

        public GumballMachine(int count)
        {
            HasQuarterState = new HasQuarterState(this);
            NoQuarterState = new NoQuarterState(this);
            SoldState = new SoldState(this);
            SoldOutState = new SoldOutState(this);
            WinnerState = new WinnerState(this);
            Count = count;
            if(count > 0)
            {
                State = NoQuarterState;
            }
        }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EejectQuerter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count != 0)
            {
                Count--;
            }
            if(Count > 0)
            {
                State = NoQuarterState;
            }
            else
            {
                State = SoldOutState;
                Console.WriteLine("Ops, out of gumballs!");
            }
        }

    }
}
