
namespace Exemplo_1.Flyweights
{
    public abstract class Character
    {
        protected char simbol;
        protected int width;
        protected int height;
        protected int ascent;
        protected int descent;
        protected int pointsize;

        public abstract void Display(int pointsize);
    }
}
