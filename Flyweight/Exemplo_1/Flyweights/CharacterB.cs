using System;

namespace Exemplo_1.Flyweights
{
    public class CharacterB : Character
    {
        public CharacterB()
        {
            this.simbol = 'B';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }

        public override void Display(int pointsize)
        {
            this.pointsize = pointsize;
            Console.WriteLine(string.Format("{0} ({1})", this.simbol, this.pointsize));
        }
    }
}
