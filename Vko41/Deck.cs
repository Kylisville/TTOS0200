using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JAMK_IT.MiniASIO
{
     class Deck
    {
        public List<Card> cards;
        public Deck()
        {
            cards = new List<Card>();
        }
       
        public void CreateDeck(int cardhouses)
        {
            for (int x = 0; x < cardhouses; x++)
            {
                cards.Add(new Heart { CardValue = (x + 1) });
                cards.Add(new Club { CardValue = (x + 1) });
                cards.Add(new Diamond { CardValue = (x + 1) });
                cards.Add(new Spade { CardValue = (x + 1) });

            }
        }
        public void ShowDeck()
        {
            int x = 1;
            foreach (Card card in cards)
            {
                Console.WriteLine(String.Format("{0} kortti on {1} #{2}", x, card.House, card.CardValue));
                x++;
            }
        }

        public List<Card> Shuffle()
        {
            int t = cards.Count;
            Random random = new Random();
            while (t > 1)
            {
                int s = random.Next(0, t);
                t--;
                Card value = cards[s];
                cards[s] = cards[t];
                cards[t] = value;
            }
            return cards;
        }

         


    }
    abstract class Card
    {
        public abstract string House { get; }
        private int cardvalue;
        public int CardValue
        {
            get { return cardvalue; }
            set
            {
                if (value <= 13)
                {
                    cardvalue = value;
                }
                else if (value % 13 == 0)
                {
                    cardvalue = 13;
                }
                else
                {
                    cardvalue = (value % 13);
                }
            }

        }


    }

    class Heart : Card
    {
        public override string House
        {
            get { return "Heart"; }
        }
    }
    class Spade : Card
    {
        public override string House
        {
            get { return "Spade"; }
        }
    }
    class Club : Card
    {
        public override string House
        {
            get { return "Club"; }
        }
    }
    class Diamond : Card
    {
        public override string House
        {
            get { return "Diamond"; }
        }
    }

    



}

