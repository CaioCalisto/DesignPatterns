using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Gunball
{
    public class NoQuarterState : IState
    {
        private Machine machine;

        public NoQuarterState(Machine machine)
        {
            this.machine = machine;
        }

        public void InsertQuarter()
        {
            machine.SetState(machine.soldout);
            throw new NotImplementedException();
        }

        public void EjectQuarter()
        {
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }

        public void Dispense()
        {
            throw new NotImplementedException();
        }
    }
}
