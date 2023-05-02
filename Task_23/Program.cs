// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int ReadInt (string arg)
{
    Console.Write(arg);
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        Console.WriteLine("It's not a number. Try agane");
        Console.Write(arg);
    }
    return i;
}
int [] CubNumber(int number)
{
    int [] result = new int[number];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = (int)Math.Pow(i+1, 3);
    }
    return result;
}

PrintArray(CubNumber(number));

void PrintArray(int [] result)
{
    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine(result[i]);
    }
}