// See https://aka.ms/new-console-template for more information
string[] nomes = { "Ana", "Izabel", "Lívia", "Gabriel", "Pedro" };
Console.Write("Digite um nome para pesquisar: ");
string nomePesquisa = Console.ReadLine();
bool encontrado = false;
foreach (string nome in nomes)
{
    if (nome.Equals(nomePesquisa, StringComparison.OrdinalIgnoreCase))
    {
        encontrado = true;
        break; 
    }
}
if (encontrado)
{
    Console.WriteLine($"O nome {nomePesquisa} foi encontrado no vetor.");
}
else
{
    Console.WriteLine($"O nome {nomePesquisa} não está no vetor.");
}
