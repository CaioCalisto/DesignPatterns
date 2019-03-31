using System; 

namespace Mediator
{
    public class NonBeatle : Participant
    {
        public NonBeatle(string name)
            : base(name)
        { }

        public override void Receive(string from, string message)
        {
            Console.Write($"To a Non Beatle: ");
            base.Receive(from, message);
        }
    }
}
