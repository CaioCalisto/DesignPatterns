using System;

namespace Mediator
{
    /*
      Define um objeto que encapsula como determinados objetos se interagem
      Mediator promove baixo acoplamento por manter ligação de forma explicita, 
      e deixar eles interagirem independentemente

      Quando usar:
       - conjunto de objetos se comunicam de forma bem definida mas complexa
            O resultado, caso não use o Mediator, será dificil de entender
       - reutilizar objetos é dificil por que ele se comunica com varios objetos
       - o comportamento que é distribuido entre varias classes poderia 
            ser customizavel sem o montante de subclasses
     */
    class Program
    {
        static void Main(string[] args)
        {
            Chatroom chatroom = new Chatroom();

            Participant george = new Beatle("George");
            Participant john = new Beatle("John");
            Participant paul = new Beatle("Paul");
            Participant ringo = new Beatle("Ringo");
            Participant yoko = new NonBeatle("Yoko");

            chatroom.Register(george);
            chatroom.Register(john);
            chatroom.Register(paul);
            chatroom.Register(ringo);
            chatroom.Register(yoko);

            yoko.Send("John", "Hi John!");
            paul.Send("Ringo", "All you need is love");
            ringo.Send("George", "My sweet Lord");
            paul.Send("John", "Can't buy me love");
            john.Send("Yoko", "My sweet love");

            Console.ReadKey();
        }
    }
}
