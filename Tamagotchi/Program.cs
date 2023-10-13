Tamagotchi tama = new Tamagotchi();


Console.WriteLine("Döp din Tamagotchi");
tama.name = Console.ReadLine();

while (tama.GetAlive() == true)
{
    
    tama.PrintStats();
    Console.WriteLine($"1, lär {tama.name} ett nytt ord");
    Console.WriteLine($"2, få {tama.name} att säga ett ord");
    Console.WriteLine($"3, mata {tama.name}");
    Console.WriteLine("4, gör inget");
    


string Val = Console.ReadLine();
if (Val == "1")
{
    string word = Console.ReadLine();
    tama.Teach(word);
    tama.Tick();
}

if (Val == "2")
{
    tama.Hi();
    tama.Tick();
}

if (Val == "3")
{
    tama.Feed();
    tama.Tick();
}

else
{
    Console.WriteLine("Du gör inget");
    tama.Tick();
}
}

tama.Tick();

Console.WriteLine($"{tama.name} dog");

Console.ReadLine();