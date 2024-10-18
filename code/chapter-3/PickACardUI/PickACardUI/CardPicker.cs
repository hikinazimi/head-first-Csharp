using System;
using System.Collections.Generic;
using System.Text;

namespace PickACardUI
{
    class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numerOfCards)
        {
            string[] pickedCards = new string[numerOfCards];
            for (int i = 0; i < numerOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomValue()
        {
            //1-4的随机数
            int value = random.Next(1, 5);

            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Culbs";
            return "Diamonds";
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 14);

            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }
    }
}