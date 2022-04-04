using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowWhite
{
    public class CharactersContainer
    {
        public ICharacter Doc { get; } = new Doc();
        public ICharacter Dopey { get; } = new Dopey();
        public ICharacter Grumpy { get; } = new Grumpy();
        public ICharacter Happy { get; } = new Happy();
        private List<ICharacter> ActiveCharacters { get; } = new List<ICharacter>();
        private int MaxRoundsAmount { get; }

        public CharactersContainer(int initialCharactersAmount, int maxRoundsAmount)
        {
            MaxRoundsAmount = maxRoundsAmount;

            Random rand = new Random();
            List<ICharacter> characters = new List<ICharacter>()
            {
                Doc,
                Dopey,
                Grumpy,
                Happy
            };

            for (int i = 0; i < initialCharactersAmount; i++)
            {
                int randomIndex = rand.Next(0, characters.Count);
                Add(characters[randomIndex]);
            }
        }

        public void Run()
        {
            int lastCount = ActiveCharacters.Count,
                totalRounds = 0;

            void removeFirst()
            {
                Console.WriteLine(ActiveCharacters[0] + " decides to leave the party.");
                ActiveCharacters.RemoveAt(0);
            }

            // Run MaxRoundsAmount of reactions
            while (ActiveCharacters.Count > 0 && totalRounds < MaxRoundsAmount)
            {
                ActiveCharacters[0].React(this);
                if(lastCount == ActiveCharacters.Count)
                    removeFirst();

                totalRounds++;
            }

            // The rest of the characters leaves the party
            while(ActiveCharacters.Count > 0)
                removeFirst();

            Console.WriteLine("Amazing party!");
        }

        public bool Contains(ICharacter character)
        {
            return ActiveCharacters.Contains(character);
        }

        public void Add(ICharacter character)
        {
            if(!ActiveCharacters.Contains(character))
            {
                Console.WriteLine(character + " just arrived at the party!");
                ActiveCharacters.Add(character);
            }
        }

        public void Remove(ICharacter character)
        {
            ActiveCharacters.Remove(character);
        }

        public bool IsLast(ICharacter character)
        {
            return ActiveCharacters.Last().Equals(character);
        }
    }
}
