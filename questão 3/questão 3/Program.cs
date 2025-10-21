// See https://aka.ms/new-console-template for more information
        
int votosCandidatoA = 0;
int votosCandidatoB = 0;
int votosCandidatoC = 0;
int votosNulos = 0;
while (true) 
{
   Console.Write("\nDigite seu voto:");
   Console.Write("\n1 para Candidato A");
   Console.Write("\n2 para Candidato B");
   Console.Write("\n3 para Candidato C");
   Console.Write("\n9 para Voto Nulo");
   Console.Write("\n0 para encerrar\n");
   int voto;
   bool parseSuccess = int.TryParse(Console.ReadLine(), out voto);
   if (!parseSuccess)
   {
       Console.WriteLine("Entrada inválida. Por favor, digite um número.");
       continue;
   }
   if (voto == 0)
   {
        break;
   }
    switch (voto)
    {
        case 1:
            votosCandidatoA++;
            break;
        case 2:
            votosCandidatoB++;
            break;
        case 3:
            votosCandidatoC++;
            break;
        case 9:
            votosNulos++;
            break;
        default:
            Console.WriteLine("Voto inválido. Por favor, digite um número válido.");
            break;
    }
}
        Console.WriteLine($"Total de votos para o Candidato A: {votosCandidatoA}");
        Console.WriteLine($"Total de votos para o Candidato B: {votosCandidatoB}");
        Console.WriteLine($"Total de votos para o Candidato C: {votosCandidatoC}");
        Console.WriteLine($"Total de votos nulos: {votosNulos}");
