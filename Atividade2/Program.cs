using System.Globalization;

Console.WriteLine("Digite Altura:");
double Altura = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a inicial do seu sexo:");
String sexo = (Console.ReadLine(). ToUpper());

if (sexo == "M") {
    double PesoIdealM = ((72.7 * Altura) - 58);
    Console.WriteLine("Seu peso ideal é: " + PesoIdealM.ToString("F2"));

}
if (sexo == "F")
{
    double PesoIdealF = ((62.1 * Altura) - 44.7);
    Console.WriteLine("Seu peso ideal é: " + PesoIdealF.ToString("F2"));

}





