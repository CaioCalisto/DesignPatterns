using System; 

namespace Mediator
{
    public class Participant
    {
        private Chatroom chatroom;
        private string name;

        public Participant(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }

        public Chatroom ChatRoom
        {
            get { return this.chatroom; }
            set { this.chatroom = value; }
        }

        public void Send(string to, string message)
        {
            this.chatroom.Send(this.name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"{from} to {this.name}: {message}");
        }

    }
}
