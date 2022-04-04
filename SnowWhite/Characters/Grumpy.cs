using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowWhite
{
    internal class Grumpy : ICharacter
    {
        public void React(CharactersContainer c)
        {
            if (c.Contains(c.Doc))
            {
                Console.WriteLine("Grumpy is at his worst. This irritates Doc, so he ends up leaving.");
                c.Remove(c.Doc);
            }

            if (!c.Contains(c.Dopey))
            {
                Console.WriteLine("Grumpy misses someone to cheer him up, so he is glad to hear that Dopey is soon arriving at the party.");
                c.Add(c.Dopey);
            }

            if (c.IsLast(this))
            {
                Console.WriteLine("Grumpy is sitting in the corner being... Grumpy.");
            }
        }

        public override string ToString()
        {
            return "Grumpy";
        }
    }
}
