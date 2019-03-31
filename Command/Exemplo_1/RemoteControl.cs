using System;
using Exemplo_1.Commands;

namespace Exemplo_1
{
    public class RemoteControl
    {
        ICommand[] comandosON;
        ICommand[] comandosOFF;

        public RemoteControl()
        {
            comandosOFF = new ICommand[3];
            comandosON = new ICommand[3];

            for (int i = 0; i < 3; i++)
            {
                comandosON[i] = null;
                comandosOFF[i] = null;
            }
        }

        public void SetCommand(int slot, ICommand on, ICommand off)
        {
            comandosON[slot] = on;
            comandosOFF[slot] = off;
        }

        public void PressButton(int slot)
        {
            if (comandosON[slot].IsRunning == false)
            {
                comandosON[slot].Execute();
                comandosON[slot].IsRunning = true;
                comandosOFF[slot].IsRunning = false;
            }
            else
                Console.WriteLine(string.Format("O comando {0} ja esta ativo", slot));
        }

        public void UnpressButton(int slot)
        {
            if (comandosOFF[slot].IsRunning == false)
            {
                comandosOFF[slot].Execute();
                comandosON[slot].IsRunning = false;
                comandosOFF[slot].IsRunning = true;
            }
            else
                Console.WriteLine(string.Format("O comando {0} ja esta inativo", slot));
        }

    }
}
