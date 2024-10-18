using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string line = Console.ReadLine();
            //将输入的数字转为int,赋值给numberOfCards
            if (int.TryParse(line, out int numberOfCards))
            {
                //
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }

        }
    }
}
