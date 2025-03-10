int[] R = new int[5];
int[] A = new int[10];

Console.WriteLine("Digite os 5 numeros do gabarito");
for (int i = 0; i < R.Length; i++)
{
    R[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Digite os 10 numeros da aposta:");
for (int i = 0; i < A.Length; i++)
{
    A[i] = int.Parse(Console.ReadLine());
}
int pontos = 0;
foreach (int numeroAposta in A)
{
    if (Array.Exists(R, num => num == numeroAposta))
    {
        pontos++;
    }
}
Console.WriteLine($"O apostador fez o total de {pontos} pontos.");