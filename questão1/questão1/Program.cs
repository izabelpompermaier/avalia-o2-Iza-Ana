// See https://aka.ms/new-console-template for more information
Console.WriteLine("digite suas três notas:");
int nota1 = int.Parse(Console.ReadLine());
int nota2 = int.Parse(Console.ReadLine());
int nota3 = int.Parse(Console.ReadLine());
Console.WriteLine("peso da primeira prova: 1");
Console.WriteLine("peso da segunda prova: 2");
Console.WriteLine("peso da terceira prova: 3");
double media= ((nota1*1)+(nota2*2)+(nota3*3))/(1 + 2 + 3);
Console.WriteLine($"Sua média é de {media}");
if (media > 7)
{
    Console.WriteLine("Você foi aprovado");
}
else if ( media >= 5)
{
    Console.WriteLine("Você está de recuperação");
}
else if (media < 5)
{
    Console.WriteLine("Você foi de reprovado");
}
