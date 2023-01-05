using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC22
{
    internal class Task3
    {
        public string allRucksacks { get; }
        public Task3()
        {
            try
            {
                allRucksacks = File.ReadAllText("Text Files\\Task3_Data.txt").Replace('\r', ' ');
            }
            catch
            {
                Console.WriteLine("Supplies note was lost somehow, proceeding with empty note instead...");
                Console.WriteLine("Failed to open Text Files directory, Task3_Data file.");
                allRucksacks = "";
            }
        }
        public void CheckTheRucksacks()
        {
            int sumOfPriorities = 0;
            var rucksackArray = allRucksacks.Split('\n');
            foreach (var singleRucksack in rucksackArray)
            {
                sumOfPriorities += FindTheDoubles(singleRucksack.Replace('\n', ' '));
            }
            Console.WriteLine($"Sum of priorities of all doubles in all {rucksackArray.Length} rucksacks is {sumOfPriorities}.");
        }
        int FindTheDoubles(string rucksack)
        {
            char[] firstCompartment = rucksack.Substring(0, rucksack.Length / 2).ToCharArray();
            char[] secondCompartment = rucksack.Substring(firstCompartment.Length).ToCharArray();
            int i = 0;
            while (firstCompartment.Length > i)
            {
                if (secondCompartment.Contains(firstCompartment[i]))
                {
                    if ((int)secondCompartment[i] < 93) { return ((int)secondCompartment[i] - 38); }
                    else return ((int)secondCompartment[i] - 96);
                }
                else i++;
            }
            return 0; //No doubles found in the rucksack.
        }
    }
}
