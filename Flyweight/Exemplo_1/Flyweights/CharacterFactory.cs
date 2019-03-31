using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Flyweights
{
    public class CharacterFactory
    {
        private Dictionary<char, Character> characters;

        public CharacterFactory()
        {
            characters = new Dictionary<char, Character>();
        }

        public Character GetCharacted(char key)
        {
            Character character = null;

            if (characters.ContainsKey(key))
                character = characters[key];
            
            switch(key)
            {
                case 'A':
                    character = new CharacterA();
                    break;
                case 'B': 
                    character = new CharacterB();
                    break;                  
            }

            return character;
        }





    }
}
