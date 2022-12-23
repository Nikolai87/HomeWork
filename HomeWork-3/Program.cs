// Напишите программу, котрая на вход принимает число и выдает, является ли число четным

Console.WriteLine ("Введите число ");
int number = int.Parse(Console.ReadLine());

if(number % 2 == 0)
    {
        Console.WriteLine($"{number} - число четное");
    }

else
    {
        Console.WriteLine($"{number} - число нечетное");
    }