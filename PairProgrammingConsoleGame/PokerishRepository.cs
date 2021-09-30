using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingConsoleGame
{
    public class PokerishRepository
    {
        public readonly List<PokerishGame> _repo = new List<PokerishGame>();

        //Add
        public bool AddToDirectory(PokerishGame content)
        {
            int startingCount = _repo.Count;

            _repo.Add(content);

            bool wasAdded = (_repo.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public List<PokerishGame> GetName()
        {
            return _repo;
        }
    }
}
