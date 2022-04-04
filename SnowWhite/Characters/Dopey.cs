using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowWhite
{
    internal class Dopey : ICharacter
    {
        public void React(CharactersContainer c)
        {
            if (c.Contains(c.Grumpy))
            {
                Console.WriteLine("Dopey tries to cheer up Grumpy with his goofyness. Grumpy finds this repelling and leaves.");
                c.Remove(c.Grumpy);
            }

            if (!c.Contains(c.Doc))
            {
                Console.WriteLine("Dopey feels lost without his leader. Therefore he goes to find Doc.");
                c.Add(c.Doc);
            }

            if (c.IsLast(this))
            {
                Console.WriteLine("Dopey is last in line for the cake. He trembles and ruins the cake!");
            }
        }

        public override string ToString()
        {
            return "Dopey";
        }
    }
}
