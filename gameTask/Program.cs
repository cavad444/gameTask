Console.WriteLine("Please enter a sentence for reversing");
string soz = Console.ReadLine();
string soz2 = "";
List<String> list = new List<String>();

foreach (var item in soz.Split(' '))
{
    list.Add(item);
}
foreach (var item in list)
{
    for (int i = item.Length-1; i>=0 ; i--)
    {
        soz2 += item[i];
        if (i == 0)
        {
            soz2 += ' ';
        }
    }
}
Console.WriteLine(soz2);
