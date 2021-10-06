using System;

namespace diceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
            Console.WriteLine("============================");
            Console.WriteLine("□您的點數小於12獲得一隻小貓吊飾");
            Console.WriteLine("□您的點數大於12獲得一台筆電");
            Console.WriteLine("□您的點數大於18獲得一台車");
            Console.WriteLine("□您的點數等於10獲得雙人旅遊行程");
            Console.WriteLine("============================");
            Console.WriteLine("◇點數加級：3個同點+額外6點");
            Console.WriteLine("◇點數加級：2個同點+額外2點");
            Console.WriteLine("============================");
            



            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("您骰到3個同點  + 額外6點\n↓↓↓↓↓ ");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("您骰到2個同點  + 額外2點\n↓↓↓↓↓  ");
                    total += 2;
                }
            }

            if (total >= 18)
            {
                Console.WriteLine("恭喜!!!您獲得一台車");
            }
            else if (total >= 12)
            {
                Console.WriteLine("恭喜!!!您獲得一台筆電");
            }
            else if (total == 10)
            {
                Console.WriteLine("恭喜!!!您獲得雙人旅遊行程");
            }
            else
            {
                Console.WriteLine("恭喜!!!您獲得一隻小貓吊飾");
            }
        }
    }
}
