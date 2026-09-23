Console.Write("Input character's name: ");
string name = Console.ReadLine();
Console.Write("Input number of battles: ");
int battles = int.Parse(Console.ReadLine());
Console.Write("Input EXP gained per battle: ");
int expPerBattle = int.Parse(Console.ReadLine());

int totalExp = 0;
Console.WriteLine("\n=== Battle Log ===");
for (int i = 1; i <= battles; i++)
{
    totalExp += expPerBattle;

    Console.WriteLine($"Battle {i} | EXP gained: {expPerBattle} | Total EXP: {totalExp}");
    if (totalExp % 100 == 0)
    {
        Console.WriteLine($"*** Milestone reached! Total EXP: {totalExp} ***");
    }
}

Console.WriteLine("\n=== BATTLE COMPLETE ===");
Console.WriteLine($"Character : {name}");
Console.WriteLine($"Battles   : {battles}");
Console.WriteLine($"Total EXP : {totalExp}");