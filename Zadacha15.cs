Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

{while (a>7)
    {
        a = a - 7;
    }
    if (a>=1 && a<=5)
    {
         Console.WriteLine("Является ли данный день выходным? Нет");
    }
    else if (a>=6 && a<=7)
    {
        Console.WriteLine("Является ли данный день выходным? Да");
    }
}
