int[,] matriz = new int[4, 4];

Console.WriteLine("Digite os valores da matriz:");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"Elemento [{i},{j}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}
int A = matriz[0, 0] + matriz[0, 1] + matriz[1, 0] + matriz[1, 1];
int B = matriz[2, 2] + matriz[2, 3] + matriz[3, 2] + matriz[3, 3];
int C = 0;
for (int i = 1; i < 4; i++)
{
    for (int j = 0; j < i; j++)
    {
        C += matriz[i, j];
    }
}
int D = 0;
for (int i = 0; i < 3; i++)
{
    for (int j = i + 1; j < 4; j++)
    {
        D += matriz[i, j];
    }
}
Console.WriteLine($"\nSoma da parte hachurada:");
Console.WriteLine($"(a) Canto superior esquerdo: {A}");
Console.WriteLine($"(b) Canto inferior direito: {B}");
Console.WriteLine($"(c) Abaixo da diagonal principal: {C}");
Console.WriteLine($"(d) Acima da diagonal principal: {D}");
    