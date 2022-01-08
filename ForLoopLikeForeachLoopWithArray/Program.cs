// See https://aka.ms/new-console-template for more information

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach(int num in numbers)
{
    Console.Write($"{num} ");
}

Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} ");
}

Console.WriteLine();


