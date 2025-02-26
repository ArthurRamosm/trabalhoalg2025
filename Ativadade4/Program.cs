Console.WriteLine("Digite o numero de horas trabalhadas no mês:");
double HorasMes = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o salario por hora:");
double SalarioHora = double.Parse(Console.ReadLine());

double SalarioTotal, HorasExtras;
HorasExtras = HorasMes - 160;
SalarioTotal = (HorasExtras * 0.50) + (SalarioHora * HorasMes);

Console.WriteLine("O salario total do funcionário é " + SalarioTotal);


