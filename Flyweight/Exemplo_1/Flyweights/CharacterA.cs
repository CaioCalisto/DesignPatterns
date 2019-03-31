using System;

namespace Exemplo_1.Flyweights
{
    public class CharacterA : Character
    {
        public CharacterA()
        {
            this.simbol = 'A';
            this.height = 100;
            this.width = 120;
            this.ascent = 70;
            this.descent = 0;
        }

        public override void Display(int pointsize)
        {
            this.pointsize = pointsize;
            Console.WriteLine(string.Format("{0} ({1})", this.simbol, this.pointsize));
        }
    }
}
