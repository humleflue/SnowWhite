using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowWhite
{
    internal class Happy : ICharacter
    {
        public void React(CharactersContainer c)
        {
            if (!c.Contains(c.Grumpy))
            {
                Console.WriteLine("Happy misses his ying to his yang and goes to get Grumpy.");
                c.Add(c.Grumpy);
            }

            if (c.IsLast(this))
            {
                Console.WriteLine("Happy arrives last at the party, which makes the party get LIT!");
            }

            Console.WriteLine("In his intoxication of joy Happy dances out the door.");
            c.Remove(c.Happy);
        }

        public override string ToString()
        {
            return "Happy";
        }
    }
}
