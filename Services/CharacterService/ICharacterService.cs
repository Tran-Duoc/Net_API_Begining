using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupperHeroAPI.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetCharacter();
    }
}