using System;

int health = 100;
int poison = 8;

for (int turn = 1; turn <= 6; turn++)
{
    health = Math.Max(health - poison, 0);
    Console.WriteLine($"Turn {turn}: poison, {health} HP left");

    if (health == 0)
    {
        Console.WriteLine("Aya is down.");
        break;
    }
}

string status;

if (health > 70)
{
    status = "healthy";
}
else if (health > 30)
{
    status = "injured";
}
else if (health > 0)
{
    status = "critical";
}
else
{
    status = "Aya is down";
}

Console.WriteLine($"Aya has {health} HP: {status}");