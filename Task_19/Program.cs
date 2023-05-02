// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


Console.WriteLine("Ввудите данные: ");
string number = Console.ReadLine();
void PrintPolindrom(string [] array)
{
    string Pol = number;
    string NewPol = "";
    for (int i = Pol.Length - 1; i >=0; i--)
    {
        NewPol = NewPol + Pol[i];
    }
       for (int i = Pol.Length - 1; i >=0; i--)
    {
        Console.WriteLine(NewPol);
    }
    Console.WriteLine();
    for (int i = 0;i < Pol.Length;i++)
    {
        for (int j = 0; j < NewPol.Length; j++)
        {
            if (NewPol[j] == Pol[i])
            {
              Console.Write(true);
            }
            else
            {
                Console.Write(false);
            }
        }
    }
    
}

