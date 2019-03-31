﻿using System;

namespace Exemplo1.Parts
{
    public class Keyboard : IComputerParts
    {
        public void Accept(IVisitor visitor)
        { 
            visitor.Visit(this);
        }

        public void Execute()
        {
            Console.WriteLine("Executing some Action in Keyboard");
        }

    }
}
