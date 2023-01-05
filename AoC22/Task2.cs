using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC22
{
    internal class Task2
    {
        public string strategy { get; }
        public Task2()
        {
            try
            {
                strategy = File.ReadAllText("Text Files\\Task2_Data.txt").Replace('\r', ' ');
            }
            catch
            {
                Console.WriteLine("Failed to get strategy note from the elf, skipping the game itself...");
                Console.WriteLine("Failed to open Text Files directory, Task2_Data file.");
                strategy = "";
            }
        }
        public void PlayTheGame()
        {
            var strategyLines = this.strategy.Split("\n");
            int score = 0;
            foreach (var line in strategyLines)
            {
                var actions = line.Split('\n');
                score += this.CalculateMatchResult(actions[0][0], actions[0][2]);
            }
            Console.WriteLine($"The score is {score}");
        }
        private int CalculateMatchResult(char opponent, char elf)
        {
            int opponentAction = (int)opponent - 64;
            int elfAction = (int)elf - 87;
            switch (opponentAction - elfAction)
            {
                case 0: { return (3 + elfAction); } //Draw
                case -1: { return (0 + elfAction); } //Loss
                case 1: { return (6 + elfAction); } //Victory
                default: return -1;
            }
        }
    }
}
