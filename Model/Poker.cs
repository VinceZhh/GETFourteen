using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Model
{
    public class Poker
    {
        private string color;//牌的花色

        private int num;//牌的大小

        public int Num
        {
            get { return num; }
        }

        public Poker(string coler_, int num_, Image image_)
        {
            this.color = coler_;
            this.num = num_;
            this.cardImage = image_;
        }

        private Image cardImage;

        public Image CardImage
        {
            get { return cardImage; }

        }

        public double GetPoint()
        {
            if (color == "CLUB")
                return 0.5;
            else if (color == "SPADE")
                return 1;
            else if (color == "HEARTS")
                return 0.75;
            else
                return 0.25;
        }

        public override string ToString()
        {
            return color + num.ToString()+" ";
        }
    }
}
