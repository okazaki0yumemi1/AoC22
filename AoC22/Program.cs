using System.Threading.Tasks;
using AoC22;

Console.WriteLine("Task 1:");
Task1 First = new Task1();
if (First.backpack != "") { First.Calculate(); }
else Console.WriteLine("Unable to read the file.");
Console.WriteLine("Task 2:");
Task2 Second = new Task2();
if (Second.strategy != "") { Second.PlayTheGame(); }
else Console.WriteLine("Unable to read the file.");
Task3 Thrird = new Task3();
Console.WriteLine("Task 3:");
if (Thrird.allRucksacks != "") { Thrird.CheckTheRucksacks(); }
else Console.WriteLine("Unable to read the file.");

