using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LINQ_Anatomy
{
    public class Deck
    {
        private static Random random = new Random();

        public static IEnumerable<Card> FillDeck()
        {
            for (int i = 0; i < 52; i++)
            {
                Card.Suites Suite = (Card.Suites)(Math.Floor((decimal)i / 13));
                var value = i % 13 + 2;
                yield return new Card(value, Suite);    
            }
        }

        public static IEnumerable<Card> GetSample()
        {
            yield return FillDeck().Single(x => x.Value == 11 && x.Suite == Card.Suites.HEARTS);
            yield return FillDeck().Single(x => x.Value == 9 && x.Suite == Card.Suites.DIAMONDS);
            yield return FillDeck().Single(x => x.Value == 4 && x.Suite == Card.Suites.HEARTS);
            yield return FillDeck().Single(x => x.Value == 10 && x.Suite == Card.Suites.HEARTS);
            yield return FillDeck().Single(x => x.Value == 3 && x.Suite == Card.Suites.SPADES);
            yield return FillDeck().Single(x => x.Value == 6 && x.Suite == Card.Suites.HEARTS);
        }
        public IEnumerable<Card> Shuffle()
        {
            return FillDeck().OrderBy(x => random.Next());
        }
    }
}
