using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Gunball
{
    public class Machine
    {
        public IState hasquarter { get; set; }
        public IState noquarter { get; set; }
        public IState soldout { get; set; }
        public IState sold { get; set; }
        private IState actualstate;

        public Machine()
        {
            hasquarter = new HasQuarterState(this);
            noquarter = new NoQuarterState(this);
            soldout = new SoldOutState(this);
            sold = new SoldState(this);
        }

        public void SetState(IState state)
        {
            actualstate = state;
        }

        public void InsertQuarter()
        {
            actualstate.InsertQuarter();
        }

        public void EjectQuarter()
        {
            actualstate.EjectQuarter();
        }

        public void TurnCrank()
        {
            actualstate.TurnCrank();
        }

        public void Dispense()
        {
            actualstate.Dispense();
        }

    }
}
