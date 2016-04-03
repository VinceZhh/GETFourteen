using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class PlayTable
    {
        private PokerCard pokerCard = new PokerCard();
        public PokerCard PokerCard
        {
            get { return pokerCard; }
            set { pokerCard = value; }
        }

        private List<Poker> poolPokerList = new List<Poker>();
        public List<Poker> PoolPokerList
        {
            get { return poolPokerList; }
            set { poolPokerList = value; }
        }

        public PlayTable()
        {
            poolPokerList.Add(pokerCard.getCard());
            poolPokerList.Add(pokerCard.getCard());
            poolPokerList.Add(pokerCard.getCard());
        }
    }
}
