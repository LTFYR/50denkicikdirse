
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int[] arr = { };
    if (num <= 50)
{
    for (int i = 4; i <= num; i++)
    {
        if (i % 3 == 0)
        {
            count++;
        }
    }
}
    else if (num > 50 && num <= 100)
{
    for (int i = 6; i < num; i++)
    {
        if (i % 5 == 0)
        {
            count++;
            Console.WriteLine(i);
        }
    }
}
    else
{
    for (int i = 9; i <= num; i++)
    {
        if (i % 8 == 0)
        {
            count++;
        }
    }
}
Console.WriteLine(count);