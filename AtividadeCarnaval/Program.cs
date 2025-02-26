

Console.WriteLine("Digite o valor da média de vendas:");
double MediaVendas = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor atual do produto:");
double PrecoAtual = double.Parse(Console.ReadLine());

if ((MediaVendas < 500) && (PrecoAtual < 30))
{
    double Acresc = 0.10;
    PrecoAtual = ((PrecoAtual * Acresc) + PrecoAtual);

    Console.WriteLine($"O novo preço é:  {PrecoAtual}");
}
else {       
    double Reducao = 0.20;
    PrecoAtual = (PrecoAtual -(PrecoAtual * Reducao));

    Console.WriteLine($"O novo preço é:  { PrecoAtual}");
}