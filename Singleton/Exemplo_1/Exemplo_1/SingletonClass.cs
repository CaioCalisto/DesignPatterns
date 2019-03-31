using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    public class SingletonClass
    {
        private static SingletonClass instance;

        private SingletonClass()
        { }

        public static SingletonClass GetInstance()
        {
            if (instance == null)
            {
                Thread.Sleep(5000);
                instance = new SingletonClass();
            }

            return instance;
        }

    }
}
