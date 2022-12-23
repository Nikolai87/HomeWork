// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine ("Введите число A");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите число B");
int numberB = int.Parse(Console.ReadLine());

if(numberA > numberB)
    {
        Console.WriteLine($"max = {numberA}");
        Console.WriteLine($"min = {numberB}");
    }
else
    {  
        Console.WriteLine($"max = {numberB}");
        Console.WriteLine($"min = {numberA}");
    }    
