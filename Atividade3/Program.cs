Console.WriteLine("Digite um numero de 1 a 7 para saber o dia da semana correspodente:");
int semana = int.Parse(Console.ReadLine());

if (semana >=1 || semana >= 7) {
    switch (semana)
    {
        case 1:
            Console.WriteLine("Domingo");
            break;
        case 2:
            Console.WriteLine("Segunda-Feira");
            break;
        case 3:
            Console.WriteLine("Terça-Feira");
            break;
        case 4:
            Console.WriteLine("Quarta-Feira");
            break;
        case 5:
            Console.WriteLine("Quinta-Feira");
            break;
        case 6:
            Console.WriteLine("Sexta-Feira");
            break;
        case 7:
            Console.WriteLine("Sabado");
            break;
    }

}