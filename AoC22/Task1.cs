using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC22
{
    internal class Task1
    {
        public string backpack { get; set; }
        public Task1()
        {
            try
            {
                backpack = File.ReadAllText("Text Files\\Task1_Data.txt").Replace('\r', ' ');
            }
            catch
            {
                Console.WriteLine("Failed to open elven list with supplies written on it, proceeding with empty list");
                Console.WriteLine("Failed to open Text Files directory, Task1_Data file.");
                backpack = "";
            }
        }
        public void Calculate()
        {
            var backpackLines = backpack.Split("\n");
            int i = 0, slotMaxCalories = 0;
            List<int> elvesAndCalories = new List<int>();
            foreach (var line in backpackLines)
            {
                if (line == " ")
                {
                    slotMaxCalories = (slotMaxCalories <= i) ? i : slotMaxCalories;
                    elvesAndCalories.Add(i);
                    i = 0;
                }
                else if (backpackLines.Last() == line)
                {
                    i += Convert.ToInt32(line);
                    slotMaxCalories = (slotMaxCalories <= i) ? i : slotMaxCalories;
                    elvesAndCalories.Add(i);
                }
                else i += Convert.ToInt32(line);
            }
            var res = elvesAndCalories.ToArray();
            i = 0;
            while (res.Length > ++i)
            {
                if (res[i] == slotMaxCalories) { Console.WriteLine($"Elf {i} is carrying {slotMaxCalories} worth of calories."); }
            }
        }
    }
}
