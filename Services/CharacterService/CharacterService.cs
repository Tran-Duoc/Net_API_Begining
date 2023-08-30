using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupperHeroAPI.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> knight = new List<Character>{
            new Character(),
            new Character {
                Name = "Minh Thu",
                Id = 1
            }


        };

        public List<Character> GetCharacter()
        {
            return knight;
        }


    }
}