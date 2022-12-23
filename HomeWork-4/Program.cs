// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 о N.

Console.WriteLine ("Введите число ");
int N = int.Parse(Console.ReadLine());

for (int i = 2; i <= N; i += 2)
    {
        if (i == N)
        {
            Console.WriteLine($"{i}");
        }
        else Console.WriteLine($"{i}");
    }