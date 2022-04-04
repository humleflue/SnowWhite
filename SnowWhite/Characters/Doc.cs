using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowWhite
{
    public class Doc : ICharacter
    {
        public void React(CharactersContainer c)
        {
            if(c.Contains(c.Dopey))
            {
                Console.WriteLine("Doc realizes that Dopey has disappeared.");
                c.Remove(c.Dopey);
            }
            
            if(!c.Contains(c.Happy))
            {
                Console.WriteLine("Doc realizes that Happy has not joined the party, and goes to find him.");
                c.Add(c.Happy);
            }

            if(c.IsLast(this))
            {
                Console.WriteLine("Doc does not like being last to the party, so he decides to dip.");
                c.Remove(this);
            }
        }

        public override string ToString()
        {
            return "Doc";
        }
    }
}
