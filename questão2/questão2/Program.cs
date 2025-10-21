// See https://aka.ms/new-console-template for more information
Console.WriteLine("digite o número inicial");
int start = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um número final");
int end = int.Parse(Console.ReadLine());
for (int i = start; i <= end; i++)
{
    Console.WriteLine($"\n Tabuada do {i}:");
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
}
