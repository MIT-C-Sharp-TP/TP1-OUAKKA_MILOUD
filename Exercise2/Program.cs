using System;

int health = 45;
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
    status = "meloud is down";
}

Console.WriteLine($"meloud has {health} HP: {status}");