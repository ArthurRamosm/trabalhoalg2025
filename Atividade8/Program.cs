using System.Linq;

int[] D = new int[20];

Console.WriteLine("Digite 20 numeros:");
for (int i = 0; i < D.Length; i++)
{
    D[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Digite um valor:");
int N = int.Parse(Console.ReadLine());

int[] compactado = D.Where(num => num > N).ToArray();

Console.WriteLine("Vetor compactado.");
Console.WriteLine("elementos maiores que o valor digitado");
Console.WriteLine(string.Join(", ", compactado));