double[] notas = new double[6];

Console.WriteLine("Digite as notas");
for (int i = 0; i < notas.Length; i++)
{
    notas[i] = double.Parse(Console.ReadLine());
}
double maiorNota = notas.Max();
double menorNota = notas.Min();
double total = notas.Sum() - maiorNota - menorNota;

Console.WriteLine($"Nota final: {total:F2}");