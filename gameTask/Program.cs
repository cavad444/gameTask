int bulletCount = 30;
Console.WriteLine("Count of bullet:30");
Console.WriteLine("Enter a value");
bool isGameOn = true;
static int shoot(ref int bulletCount)
{
    return bulletCount--;

}
static bool exitGame(ref bool isGameOn)
{
    isGameOn = !isGameOn;
    return isGameOn;
}
static int reload(ref int bulletCount)
{
    return bulletCount = 30;
}
static int noBullet(ref int bulletCount)
{
    return bulletCount = 0;
}
while (isGameOn)
{
    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 1)
    {
        shoot(ref bulletCount);
        Console.WriteLine(bulletCount);
        Console.WriteLine("Gulle atildi");
    }else if (answer == 2)
    {
        noBullet(ref bulletCount);
    }else if(answer == 3)
    {
        reload(ref bulletCount);
    }else if (answer == 4)
    {
        Console.WriteLine("you left the game");
        exitGame(ref isGameOn);
    }else if(answer == 5)
    {
        Console.WriteLine(bulletCount);
    }
    else
    {
        Console.WriteLine("Please enter one of these value: 1,2,3,4,5");
    }

}
